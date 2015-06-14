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

namespace SimuladorV2V
{
    public partial class frmPanelPrincipal : Form
    {
        Capture webCam = null;
        Image<Bgr, Byte> imgOriginal;

        public frmPanelPrincipal()
        {
            InitializeComponent();
        }

        private void frmPanelPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                webCam = new Capture();
                Application.Idle += ProcesarImagen;
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

                ibCamara.Image = imgOriginal;
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
        #endregion

    }
}