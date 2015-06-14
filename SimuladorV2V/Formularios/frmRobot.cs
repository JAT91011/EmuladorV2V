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
using SimuladorV2V.Clases;
using SimuladorV2V.Utilidades;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Threading;

namespace SimuladorV2V.Formularios
{
    public partial class frmRobot : Form
    {
        private Robot robot;
        private Capture webCam = null;
        private Image<Bgr, Byte> imgOriginal;

        public frmRobot()
        {
            InitializeComponent();
        }

        public frmRobot(Robot robot): this()
        {
            this.robot = robot;
        }

        private void frmRobot_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.robot == null) // Si el robot es nuevo
                {
                    this.Text = "Nuevo Robot";
                    lblVelocidad.Visible = false;
                    trackBarVelocidad.Visible = false;
                    lblModo.Visible = false;
                    rbLibre.Visible = false;
                    rbRuta.Visible = false;
                    rbAveriado.Visible = false;
                    this.robot = new Robot();
                }
                else                    // Si ya existe el robot
                {
                    this.Text = "Robot: " + robot.Descripcion;
                    this.btnBuscar.Visible = false;
                    this.pbCamara.Visible = false;
                }
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

        #region Nuevo
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    this.webCam = new Capture();
                    Thread.Sleep(1000);
                }
                catch 
                {
                    MessageBox.Show("No hay ninguna cámara conectada. Revisa las conexiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }  
                

                imgOriginal = webCam.QueryFrame();
                if (imgOriginal == null)
                {
                    pbCamara.Image = SimuladorV2V.Properties.Resources.no_camera;
                    return;
                }

                // Se buscan todos los circulos en la imagen
                List<Point> centros = Camara.BuscarCirculos(imgOriginal);
                if (centros != null && centros.Count > 0)
                {
                    // Se comprueba que haya un nuevo color que no este asignado a ningun robot
                    for (int i = 0; i < centros.Count; i++)
                    {
                        // Se obtiene los color máximo, mínimo y medio del centro con un margen de 10 pixeles
                        Bgr[] colores = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, centros[i], 10);

                        // Se compara el color con el color de los robots existentes
                        bool encontrado = true;
                        foreach (Robot robot in Globales.ListadoRobots)
                        {
                            // Se comprueba que el color no esté entre los máximos y mínimos de cada robot con una seguridad de 10
                            //if (Camara.ColorEntreColores(colores[2], robot.ColorMinimo, robot.ColorMaximo, 10))
                            //{
                            //    encontrado = false;
                            //    break;
                            //}
                        }

                        // Si se ha encontrado un nuevo robot se detiene la busqueda
                        if (encontrado)
                        {
                            // Se guardan los colores del robot
                            this.robot.ColorMaximo = colores[0];
                            this.robot.ColorMinimo = colores[1];
                            this.robot.Color = colores[2];

                            // Se selecciona el nuevo robot
                            imgOriginal = Camara.DibujarCirculo(imgOriginal, centros[i], 20, new Bgr(0, 255, 0));
                        }
                    }
                    
                }

                // Se redibuja la imagen
                pbCamara.Image = imgOriginal.Bitmap;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        
        #endregion
        
    }
}