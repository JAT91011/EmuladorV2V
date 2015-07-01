namespace EmuladorV2I
{
    partial class frmAsistenteConfiguracion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistenteConfiguracion));
            ManiXButton.Office2010Yellow office2010Yellow1 = new ManiXButton.Office2010Yellow();
            this.panIzquierdo = new System.Windows.Forms.Panel();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.lblCompletado = new System.Windows.Forms.Label();
            this.lblComunicacion = new System.Windows.Forms.Label();
            this.lblReferencias = new System.Windows.Forms.Label();
            this.lblCircuito = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panDerecho = new System.Windows.Forms.Panel();
            this.panComunicacion = new System.Windows.Forms.Panel();
            this.btnRefrescarPuertosSerie = new System.Windows.Forms.Button();
            this.pbBluetooth = new System.Windows.Forms.PictureBox();
            this.cboVelocidadTransmision = new System.Windows.Forms.ComboBox();
            this.cboPuertoSerie = new System.Windows.Forms.ComboBox();
            this.lblVelocidadTransmision = new System.Windows.Forms.Label();
            this.lblPuertoSerie = new System.Windows.Forms.Label();
            this.panBienvenido = new System.Windows.Forms.Panel();
            this.lblParaObtener = new System.Windows.Forms.Label();
            this.linkManual = new System.Windows.Forms.LinkLabel();
            this.lblConsulte = new System.Windows.Forms.Label();
            this.lblEsteAsistente = new System.Windows.Forms.Label();
            this.lblBienvenidoAlAsistente = new System.Windows.Forms.Label();
            this.panReferencias = new System.Windows.Forms.Panel();
            this.ibCircuito = new Emgu.CV.UI.ImageBox();
            this.panCircuito = new System.Windows.Forms.Panel();
            this.ibCamara = new Emgu.CV.UI.ImageBox();
            this.panCompletado = new System.Windows.Forms.Panel();
            this.panCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panBotonera = new System.Windows.Forms.Panel();
            this.btnSiguienteYTerminar = new ManiXButton.MyButton();
            this.btnVolverYCerrar = new ManiXButton.MyButton();
            this.panIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.panDerecho.SuspendLayout();
            this.panComunicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluetooth)).BeginInit();
            this.panBienvenido.SuspendLayout();
            this.panReferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCircuito)).BeginInit();
            this.panCircuito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara)).BeginInit();
            this.panCabecera.SuspendLayout();
            this.panBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panIzquierdo
            // 
            this.panIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panIzquierdo.Controls.Add(this.pbIcono);
            this.panIzquierdo.Controls.Add(this.lblCompletado);
            this.panIzquierdo.Controls.Add(this.lblComunicacion);
            this.panIzquierdo.Controls.Add(this.lblReferencias);
            this.panIzquierdo.Controls.Add(this.lblCircuito);
            this.panIzquierdo.Controls.Add(this.lblBienvenido);
            this.panIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panIzquierdo.Name = "panIzquierdo";
            this.panIzquierdo.Size = new System.Drawing.Size(200, 662);
            this.panIzquierdo.TabIndex = 0;
            // 
            // pbIcono
            // 
            this.pbIcono.Image = ((System.Drawing.Image)(resources.GetObject("pbIcono.Image")));
            this.pbIcono.Location = new System.Drawing.Point(12, 12);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(171, 144);
            this.pbIcono.TabIndex = 5;
            this.pbIcono.TabStop = false;
            // 
            // lblCompletado
            // 
            this.lblCompletado.AutoSize = true;
            this.lblCompletado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletado.ForeColor = System.Drawing.Color.LightGray;
            this.lblCompletado.Location = new System.Drawing.Point(25, 340);
            this.lblCompletado.Name = "lblCompletado";
            this.lblCompletado.Size = new System.Drawing.Size(105, 20);
            this.lblCompletado.TabIndex = 4;
            this.lblCompletado.Text = "Completado";
            // 
            // lblComunicacion
            // 
            this.lblComunicacion.AutoSize = true;
            this.lblComunicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunicacion.ForeColor = System.Drawing.Color.LightGray;
            this.lblComunicacion.Location = new System.Drawing.Point(25, 305);
            this.lblComunicacion.Name = "lblComunicacion";
            this.lblComunicacion.Size = new System.Drawing.Size(121, 20);
            this.lblComunicacion.TabIndex = 3;
            this.lblComunicacion.Text = "Comunicación";
            // 
            // lblReferencias
            // 
            this.lblReferencias.AutoSize = true;
            this.lblReferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencias.ForeColor = System.Drawing.Color.LightGray;
            this.lblReferencias.Location = new System.Drawing.Point(25, 270);
            this.lblReferencias.Name = "lblReferencias";
            this.lblReferencias.Size = new System.Drawing.Size(106, 20);
            this.lblReferencias.TabIndex = 2;
            this.lblReferencias.Text = "Referencias";
            // 
            // lblCircuito
            // 
            this.lblCircuito.AutoSize = true;
            this.lblCircuito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircuito.ForeColor = System.Drawing.Color.LightGray;
            this.lblCircuito.Location = new System.Drawing.Point(25, 235);
            this.lblCircuito.Name = "lblCircuito";
            this.lblCircuito.Size = new System.Drawing.Size(70, 20);
            this.lblCircuito.TabIndex = 1;
            this.lblCircuito.Text = "Circuito";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(25, 200);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(97, 20);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // panDerecho
            // 
            this.panDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panDerecho.Controls.Add(this.panComunicacion);
            this.panDerecho.Controls.Add(this.panBienvenido);
            this.panDerecho.Controls.Add(this.panReferencias);
            this.panDerecho.Controls.Add(this.panCircuito);
            this.panDerecho.Controls.Add(this.panCompletado);
            this.panDerecho.Controls.Add(this.panCabecera);
            this.panDerecho.Controls.Add(this.panBotonera);
            this.panDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDerecho.Location = new System.Drawing.Point(200, 0);
            this.panDerecho.Name = "panDerecho";
            this.panDerecho.Size = new System.Drawing.Size(864, 662);
            this.panDerecho.TabIndex = 1;
            // 
            // panComunicacion
            // 
            this.panComunicacion.Controls.Add(this.btnRefrescarPuertosSerie);
            this.panComunicacion.Controls.Add(this.pbBluetooth);
            this.panComunicacion.Controls.Add(this.cboVelocidadTransmision);
            this.panComunicacion.Controls.Add(this.cboPuertoSerie);
            this.panComunicacion.Controls.Add(this.lblVelocidadTransmision);
            this.panComunicacion.Controls.Add(this.lblPuertoSerie);
            this.panComunicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panComunicacion.Location = new System.Drawing.Point(0, 80);
            this.panComunicacion.Name = "panComunicacion";
            this.panComunicacion.Size = new System.Drawing.Size(864, 523);
            this.panComunicacion.TabIndex = 0;
            // 
            // btnRefrescarPuertosSerie
            // 
            this.btnRefrescarPuertosSerie.Image = global::EmuladorV2I.Properties.Resources.refresh_icon;
            this.btnRefrescarPuertosSerie.Location = new System.Drawing.Point(792, 31);
            this.btnRefrescarPuertosSerie.Name = "btnRefrescarPuertosSerie";
            this.btnRefrescarPuertosSerie.Size = new System.Drawing.Size(40, 40);
            this.btnRefrescarPuertosSerie.TabIndex = 6;
            this.btnRefrescarPuertosSerie.UseVisualStyleBackColor = true;
            this.btnRefrescarPuertosSerie.Click += new System.EventHandler(this.btnRefrescarPuertosSerie_Click);
            // 
            // pbBluetooth
            // 
            this.pbBluetooth.Image = global::EmuladorV2I.Properties.Resources.bluetooth;
            this.pbBluetooth.Location = new System.Drawing.Point(297, 190);
            this.pbBluetooth.Name = "pbBluetooth";
            this.pbBluetooth.Size = new System.Drawing.Size(267, 261);
            this.pbBluetooth.TabIndex = 5;
            this.pbBluetooth.TabStop = false;
            // 
            // cboVelocidadTransmision
            // 
            this.cboVelocidadTransmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVelocidadTransmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVelocidadTransmision.FormattingEnabled = true;
            this.cboVelocidadTransmision.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cboVelocidadTransmision.Location = new System.Drawing.Point(144, 77);
            this.cboVelocidadTransmision.Name = "cboVelocidadTransmision";
            this.cboVelocidadTransmision.Size = new System.Drawing.Size(180, 28);
            this.cboVelocidadTransmision.TabIndex = 4;
            // 
            // cboPuertoSerie
            // 
            this.cboPuertoSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuertoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuertoSerie.FormattingEnabled = true;
            this.cboPuertoSerie.Location = new System.Drawing.Point(144, 37);
            this.cboPuertoSerie.Name = "cboPuertoSerie";
            this.cboPuertoSerie.Size = new System.Drawing.Size(640, 28);
            this.cboPuertoSerie.TabIndex = 3;
            // 
            // lblVelocidadTransmision
            // 
            this.lblVelocidadTransmision.AutoSize = true;
            this.lblVelocidadTransmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidadTransmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblVelocidadTransmision.Location = new System.Drawing.Point(40, 80);
            this.lblVelocidadTransmision.Name = "lblVelocidadTransmision";
            this.lblVelocidadTransmision.Size = new System.Drawing.Size(83, 20);
            this.lblVelocidadTransmision.TabIndex = 2;
            this.lblVelocidadTransmision.Text = "Velocidad:";
            // 
            // lblPuertoSerie
            // 
            this.lblPuertoSerie.AutoSize = true;
            this.lblPuertoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertoSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPuertoSerie.Location = new System.Drawing.Point(40, 40);
            this.lblPuertoSerie.Name = "lblPuertoSerie";
            this.lblPuertoSerie.Size = new System.Drawing.Size(98, 20);
            this.lblPuertoSerie.TabIndex = 1;
            this.lblPuertoSerie.Text = "Puerto serie:";
            // 
            // panBienvenido
            // 
            this.panBienvenido.Controls.Add(this.lblParaObtener);
            this.panBienvenido.Controls.Add(this.linkManual);
            this.panBienvenido.Controls.Add(this.lblConsulte);
            this.panBienvenido.Controls.Add(this.lblEsteAsistente);
            this.panBienvenido.Controls.Add(this.lblBienvenidoAlAsistente);
            this.panBienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBienvenido.Location = new System.Drawing.Point(0, 80);
            this.panBienvenido.Name = "panBienvenido";
            this.panBienvenido.Size = new System.Drawing.Size(864, 523);
            this.panBienvenido.TabIndex = 7;
            // 
            // lblParaObtener
            // 
            this.lblParaObtener.AutoSize = true;
            this.lblParaObtener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaObtener.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblParaObtener.Location = new System.Drawing.Point(247, 110);
            this.lblParaObtener.Name = "lblParaObtener";
            this.lblParaObtener.Size = new System.Drawing.Size(224, 20);
            this.lblParaObtener.TabIndex = 4;
            this.lblParaObtener.Text = "para obtener más información.";
            // 
            // linkManual
            // 
            this.linkManual.AutoSize = true;
            this.linkManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkManual.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(8)))));
            this.linkManual.Location = new System.Drawing.Point(110, 110);
            this.linkManual.Name = "linkManual";
            this.linkManual.Size = new System.Drawing.Size(139, 20);
            this.linkManual.TabIndex = 3;
            this.linkManual.TabStop = true;
            this.linkManual.Text = "Manual de usuario";
            this.linkManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManual_LinkClicked);
            // 
            // lblConsulte
            // 
            this.lblConsulte.AutoSize = true;
            this.lblConsulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblConsulte.Location = new System.Drawing.Point(40, 110);
            this.lblConsulte.Name = "lblConsulte";
            this.lblConsulte.Size = new System.Drawing.Size(72, 20);
            this.lblConsulte.TabIndex = 2;
            this.lblConsulte.Text = "Consulte";
            // 
            // lblEsteAsistente
            // 
            this.lblEsteAsistente.AutoSize = true;
            this.lblEsteAsistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsteAsistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEsteAsistente.Location = new System.Drawing.Point(40, 75);
            this.lblEsteAsistente.Name = "lblEsteAsistente";
            this.lblEsteAsistente.Size = new System.Drawing.Size(457, 20);
            this.lblEsteAsistente.TabIndex = 1;
            this.lblEsteAsistente.Text = "Este asistente le guiará por los pasos de configuración iniciales.";
            // 
            // lblBienvenidoAlAsistente
            // 
            this.lblBienvenidoAlAsistente.AutoSize = true;
            this.lblBienvenidoAlAsistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoAlAsistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBienvenidoAlAsistente.Location = new System.Drawing.Point(40, 40);
            this.lblBienvenidoAlAsistente.Name = "lblBienvenidoAlAsistente";
            this.lblBienvenidoAlAsistente.Size = new System.Drawing.Size(383, 20);
            this.lblBienvenidoAlAsistente.TabIndex = 0;
            this.lblBienvenidoAlAsistente.Text = "Bienvenido al Asistente de configuración del sistema.";
            // 
            // panReferencias
            // 
            this.panReferencias.Controls.Add(this.ibCircuito);
            this.panReferencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panReferencias.Location = new System.Drawing.Point(0, 80);
            this.panReferencias.Name = "panReferencias";
            this.panReferencias.Size = new System.Drawing.Size(864, 523);
            this.panReferencias.TabIndex = 5;
            // 
            // ibCircuito
            // 
            this.ibCircuito.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibCircuito.Location = new System.Drawing.Point(120, 30);
            this.ibCircuito.MaximumSize = new System.Drawing.Size(640, 480);
            this.ibCircuito.MinimumSize = new System.Drawing.Size(640, 480);
            this.ibCircuito.Name = "ibCircuito";
            this.ibCircuito.Size = new System.Drawing.Size(640, 480);
            this.ibCircuito.TabIndex = 2;
            this.ibCircuito.TabStop = false;
            this.ibCircuito.Click += new System.EventHandler(this.ibCircuito_Click);
            // 
            // panCircuito
            // 
            this.panCircuito.Controls.Add(this.ibCamara);
            this.panCircuito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCircuito.Location = new System.Drawing.Point(0, 80);
            this.panCircuito.Name = "panCircuito";
            this.panCircuito.Size = new System.Drawing.Size(864, 523);
            this.panCircuito.TabIndex = 5;
            // 
            // ibCamara
            // 
            this.ibCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ibCamara.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ibCamara.Location = new System.Drawing.Point(120, 30);
            this.ibCamara.MaximumSize = new System.Drawing.Size(640, 480);
            this.ibCamara.MinimumSize = new System.Drawing.Size(640, 480);
            this.ibCamara.Name = "ibCamara";
            this.ibCamara.Size = new System.Drawing.Size(640, 480);
            this.ibCamara.TabIndex = 2;
            this.ibCamara.TabStop = false;
            // 
            // panCompletado
            // 
            this.panCompletado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCompletado.Location = new System.Drawing.Point(0, 80);
            this.panCompletado.Name = "panCompletado";
            this.panCompletado.Size = new System.Drawing.Size(864, 523);
            this.panCompletado.TabIndex = 0;
            // 
            // panCabecera
            // 
            this.panCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCabecera.Controls.Add(this.lblTitulo);
            this.panCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCabecera.Location = new System.Drawing.Point(0, 0);
            this.panCabecera.Name = "panCabecera";
            this.panCabecera.Size = new System.Drawing.Size(864, 80);
            this.panCabecera.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(419, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Asistente de configuración del sistema";
            // 
            // panBotonera
            // 
            this.panBotonera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBotonera.Controls.Add(this.btnSiguienteYTerminar);
            this.panBotonera.Controls.Add(this.btnVolverYCerrar);
            this.panBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBotonera.Location = new System.Drawing.Point(0, 603);
            this.panBotonera.Name = "panBotonera";
            this.panBotonera.Size = new System.Drawing.Size(864, 59);
            this.panBotonera.TabIndex = 5;
            // 
            // btnSiguienteYTerminar
            // 
            office2010Yellow1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Yellow1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Yellow1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Yellow1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Yellow1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Yellow1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Yellow1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(8)))));
            office2010Yellow1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            office2010Yellow1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(8)))));
            office2010Yellow1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            office2010Yellow1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Yellow1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Yellow1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Yellow1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Yellow1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Yellow1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Yellow1.TextColor = System.Drawing.Color.Black;
            this.btnSiguienteYTerminar.ColorTable = office2010Yellow1;
            this.btnSiguienteYTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteYTerminar.Location = new System.Drawing.Point(771, 16);
            this.btnSiguienteYTerminar.Name = "btnSiguienteYTerminar";
            this.btnSiguienteYTerminar.Size = new System.Drawing.Size(80, 30);
            this.btnSiguienteYTerminar.TabIndex = 9;
            this.btnSiguienteYTerminar.Text = "Siguiente";
            this.btnSiguienteYTerminar.Theme = ManiXButton.Theme.MSOffice2010_Yellow;
            this.btnSiguienteYTerminar.UseVisualStyleBackColor = true;
            this.btnSiguienteYTerminar.Click += new System.EventHandler(this.btnSiguienteYTerminar_Click);
            // 
            // btnVolverYCerrar
            // 
            this.btnVolverYCerrar.ColorTable = office2010Yellow1;
            this.btnVolverYCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverYCerrar.Location = new System.Drawing.Point(682, 16);
            this.btnVolverYCerrar.Name = "btnVolverYCerrar";
            this.btnVolverYCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnVolverYCerrar.TabIndex = 8;
            this.btnVolverYCerrar.Text = "Cerrar";
            this.btnVolverYCerrar.Theme = ManiXButton.Theme.MSOffice2010_Yellow;
            this.btnVolverYCerrar.UseVisualStyleBackColor = true;
            this.btnVolverYCerrar.Click += new System.EventHandler(this.btnVolverYCerrar_Click);
            // 
            // frmAsistenteConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 662);
            this.Controls.Add(this.panDerecho);
            this.Controls.Add(this.panIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 700);
            this.Name = "frmAsistenteConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de configuración";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAsistenteConfiguracion_FormClosed);
            this.Load += new System.EventHandler(this.FrmAsistenteConfiguracion_Load);
            this.panIzquierdo.ResumeLayout(false);
            this.panIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.panDerecho.ResumeLayout(false);
            this.panComunicacion.ResumeLayout(false);
            this.panComunicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluetooth)).EndInit();
            this.panBienvenido.ResumeLayout(false);
            this.panBienvenido.PerformLayout();
            this.panReferencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibCircuito)).EndInit();
            this.panCircuito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara)).EndInit();
            this.panCabecera.ResumeLayout(false);
            this.panCabecera.PerformLayout();
            this.panBotonera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panIzquierdo;
        private System.Windows.Forms.Panel panDerecho;
        private System.Windows.Forms.Label lblCompletado;
        private System.Windows.Forms.Label lblComunicacion;
        private System.Windows.Forms.Label lblReferencias;
        private System.Windows.Forms.Label lblCircuito;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panBotonera;
        private System.Windows.Forms.Panel panCabecera;
        private ManiXButton.MyButton btnVolverYCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panBienvenido;
        private System.Windows.Forms.Label lblBienvenidoAlAsistente;
        private System.Windows.Forms.Label lblConsulte;
        private System.Windows.Forms.Label lblEsteAsistente;
        private System.Windows.Forms.LinkLabel linkManual;
        private System.Windows.Forms.Label lblParaObtener;
        private System.Windows.Forms.Panel panCircuito;
        private System.Windows.Forms.Panel panReferencias;
        private System.Windows.Forms.Panel panComunicacion;
        private System.Windows.Forms.Panel panCompletado;
        private Emgu.CV.UI.ImageBox ibCamara;
        private ManiXButton.MyButton btnSiguienteYTerminar;
        private Emgu.CV.UI.ImageBox ibCircuito;
        private System.Windows.Forms.Label lblVelocidadTransmision;
        private System.Windows.Forms.Label lblPuertoSerie;
        private System.Windows.Forms.ComboBox cboPuertoSerie;
        private System.Windows.Forms.ComboBox cboVelocidadTransmision;
        private System.Windows.Forms.PictureBox pbBluetooth;
        private System.Windows.Forms.Button btnRefrescarPuertosSerie;
        private System.Windows.Forms.PictureBox pbIcono;

    }
}

