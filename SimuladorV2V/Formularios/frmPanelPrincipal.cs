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

namespace EmuladorV2I
{
    public partial class frmPanelPrincipal : Form, BluetoothObservador
    {
        private Capture webCam = null;
        private Image<Bgr, Byte> imgOriginal;
        private String log;
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
                ActualizarComboConsola();
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

                //imgOriginal = Camara.CorregirPerspectiva(imgOriginal, Globales.ListadoVertices);

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
                    DialogResult resultado = MessageBox.Show("Para añadir un nuevo robot el emulador se detendrá por completo." + Environment.NewLine + "¿Deseas continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Se manda mensaje a todos los robots conectados para que se detengan
                        foreach(Robot robot in Globales.ListadoRobots)
                        {
                            Bluetooth.Instancia.Enviar(robot.Id, Comandos.STOP);
                        }
                        
                        // Se comprueba si ha recibido alguna petición con un tiempo de espera de 10 segundos
                        bool recibido = false;
                        int i = 0;
                        while(!recibido && i <= 10)
                        {
                            String comando = Bluetooth.Instancia.UltimoComando;
                            if(comando.StartsWith("ON<"))
                            {
                                // Se obtiene el id del robot
                                int id = Convert.ToInt32(comando.Substring(3, 1));
                                // Se comprueba que no esté ya en el sistema
                                foreach (Robot robot in Globales.ListadoRobots)
                                {
                                    if(robot.Id == id)
                                    {
                                        break;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                // Se detiene la camara
                if (webCam != null)
                {
                    webCam.Dispose();
                }

                MessageBox.Show("Añadido");
                webCam = new Capture();
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

        // PROVISIONAL
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //Bluetooth.Instancia.Enviar(txtEnviar.Text.Trim());
                txtEnviar.Text = String.Empty;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        
        #endregion

        #region Eventos
        private void cboMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ActualizarConsola();
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #endregion

        #region Actualizar Campos
        private void ActualizarComboConsola()
        {
            try 
            {
                cboMensajes.Items.Clear();
                cboMensajes.Items.Add("Sistema");
                foreach (Robot robot in Globales.ListadoRobots)
                {
                    cboMensajes.Items.Add(robot.Descripcion);
                }
                cboMensajes.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        
        private void ActualizarConsola()
        {
            try
            {
                int seleccionado = cboMensajes.SelectedIndex;
                if (seleccionado == 0)
                {
                    textBoxConsola.Text = log;
                }
                else
                {
                    textBoxConsola.Text = Globales.ListadoRobots[seleccionado - 1].Log;
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        #endregion

        public void ObtenerDatos(string datos)
        {
            try
            {
                log += datos;
                ActualizarConsola();
            } 
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

    }
}