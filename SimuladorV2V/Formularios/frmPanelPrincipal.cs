using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using EmuladorV2I.Utilidades;
using EmuladorV2I.Interfaces;
using EmuladorV2I.Clases;
using System.Threading;

namespace EmuladorV2I
{
    public partial class frmPanelPrincipal : Form, BluetoothObservador
    {
        private Capture webCam = null;
        private Image<Bgr, Byte> imgOriginal;
        private bool enEjecucion;

        public frmPanelPrincipal()
        {
            InitializeComponent();
        }

        private void frmPanelPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    webCam = new Capture();
                }  
                catch (Exception exception)
                {
                    MessageBox.Show("No hay ninguna cámara conectada. Revisa las conexiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    String error = exception.Message;
                }    
                Application.Idle += ProcesarImagen;
                Bluetooth.Instancia.NuevoObservador(this);
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void frmPanelPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (webCam != null)
                {
                    webCam.Dispose();
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void ProcesarImagen(object sender, EventArgs e)
        {
            try
            {
                imgOriginal = webCam.QueryFrame();
                if (imgOriginal == null)
                {
                    pbCamara.Image = EmuladorV2I.Properties.Resources.no_camera;
                    return;
                }

                //Image <Bgr, Byte> imageCorregida = Camara.CorregirPerspectiva(imgOriginal, Globales.ListadoVertices);

                List<Point> centros = Camara.BuscarCirculos(imgOriginal);
                foreach (Point centro in centros) {
                    Bgr[] colores = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, centro, 10);
                    if (colores != null)
                    {
                        List<Point> centrosAux = new List<Point>();
                        centrosAux.Add(centro);
                        imgOriginal = Camara.DibujarCirculos(imgOriginal, centrosAux, 100, colores[2]);
                    }
                }
                //if (centros != null && centros.Count > 0)
                //{
                //    Bgr[] colores = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, centros[0], 10);
                //    if (colores != null)
                //    {
                //        imgOriginal = Camara.DibujarCirculos(imgOriginal, centros, 100, colores[2]);
                //    }
                //}

                pbCamara.Image = imgOriginal.Bitmap;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #region Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                    if (enEjecucion)
                    {
                        // Se le dice que hay que parar el emulador
                        DialogResult resultado = MessageBox.Show("Para añadir un nuevo robot el emulador se detendrá por completo." + Environment.NewLine + "¿Deseas continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado != DialogResult.Yes)
                        {
                            return;
                        }
                    }

                    // Se comprueba que estén todos detenidos
                    
                    if (!DetenerRobots())
                    {
                        MessageBox.Show("Ha ocurrido un error al detener los robots.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Se vuelven a poner todos en funcionamiento
                        return;
                    }

                    DialogResult resultado2 = MessageBox.Show("Coloca el nuevo robot en el emulador y pulsa aceptar para continuar.", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado2 != DialogResult.OK)
                    {
                        // Se vuelven a poner todos en funcionamiento
                        MessageBox.Show("No se ha añadido ningun robot.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                   
                    enEjecucion = false;

                    int idRobot = 0;
                    
                    // Se comprueba que se reciba alguna petición de ON
                    Boolean reintentar = true;
                    while(reintentar)
                    {
                        String respuesta = EnviarRecibirDatos(0, String.Empty, "ON<", 5);
                        if(respuesta != String.Empty)
                        {
                            // Se obtiene el id del robot
                            int id = Convert.ToInt32(respuesta.Substring(3, 1));
                            // Se comprueba que no esté ya en el sistema
                            Boolean encontrado = false;
                            foreach (Robot robot in Globales.ListadoRobots)
                            {
                                if (robot.Id == id)
                                {
                                    encontrado = true;
                                    break;
                                }
                            }

                            if(encontrado)
                            {
                                // Ya existe un robot con ese ID
                                MessageBox.Show("Ya existe un robot en el sistema con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Se vuelven a poner todos en funcionamiento
                                enEjecucion = true;
                                return;
                            } else {
                                idRobot = id;
                                reintentar = false;
                            }
                        } 
                        else 
                        {
                            if (MessageBox.Show("No se ha encontrado ningun robot. ¿Volver a intentar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                reintentar = true;
                            } else {
                                // Se vuelven a poner todos en funcionamiento
                                enEjecucion = true;
                                MessageBox.Show("No se ha añadido ningun robot.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                    // Una vez encontrada su ID se busca en el emulador su color
                    Bgr[] colorMaximoMinimoMedio = null;
                    reintentar = true;
                    while (reintentar)
                    {
                        List<Point> centrosCirculos = Camara.BuscarCirculos(imgOriginal);
                        Boolean encontrado = false;
                        foreach (Point centro in centrosCirculos)
                        {
                            // Se obtiene el color medio de cada circulo
                            colorMaximoMinimoMedio = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, centro, 10);
                            Boolean robotExistente = false;
                            foreach (Robot robot in Globales.ListadoRobots)
                            {
                                // Se comprueba que no exista ningun robot con ese color
                                if (Camara.ColorEntreColoresMaximoYMinimo(colorMaximoMinimoMedio[2], robot.ColorMaximo, robot.ColorMinimo, 50))
                                {
                                    robotExistente = true;
                                    break;
                                }
                            }
                            if (!robotExistente)
                            {
                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                        {
                            // No se ha encontrado ninguno nuevo
                            if (MessageBox.Show("No se ha encontrado ningun color nuevo. ¿Volver a intentar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                reintentar = true;
                            }
                            else
                            {
                                // Se vuelven a poner todos en funcionamiento
                                enEjecucion = true;
                                MessageBox.Show("No se ha añadido ningun robot.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            // Si se ha encontrado se añade y se inicializan todos
                            Robot robot = new Robot(idRobot, colorMaximoMinimoMedio[0], colorMaximoMinimoMedio[1], colorMaximoMinimoMedio[2]);
                            Globales.ListadoRobots.Add(robot);
                            MessageBox.Show("El nuevo robot se ha añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Se vuelven a poner todos en funcionamiento
                            enEjecucion = true;
                        }
                    }
                }

            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnBorrarTexto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        
        #endregion

        #region Eventos
 
        #endregion

        public void ObtenerDatos(string datos)
        {
            try
            {
                
            } 
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private Boolean DetenerRobots()
        {
            try
            {
                // Se detienen todos los robots del emulador
                Boolean detenidos = true;
                foreach (Robot robot in Globales.ListadoRobots)
                {
                    detenidos = EnviarRecibirDatos(robot.Id, Comandos.STOP, "OK", 5) != String.Empty;
                }
                return detenidos;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return false;
            }
        }

        private String EnviarRecibirDatos(int id, String comando, String respuestaEsperada, int timeout)
        {
            try
            {
                if(comando != String.Empty)
                {
                    Bluetooth.Instancia.Enviar(id, Comandos.STOP);
                }
                String respuestaObtenida = String.Empty;
                if(respuestaEsperada != String.Empty)
                {
                    int i = 0;
                    while (respuestaObtenida == String.Empty && i <= timeout)
                    {
                        String ultimoComando = Bluetooth.Instancia.UltimoComando;
                        if (respuestaEsperada == ultimoComando || ultimoComando.StartsWith(respuestaEsperada))
                        {
                            respuestaObtenida = ultimoComando;
                        } else {
                            i++;
                            Thread.Sleep(1000);
                        }
                    }
                }
                return respuestaObtenida;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return String.Empty;
            }
        }


        #region Menu
        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                // Se para el hilo de GET de los robots
                panRobots.Visible = false;
                panCamara.Visible = true;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        #endregion

        private void btnRobots_Click(object sender, EventArgs e)
        {
            try
            {
                // Se inicia el hilo de GET de los robots
                panCamara.Visible = false;
                panRobots.Visible = true;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Esta funcionalidad aun no está disponible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            try
            {
                // Se para el hilo de GET de los robots
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
    }
}