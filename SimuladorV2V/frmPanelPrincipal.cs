using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace SimuladorV2V
{
    public partial class frmPanelPrincipal : Form
    {

        public frmPanelPrincipal()
        {
            InitializeComponent();
        }

        private void frmPanelPrincipal_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void frmPanelPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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
                MessageBox.Show(exception.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnBorrarTexto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion

    }
}