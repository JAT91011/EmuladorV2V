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
using System.Collections;

namespace EmuladorV2I
{
    public partial class frmPanelPrincipal : Form, BluetoothObservador
    {
        private Capture webCam = null;
        private Image<Bgr, Byte> imgOriginal;
        private List<Robot> robots = new List<Robot>();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int robotSeleccionado;

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
                Application.Idle += ProcesarImagen;
                Bluetooth.Instancia.NuevoObservador(this);
                timer.Interval = 1000;
                timer.Tick += new EventHandler(ProcesadorDeTimer);
                robotSeleccionado = -1;
                timer.Enabled = true;
                panRobots.Visible = false;
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
                if(robots.Count > 0)
                {
                    timer.Stop();
                    Thread.Sleep(2000);
                    foreach (Robot robot in Globales.ListadoRobots)
                    {
                        Bluetooth.Instancia.Enviar(robot.Id, Comandos.OFF);
                    }
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

        #region Eventos
        public void ObtenerDatos(string [] datos)
        {
            try
            {
                if(datos[1] == "ON")                    // Robot intentando conectarse
                {
                    NuevoRobot(datos);
                } 
                else if(datos[1].Contains(":"))         // Obteniendo datos de los robots
                {
                    ActualizarDatos(datos);
                }
                else if (datos[1] == "BYE")             // Robot se desconecta
                {
                    QuitarRobot(datos);
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void ProcesadorDeTimer(object Sender, EventArgs e)
        {
            try
            {
                if(robotSeleccionado > -1 && robots.Count > 0 )
                {
                    if(robots[robotSeleccionado].Modo == Robot.MODO_LIBRE || robots[robotSeleccionado].Modo == Robot.MODE_AVERIADO)
                    {
                        new Thread(CrearHiloComando).Start("GET_DATA");
                    }
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void CrearHiloComando(Object comando)
        {
            Bluetooth.Instancia.Enviar(robots[robotSeleccionado].Id, comando.ToString());
        }
        
        #endregion

        #region ProcesarComandos
        private void NuevoRobot(string[] datos)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Hay un robot intentando conectarse al sistema." + Environment.NewLine + "¿Deseas incorporarlo?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes)
                {
                    // Si no, se le avisa para que pare
                    Bluetooth.Instancia.Enviar(Convert.ToInt32(datos[0]), "ERR");
                    return;
                }

                // Se avisa para colocarlo en el emulador
                DialogResult resultado2 = MessageBox.Show("Coloca el nuevo robot en el emulador y pulsa aceptar.", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado2 == DialogResult.Cancel)
                {
                    // Si no, se le avisa para que desconecte
                    Bluetooth.Instancia.Enviar(Convert.ToInt32(datos[0]), "ERR");
                    return;
                }

                // Se busca en el emulador
                Bgr[] colorMaximoMinimoMedio = null;
                Boolean reintentar = true;
                while (reintentar)
                {
                    List<CircleF> circulos = Camara.BuscarCirculos(imgOriginal);
                    Boolean encontrado = true;
                    //foreach (CircleF circulo in circulos)
                    //{
                    //    // Se obtiene el color medio de cada circulo
                    //    colorMaximoMinimoMedio = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, new Point((int)circulo.Center.X, (int)circulo.Center.Y), 10);
                    //    Boolean robotExistente = false;
                    //    foreach (Robot robot in Globales.ListadoRobots)
                    //    {
                    //        // Se comprueba que no exista ningun robot con ese color
                    //        if (Camara.ColorEntreColoresMaximoYMinimo(colorMaximoMinimoMedio[2], robot.ColorMaximo, robot.ColorMinimo, 50))
                    //        {
                    //            robotExistente = true;
                    //            break;
                    //        }
                    //    }
                    //    if (!robotExistente)
                    //    {
                    //        encontrado = true;
                    //        break;
                    //    }
                    //}

                    if (!encontrado)
                    {
                        // No se ha encontrado ninguno nuevo
                        if (MessageBox.Show("No se ha encontrado ningun color nuevo. ¿Volver a intentar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            reintentar = true;
                        }
                        else
                        {
                            Bluetooth.Instancia.Enviar(Convert.ToInt32(datos[0]), "ERR");
                            MessageBox.Show("No se ha añadido ningun robot.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        // Si se ha encontrado se añade y se inicializan todos
                        //robots.Add(new Robot(id,colorMaximoMinimoMedio[0], colorMaximoMinimoMedio[1], colorMaximoMinimoMedio[2]));
                        reintentar = false;
                        Bluetooth.Instancia.Enviar(Convert.ToInt32(datos[0]), "OK");
                        Thread.Sleep(2000);
                        Bluetooth.Instancia.Enviar(Convert.ToInt32(datos[0]), "MODE_FREE");
                        MessageBox.Show("El nuevo robot se ha añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        robots.Add(new Robot(Convert.ToInt32(datos[0]), new Bgr(255, 0, 0), new Bgr(255, 0, 0), new Bgr(255, 0, 0)));
                        lblMensaje.Visible = false;
                        robotSeleccionado = robots.Count - 1;
                        CargarInformacion();
                    }
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void ActualizarDatos(string [] datos)
        {
            try
            {
                if (robotSeleccionado > -1)
                {
                    if (robots[robotSeleccionado].Id == Convert.ToInt32(datos[0]))
                    {
                        if (Convert.ToInt32(robots[robotSeleccionado].Bateria.Substring(0, robots[robotSeleccionado].Bateria.Length - 1)) > Convert.ToInt32(datos[1].Split(':')[0]))
                        {
                            robots[robotSeleccionado].Bateria = datos[1].Split(':')[0] + " %";
                        }
                        decimal temperatura = Math.Round(Convert.ToDecimal(datos[1].Split(':')[1].Replace('.', ',')), 2);
                        robots[robotSeleccionado].Temperatura = temperatura + " ºC";
                    }
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void QuitarRobot(string[] datos)
        {
            try
            {
                int i;
                for (i = 0; i < robots.Count; i++)
                {
                    if (robots[i].Id == Convert.ToInt32(datos[0]))
                    {
                        break;
                    }
                }

                robots.RemoveAt(i);
                MessageBox.Show("El robot con ID: " + Convert.ToInt32(datos[0]) + " se ha desconectado del sistema.");
                if (robotSeleccionado == i)
                {
                    if(robots.Count == 0)
                    {
                        panRobots.Visible = false;
                        lblMensaje.Visible = true;
                    }
                    else
                    {
                        // NO HAY MAS
                    }
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #endregion

        private void CargarInformacion()
        {
            try
            {
                if (robotSeleccionado > -1)
                {
                    panRobots.Visible = true;
                    lblIdValor.Text = robots[robotSeleccionado].Id.ToString();
                    cboModo.SelectedIndex = robots[robotSeleccionado].Modo;
                    spinVelocidad.Value = robots[robotSeleccionado].Velocidad;
                    lblBateriaValor.DataBindings.Clear();
                    lblTemperaturaValor.DataBindings.Clear();
                    lblBateriaValor.DataBindings.Add("Text", robots[robotSeleccionado], "Bateria");
                    lblTemperaturaValor.DataBindings.Add("Text", robots[robotSeleccionado], "temperatura");
                    panRobots.Refresh();
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #region EventosControles
        private void cboModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboModo.SelectedIndex == 0 && robots[robotSeleccionado].Modo != Robot.MODO_LIBRE)
                {
                    timer.Stop();
                    Thread.Sleep(1200);
                    robots[robotSeleccionado].Modo = Robot.MODO_LIBRE;
                    new Thread(CrearHiloComando).Start(Comandos.MODE_FREE);
                    timer.Start();
                }
                else if (cboModo.SelectedIndex == 1 && robots[robotSeleccionado].Modo != Robot.MODE_AVERIADO)
                {
                    timer.Stop();
                    Thread.Sleep(1200);
                    robots[robotSeleccionado].Modo = Robot.MODE_AVERIADO;
                    new Thread(CrearHiloComando).Start(Comandos.MODE_BROKEN);
                    timer.Start();
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Se va a proceder a desconectar el robot con ID: " + robots[robotSeleccionado].Id + Environment.NewLine + "¿Deseas continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    timer.Stop();
                    Thread.Sleep(1100);
                    new Thread(CrearHiloComando).Start(Comandos.OFF);
                    timer.Start();
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void cboSeguridadApagado_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}