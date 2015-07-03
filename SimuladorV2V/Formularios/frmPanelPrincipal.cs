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
        private DataTable dtRobots;
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
                    webCam.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 640);
                    webCam.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 480);
                }  
                catch (Exception exception)
                {
                    MessageBox.Show("No hay ninguna cámara conectada. Revisa las conexiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    String error = exception.Message;
                }
                dtRobots = new DataTable();
                Application.Idle += ProcesarImagen;
                Bluetooth.Instancia.NuevoObservador(this);
                enEjecucion = false;
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
                
                List<CircleF> circulos = Camara.BuscarCirculos(imgOriginal);
                foreach (CircleF circulo in circulos)
                {
                    Bgr[] colores = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, new Point((int)circulo.Center.X, (int)circulo.Center.Y), 10);
                    if (colores != null)
                    {
                        imgOriginal = Camara.DibujarCirculo(imgOriginal, new CircleF(new PointF(circulo.Center.X, circulo.Center.Y), circulo.Radius + 5), colores[2]);
                    }
                }

                // Se visualizan las intersecciones
                if (chkIntersecciones.Checked)
                {
                    foreach (CircleF interseccion in Globales.ListadoIntersecciones)
                    {
                        imgOriginal = Camara.DibujarCirculos(imgOriginal, Globales.ListadoIntersecciones);
                    }
                }

                // Se corrige la perspectiva
                if (chkCorregirPerspectiva.Checked)
                {
                    Image<Bgr, Byte> imagenCorregida = Camara.CorregirPerspectiva(imgOriginal, Globales.ListadoVertices);
                    pbCamara.Image = imagenCorregida.Bitmap;
                }
                else
                {
                    pbCamara.Image = imgOriginal.Bitmap;
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #region Botones

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            try
            {
                if(enEjecucion)
                {
                    if(DetenerRobots())
                    {
                        enEjecucion = false;
                        btnIniciarParar.Image = Properties.Resources.pause_icon;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al detener la plataforma.");
                    }
                }
                else
                {
                    if (ArrancarRobots())
                    {
                        enEjecucion = true;
                        btnIniciarParar.Image = Properties.Resources.play_icon;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al arrancar la plataforma.");
                    }
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

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
                        List<CircleF> circulos = Camara.BuscarCirculos(imgOriginal);
                        Boolean encontrado = false;
                        foreach (CircleF circulo in circulos)
                        {
                            // Se obtiene el color medio de cada circulo
                            colorMaximoMinimoMedio = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, new Point((int)circulo.Center.X, (int)circulo.Center.Y), 10);
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
                if(datos.StartsWith("ON<"))
                {
                    // Hay algún robot intentando conectarse

                    // Se obtiene el id del robot
                    int id = Convert.ToInt32(datos.Substring(3, 1));

                    DialogResult resultado = MessageBox.Show("Hay un robot intentando conectarse al sistema." + Environment.NewLine + "¿Deseas incorporarlo?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado != DialogResult.Yes)
                    {
                        // Si no, se le avisa para que pare
                        Bluetooth.Instancia.Enviar(id, "ERR");
                        return;
                    }


                    // Se avisa para colocarlo en el emulador
                    DialogResult resultado2 = MessageBox.Show("Coloca el nuevo robot en el emulador y pulsa Ok.", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado2 == DialogResult.Cancel)
                    {
                        // Si no, se le avisa para que desconecte
                        Bluetooth.Instancia.Enviar(id, "ERR");
                        return;
                    }

                    // Se busca en el emulador
                    Bgr[] colorMaximoMinimoMedio = null;
                    Boolean reintentar = true;
                    while (reintentar)
                    {
                        List<CircleF> circulos = Camara.BuscarCirculos(imgOriginal);
                        Boolean encontrado = false;
                        foreach (CircleF circulo in circulos)
                        {
                            // Se obtiene el color medio de cada circulo
                            colorMaximoMinimoMedio = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, new Point((int)circulo.Center.X, (int)circulo.Center.Y), 10);
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
                                Bluetooth.Instancia.Enviar(id, "ERR");
                                MessageBox.Show("No se ha añadido ningun robot.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            // Si se ha encontrado se añade y se inicializan todos
                            DataRow dr = new DataRow();
                            dr["colId"] = id;
                            dr["colDescripcion"] = "";
                            dr["colModo"] = 0;
                            dr["colTemperatura"] = 0;
                            dr["colBateria"] = 0;
                            string[] row1 = new string[]{"Meatloaf", "Main Dish", boringMeatloaf, boringMeatloafRanking};
                            gvRobots.Rows.Add(id, ) 
                            Robot robot = new Robot(id, colorMaximoMinimoMedio[0], colorMaximoMinimoMedio[1], colorMaximoMinimoMedio[2]);
                            reintentar = false;
                            Globales.ListadoRobots.Add(robot);
                            Bluetooth.Instancia.Enviar(id, "OK");
                           // Bluetooth.Instancia.Enviar(id, Comandos.MODE_FREE);
                            MessageBox.Show("El nuevo robot se ha añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
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

        private Boolean ArrancarRobots()
        {
            try
            {
                // Se arrancan todos los robots del emulador
                Boolean detenidos = true;
                foreach (Robot robot in Globales.ListadoRobots)
                {
                    if(robot.Modo == Robot.MODO_LIBRE)
                    {
                        detenidos = EnviarRecibirDatos(robot.Id, Comandos.MODE_FREE, "OK", 5) != String.Empty;
                    }
                    else if (robot.Modo == Robot.MODE_AVERIADO)
                    {
                        detenidos = EnviarRecibirDatos(robot.Id, Comandos.MODE_BROKEN, "OK", 5) != String.Empty;
                    }
        
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
        #endregion

        
    }
}