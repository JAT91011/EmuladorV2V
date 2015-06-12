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
                actualizarPagina();
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

        private void actualizarPagina()
        {
            try
            {

            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

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
    }
}
