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

namespace EmuladorV2I
{
    public partial class frmAsistenteConfiguracion : Form
    {
        Capture webCam = null;
        Image<Bgr, Byte> imgOriginal;
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
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
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
                //Application.Exit();
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void ActualizarPagina()
        {
            try
            {
                switch (intPagina)
                {
                    case 0: // Bienvenido
                        lblBienvenido.ForeColor = Color.White;
                        lblCircuito.ForeColor = Color.LightGray;
                        lblIntersecciones.ForeColor = Color.LightGray;
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
                        lblIntersecciones.ForeColor = Color.LightGray;
                        lblComunicacion.ForeColor = Color.LightGray;
                        lblCompletado.ForeColor = Color.LightGray;
                        webCam = new Capture();
                        Application.Idle += ProcesarImagen;
                        webCam.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 640);
                        webCam.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 480);
                        lblTitulo.Text = "Circuito";
                        panBienvenido.Visible = false;
                        panCircuito.Visible = true;
                        panReferencias.Visible = false;
                        panComunicacion.Visible = false;
                        panCompletado.Visible = false;
                        btnVolverYCerrar.Text = "Volver";
                        break;
                    case 2: // Intersecciones
                        lblBienvenido.ForeColor = Color.LightGray;
                        lblCircuito.ForeColor = Color.LightGray;
                        lblIntersecciones.ForeColor = Color.White;
                        lblComunicacion.ForeColor = Color.LightGray;
                        lblCompletado.ForeColor = Color.LightGray;
                        Globales.ListadoIntersecciones = new List<CircleF>();
                        ibCircuito.Image = Globales.ImagenCircuito;
                        lblTitulo.Text = "Intersecciones";
                        panBienvenido.Visible = false;
                        panCircuito.Visible = false;
                        panReferencias.Visible = true;
                        panComunicacion.Visible = false;
                        panCompletado.Visible = false;
                        if (webCam != null)
                        {
                            webCam.Dispose();
                            Application.Idle -= ProcesarImagen;
                        }
                        break;
                    case 3: // Comunicacion
                        Globales.PuertoSerie = String.Empty;
                        Globales.VelocidadTransmision = 0;
                        CargarPuertosSerie();
                        cboVelocidadTransmision.SelectedIndex = 0;
                        lblBienvenido.ForeColor = Color.LightGray;
                        lblCircuito.ForeColor = Color.LightGray;
                        lblIntersecciones.ForeColor = Color.LightGray;
                        lblComunicacion.ForeColor = Color.White;
                        lblCompletado.ForeColor = Color.LightGray;
                        lblTitulo.Text = "Comunicación";
                        panBienvenido.Visible = false;
                        panCircuito.Visible = false;
                        panReferencias.Visible = false;
                        panComunicacion.Visible = true;
                        panCompletado.Visible = false;
                        btnSiguienteYTerminar.Text = "Siguiente";
                        break;
                    case 4: // Completado
                        lblBienvenido.ForeColor = Color.LightGray;
                        lblCircuito.ForeColor = Color.LightGray;
                        lblIntersecciones.ForeColor = Color.LightGray;
                        lblComunicacion.ForeColor = Color.LightGray;
                        lblCompletado.ForeColor = Color.White;
                        lblTitulo.Text = "Completado";
                        panBienvenido.Visible = false;
                        panCircuito.Visible = false;
                        panReferencias.Visible = false;
                        panComunicacion.Visible = false;
                        panCompletado.Visible = true;
                        btnSiguienteYTerminar.Text = "Terminar";
                        break;
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

                Globales.ListadoVertices = null;
                Globales.ListadoVertices = Camara.BuscarRectangulo(imgOriginal);
                if (Globales.ListadoVertices != null && Globales.ListadoVertices.Count == 4)
                {
                    Globales.ListadoVertices = Camara.ReordenarPuntos(Globales.ListadoVertices);
                    Globales.ImagenCircuito = Camara.CorregirPerspectiva(imgOriginal, Globales.ListadoVertices);
                    imgOriginal = Camara.DibujarRectangulo(imgOriginal, Globales.ListadoVertices);
                }

                ibCamara.Image = imgOriginal;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void CargarPuertosSerie()
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
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #region Botones
        private void linkManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string rutaManual = Path.Combine(Application.StartupPath, "Documentos\\Manual.pdf");
                Process.Start(rutaManual);
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnRefrescarPuertosSerie_Click(object sender, EventArgs e)
        {
            try
            {
                CargarPuertosSerie();
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void btnSiguienteYTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (intPagina)
                {
                    case 0:
                        intPagina = 1;
                        ActualizarPagina();
                        break;
                    case 1:
                        if (Globales.ListadoVertices != null)
                        {
                            DialogResult result = MessageBox.Show("A partir de este momento el circuito ni la cámara no se podrán mover." + Environment.NewLine + "¿Deseas continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                intPagina = 2;
                                ActualizarPagina();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha encontrado el circuito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2:
                        intPagina = 3;
                        ActualizarPagina();
                        break;
                    case 3:
                        if (cboPuertoSerie.SelectedItem == null || cboPuertoSerie.SelectedItem.ToString() == String.Empty)
                        {
                            MessageBox.Show("Debes seleccionar un puerto serie.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (cboVelocidadTransmision.SelectedItem == null || cboVelocidadTransmision.SelectedItem.ToString() == String.Empty)
                        {
                            MessageBox.Show("Debes seleccionar una velocidad de transmisión.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if( ! Bluetooth.Instancia.Conectar(cboPuertoSerie.SelectedItem.ToString(), Convert.ToInt32(cboVelocidadTransmision.SelectedItem.ToString())))
                        {
                            MessageBox.Show("No se ha podido establecer la comunicación con el módulo bluetooth.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Globales.PuertoSerie = cboPuertoSerie.SelectedItem.ToString();
                        Globales.VelocidadTransmision = Convert.ToInt32(cboVelocidadTransmision.SelectedItem.ToString());
                        intPagina = 4;
                        ActualizarPagina();
                        break;
                    case 4:
                        this.Close();
                        //frmPanelPrincipal frmPrincipal = new frmPanelPrincipal();
                        //frmPrincipal.Show();
                        break;
                }

            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        
        private void btnVolverYCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (intPagina == 0)
                {
                    Application.Exit();
                }
                else
                {
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
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
 
        #endregion

        #region Eventos

        private void ibCircuito_Click(object sender, EventArgs e)
        {
            try
            {
                MouseEventArgs evento = (MouseEventArgs)e;
                Point punto = new Point(evento.X, evento.Y);
                // Se comprueba que no se haya seleccionado ninguna intersección
                for (int i = 0; i < Globales.ListadoIntersecciones.Count; i++)
                {
                    if (Utilidades.Utilidades.CirculoContienePunto(Globales.ListadoIntersecciones[i], punto))
                    {
                        Globales.ListadoIntersecciones.RemoveAt(i);
                        ibCircuito.Image = Camara.DibujarCirculos(Globales.ImagenCircuito.Clone(), Globales.ListadoIntersecciones);
                        return;
                    }
                }

                // Se comprueba que no se salga de la imagen
                if (punto.X - Globales.RadioIntersecciones / 2 > 0 && punto.X + Globales.RadioIntersecciones / 2 < 640 && punto.Y - Globales.RadioIntersecciones / 2 > 0 && punto.Y - Globales.RadioIntersecciones / 2 < 480)
                {
                    // Se crea el círculo
                    CircleF circulo = new CircleF(new PointF(punto.X, punto.Y), Globales.RadioIntersecciones);

                    // Se comprueba que no interseccione con los círculo existentes
                    //for (int i = 0; i < Globales.ListadoIntersecciones.Count; i++)
                    //{
                    //    if (rectangulo.IntersectsWith(Globales.ListadoIntersecciones[i]))
                    //    {
                    //        return;
                    //    }
                    //}

                    // Si no intersecciona con ninguno se añade y se refresca la imagen
                    Globales.ListadoIntersecciones.Add(circulo);
                    ibCircuito.Image = Camara.DibujarCirculos(Globales.ImagenCircuito.Clone(), Globales.ListadoIntersecciones);
                }

            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #endregion

    }
}