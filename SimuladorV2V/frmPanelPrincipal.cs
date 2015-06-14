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
using SimuladorV2V.Utilidades;
using SimuladorV2V.Interfaces;
using SimuladorV2V.Clases;

namespace SimuladorV2V
{
    public partial class frmPanelPrincipal : Form, BluetoothObservador
    {
        private Capture webCam = null;
        private Image<Bgr, Byte> imgOriginal;
        private String log;

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
                    pbCamara.Image = SimuladorV2V.Properties.Resources.no_camera;
                    return;
                }

                List<Point> centros = Camara.BuscarCirculos(imgOriginal);
                if (centros != null && centros.Count > 0)
                {
                    Bgr[] colores = Camara.ObtenerColoresMaximoMinimoMedio(imgOriginal, centros[0], 10);
                    if (colores != null)
                    {
                        imgOriginal = Camara.DibujarCirculos(imgOriginal, centros, 100, colores[2]);
                    }
                }

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
                Bluetooth.Instancia.Enviar(txtEnviar.Text.Trim());
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