using System;
using System.IO;
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

namespace SimuladorV2V
{
    public partial class frmAsistenteConfiguracion : Form
    {
        Capture webCam = null;
        Image<Bgr, Byte> imgOriginal;
        bool blnCapturandoImagenes = false;
        int intPagina;

        public frmAsistenteConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmAsistenteConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                intPagina = 0;
                ActualizarPagina();
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void FrmAsistenteConfiguracion_FormClosed(object sender, FormClosedEventArgs e)
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
                MessageBox.Show(exception.Message);
            }
        }

        private void ActualizarPagina()
        {
            try
            {
                switch(intPagina)
                {
                    case 0: // Bienvenido
                        lblBienvenido.ForeColor = Color.White;
                        lblCircuito.ForeColor = Color.LightGray;
                        lblReferencias.ForeColor = Color.LightGray;
                        lblComunicacion.ForeColor = Color.LightGray;
                        lblCompletado.ForeColor = Color.LightGray;

                        lblTitulo.Text = "Asistente de configuración del sistema";
                        panBienvenido.Visible = true;
                        panCircuito.Visible = false;
                        panReferencias.Visible = false;
                        panComunicacion.Visible = false;
                        panCompletado.Visible = false;
                        btnVolverYCerrar.Text = "Cerrar";
                        if (webCam != null)
                        {
                            webCam.Dispose();
                            Application.Idle -= ProcesarImagen;
                        }
                        break;
                    case 1: // Circuito
                        lblBienvenido.ForeColor = Color.LightGray;
                        lblCircuito.ForeColor = Color.White;
                        lblReferencias.ForeColor = Color.LightGray;
                        lblComunicacion.ForeColor = Color.LightGray;
                        lblCompletado.ForeColor = Color.LightGray;
                        Application.Idle += ProcesarImagen;
                        Globales.listadoVertices = null;
                        webCam = new Capture();
                        blnCapturandoImagenes = true;
                        lblTitulo.Text = "Circuito";
                        panBienvenido.Visible = false;
                        panCircuito.Visible = true;
                        panReferencias.Visible = false;
                        panComunicacion.Visible = false;
                        panCompletado.Visible = false;
                        btnVolverYCerrar.Text = "Volver";
                        break;
                }
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void ProcesarImagen(object sender, EventArgs e)
        {
           try
           {
               imgOriginal = webCam.QueryFrame();
               if(imgOriginal == null)
               {
                   return;
               }

               Globales.listadoVertices = null;
               Globales.listadoVertices = Camara.BuscarRectangulo(imgOriginal);
               if(Globales.listadoVertices != null && Globales.listadoVertices.Count == 4)
               {
                   Globales.listadoVertices = Camara.ReordenarPuntos(Globales.listadoVertices);
                   Globales.imgCircuito = Camara.CorregirPerspectiva(imgOriginal, Globales.listadoVertices);
                   imgOriginal = Camara.DibujarRectangulo(imgOriginal, Globales.listadoVertices);
               }

               ibCamara.Image = imgOriginal;

           } catch (Exception exception) {
               MessageBox.Show(exception.Message);
           }
        }



        #region Botones
        private void linkManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string rutaManual = Path.Combine(Application.StartupPath, "Documentos\\Manual.pdf");
                Process.Start(rutaManual);
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnSiguienteYTerminar_Click(object sender, EventArgs e)
        {
            try 
            {
                switch(intPagina)
                {
                    case 0:
                        intPagina = 1;
                        ActualizarPagina();
                        break;
                    case 1:
                        if(Globales.listadoVertices != null) 
                        {
                            DialogResult result = MessageBox.Show("A partir de este momento el circuito ni la cámara no se podrán mover." + Environment.NewLine + "¿Deseas continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                intPagina = 2;
                                ActualizarPagina();
                            }
                        } else {
                            MessageBox.Show("No se ha encontrado el circuito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }

            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion

        private void btnVolverYCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (intPagina == 0)
                {
                    Application.Exit();
                } else {
                    DialogResult result = MessageBox.Show("Se perderán los datos modificados." + Environment.NewLine + "¿Deseas continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        intPagina = intPagina - 1;
                        ActualizarPagina();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
    }
}
