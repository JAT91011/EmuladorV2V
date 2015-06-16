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
using SimuladorV2V.Utilidades;
using SimuladorV2V.Interfaces;

namespace SimuladorV2V.Temporal
{
    public partial class frmBluetoothTester : Form, BluetoothObservador
    {
        public frmBluetoothTester()
        {
            InitializeComponent();
        }

        private void frmBluetoothTester_Load(object sender, EventArgs e)
        {
            try
            {
                cboPuertoSerie.Items.Clear();
                foreach (String puerto in SerialPort.GetPortNames())
                {
                    cboPuertoSerie.Items.Add(puerto);
                }
                if (cboPuertoSerie.Items.Count > 0)
                {
                    cboPuertoSerie.SelectedIndex = 0;
                }
                cboVelocidad.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #region Botones
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPuertoSerie.SelectedItem == null || cboPuertoSerie.SelectedItem.ToString() == String.Empty)
                {
                    MessageBox.Show("Selecciona un puerto serie.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (cboVelocidad.SelectedItem == null || cboVelocidad.SelectedItem.ToString() == String.Empty)
                {
                    MessageBox.Show("Debes seleccionar una velocidad de transmisión.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if( ! Bluetooth.Instancia.Conectar(cboPuertoSerie.SelectedItem.ToString(), Convert.ToInt32(cboVelocidad.SelectedItem.ToString())))
                {
                    MessageBox.Show("No se ha podido establecer la comunicación con el módulo bluetooth.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Bluetooth.Instancia.NuevoObservador(this);

                MessageBox.Show("Conectado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnConectar.Text = "Reconectar";
                txtEntrada.Text = String.Empty;
                txtSalida.Text = String.Empty;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( ! Bluetooth.Instancia.EstaConectado())
                {
                    MessageBox.Show("Antes debes conectarte a un puerto serie.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtSalida.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Introduce un mensaje de salida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Bluetooth.Instancia.Enviar(txtSalida.Text.Trim());
                txtSalida.Text = String.Empty;
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
                txtEntrada.Text += datos;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
    }
}