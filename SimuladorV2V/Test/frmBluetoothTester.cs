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
using EmuladorV2I.Utilidades;
using EmuladorV2I.Interfaces;

namespace EmuladorV2I.Test
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
                cboVelocidad.SelectedIndex = 9;
                Bluetooth.Instancia.NuevoObservador(this);
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
                if (!Bluetooth.Instancia.EstaConectado())
                {
                    MessageBox.Show("Antes debes conectarte a un puerto serie.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtSalida.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Introduce un mensaje de salida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtIdRobot.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Introduce una id.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtEntrada.Text += "--> " + Bluetooth.CrearTrama(int.Parse(txtIdRobot.Text.Trim()), txtSalida.Text) + Environment.NewLine;

                Bluetooth.Instancia.Enviar(int.Parse(txtIdRobot.Text.Trim()), txtSalida.Text.Trim());
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
                txtEntrada.Text += "<-- " + datos + Environment.NewLine;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void txtIdRobot_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void frmBluetoothTester_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

    }
}