namespace EmuladorV2I
{
    partial class frmPanelPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelPrincipal));
            ManiXButton.Office2010Red office2010Red2 = new ManiXButton.Office2010Red();
            this.panCamara = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.chkIntersecciones = new System.Windows.Forms.CheckBox();
            this.chkCorregirPerspectiva = new System.Windows.Forms.CheckBox();
            this.panRobots = new System.Windows.Forms.Panel();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.cboSeguridadApagado = new System.Windows.Forms.ComboBox();
            this.spinVelocidad = new System.Windows.Forms.NumericUpDown();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.gbSensores = new System.Windows.Forms.GroupBox();
            this.lblBateriaValor = new System.Windows.Forms.Label();
            this.lblTemperaturaValor = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.cboModo = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.btnDesconectar = new ManiXButton.MyButton();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblNavegador = new System.Windows.Forms.Label();
            this.panCamara.SuspendLayout();
            this.panRobots.SuspendLayout();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinVelocidad)).BeginInit();
            this.gbSensores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // panCamara
            // 
            this.panCamara.Controls.Add(this.lblMensaje);
            this.panCamara.Controls.Add(this.chkIntersecciones);
            this.panCamara.Controls.Add(this.pbCamara);
            this.panCamara.Controls.Add(this.chkCorregirPerspectiva);
            resources.ApplyResources(this.panCamara, "panCamara");
            this.panCamara.Name = "panCamara";
            // 
            // lblMensaje
            // 
            resources.ApplyResources(this.lblMensaje, "lblMensaje");
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMensaje.Name = "lblMensaje";
            // 
            // chkIntersecciones
            // 
            resources.ApplyResources(this.chkIntersecciones, "chkIntersecciones");
            this.chkIntersecciones.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.chkIntersecciones.Name = "chkIntersecciones";
            this.chkIntersecciones.UseVisualStyleBackColor = true;
            // 
            // chkCorregirPerspectiva
            // 
            resources.ApplyResources(this.chkCorregirPerspectiva, "chkCorregirPerspectiva");
            this.chkCorregirPerspectiva.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.chkCorregirPerspectiva.Name = "chkCorregirPerspectiva";
            this.chkCorregirPerspectiva.UseVisualStyleBackColor = true;
            // 
            // panRobots
            // 
            resources.ApplyResources(this.panRobots, "panRobots");
            this.panRobots.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panRobots.Controls.Add(this.lblNavegador);
            this.panRobots.Controls.Add(this.btnRight);
            this.panRobots.Controls.Add(this.btnLeft);
            this.panRobots.Controls.Add(this.btnDesconectar);
            this.panRobots.Controls.Add(this.gbParametros);
            this.panRobots.Controls.Add(this.lblId);
            this.panRobots.Controls.Add(this.lblIdValor);
            this.panRobots.Controls.Add(this.gbSensores);
            this.panRobots.Controls.Add(this.cboModo);
            this.panRobots.Controls.Add(this.lblModo);
            this.panRobots.Name = "panRobots";
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.cboSeguridadApagado);
            this.gbParametros.Controls.Add(this.spinVelocidad);
            this.gbParametros.Controls.Add(this.lblVelocidad);
            this.gbParametros.Controls.Add(this.label4);
            resources.ApplyResources(this.gbParametros, "gbParametros");
            this.gbParametros.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.TabStop = false;
            // 
            // cboSeguridadApagado
            // 
            this.cboSeguridadApagado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboSeguridadApagado, "cboSeguridadApagado");
            this.cboSeguridadApagado.FormattingEnabled = true;
            this.cboSeguridadApagado.Items.AddRange(new object[] {
            resources.GetString("cboSeguridadApagado.Items"),
            resources.GetString("cboSeguridadApagado.Items1"),
            resources.GetString("cboSeguridadApagado.Items2"),
            resources.GetString("cboSeguridadApagado.Items3"),
            resources.GetString("cboSeguridadApagado.Items4"),
            resources.GetString("cboSeguridadApagado.Items5")});
            this.cboSeguridadApagado.Name = "cboSeguridadApagado";
            this.cboSeguridadApagado.SelectedIndexChanged += new System.EventHandler(this.cboSeguridadApagado_SelectedIndexChanged);
            // 
            // spinVelocidad
            // 
            resources.ApplyResources(this.spinVelocidad, "spinVelocidad");
            this.spinVelocidad.Name = "spinVelocidad";
            // 
            // lblVelocidad
            // 
            resources.ApplyResources(this.lblVelocidad, "lblVelocidad");
            this.lblVelocidad.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblVelocidad.Name = "lblVelocidad";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Name = "label4";
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblId.Name = "lblId";
            // 
            // lblIdValor
            // 
            resources.ApplyResources(this.lblIdValor, "lblIdValor");
            this.lblIdValor.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblIdValor.Name = "lblIdValor";
            // 
            // gbSensores
            // 
            this.gbSensores.Controls.Add(this.lblBateriaValor);
            this.gbSensores.Controls.Add(this.lblTemperaturaValor);
            this.gbSensores.Controls.Add(this.lblBateria);
            this.gbSensores.Controls.Add(this.lblTemperatura);
            resources.ApplyResources(this.gbSensores, "gbSensores");
            this.gbSensores.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbSensores.Name = "gbSensores";
            this.gbSensores.TabStop = false;
            // 
            // lblBateriaValor
            // 
            resources.ApplyResources(this.lblBateriaValor, "lblBateriaValor");
            this.lblBateriaValor.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblBateriaValor.Name = "lblBateriaValor";
            // 
            // lblTemperaturaValor
            // 
            resources.ApplyResources(this.lblTemperaturaValor, "lblTemperaturaValor");
            this.lblTemperaturaValor.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTemperaturaValor.Name = "lblTemperaturaValor";
            // 
            // lblBateria
            // 
            resources.ApplyResources(this.lblBateria, "lblBateria");
            this.lblBateria.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblBateria.Name = "lblBateria";
            // 
            // lblTemperatura
            // 
            resources.ApplyResources(this.lblTemperatura, "lblTemperatura");
            this.lblTemperatura.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTemperatura.Name = "lblTemperatura";
            // 
            // cboModo
            // 
            this.cboModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboModo, "cboModo");
            this.cboModo.FormattingEnabled = true;
            this.cboModo.Items.AddRange(new object[] {
            resources.GetString("cboModo.Items"),
            resources.GetString("cboModo.Items1")});
            this.cboModo.Name = "cboModo";
            this.cboModo.SelectedIndexChanged += new System.EventHandler(this.cboModo_SelectedIndexChanged);
            // 
            // lblModo
            // 
            resources.ApplyResources(this.lblModo, "lblModo");
            this.lblModo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblModo.Name = "lblModo";
            // 
            // btnDesconectar
            // 
            resources.ApplyResources(this.btnDesconectar, "btnDesconectar");
            office2010Red2.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Red2.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Red2.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Red2.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Red2.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Red2.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Red2.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            office2010Red2.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            office2010Red2.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            office2010Red2.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            office2010Red2.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Red2.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Red2.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Red2.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Red2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Red2.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Red2.TextColor = System.Drawing.Color.White;
            this.btnDesconectar.ColorTable = office2010Red2;
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Theme = ManiXButton.Theme.MSOffice2010_RED;
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::EmuladorV2I.Properties.Resources.left_icon;
            resources.ApplyResources(this.btnLeft, "btnLeft");
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pbCamara
            // 
            resources.ApplyResources(this.pbCamara, "pbCamara");
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Image = global::EmuladorV2I.Properties.Resources.right_icon;
            resources.ApplyResources(this.btnRight, "btnRight");
            this.btnRight.Name = "btnRight";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblNavegador
            // 
            resources.ApplyResources(this.lblNavegador, "lblNavegador");
            this.lblNavegador.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNavegador.Name = "lblNavegador";
            // 
            // frmPanelPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panCamara);
            this.Controls.Add(this.panRobots);
            this.Name = "frmPanelPrincipal";
            this.Load += new System.EventHandler(this.frmPanelPrincipal_Load);
            this.panCamara.ResumeLayout(false);
            this.panCamara.PerformLayout();
            this.panRobots.ResumeLayout(false);
            this.panRobots.PerformLayout();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinVelocidad)).EndInit();
            this.gbSensores.ResumeLayout(false);
            this.gbSensores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Panel panCamara;
        private System.Windows.Forms.CheckBox chkCorregirPerspectiva;
        private System.Windows.Forms.CheckBox chkIntersecciones;
        private System.Windows.Forms.Panel panRobots;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cboModo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.GroupBox gbSensores;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblTemperaturaValor;
        private System.Windows.Forms.Label lblBateriaValor;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.ComboBox cboSeguridadApagado;
        private System.Windows.Forms.NumericUpDown spinVelocidad;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label label4;
        private ManiXButton.MyButton btnDesconectar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblNavegador;
    }
}