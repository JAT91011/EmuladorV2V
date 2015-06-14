namespace SimuladorV2V.Formularios
{
    partial class frmRobot
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
            ManiXButton.Office2010Yellow office2010Yellow1 = new ManiXButton.Office2010Yellow();
            ManiXButton.Office2010Green office2010Green1 = new ManiXButton.Office2010Green();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.rbLibre = new System.Windows.Forms.RadioButton();
            this.rbRuta = new System.Windows.Forms.RadioButton();
            this.lblModo = new System.Windows.Forms.Label();
            this.rbAveriado = new System.Windows.Forms.RadioButton();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.trackBarVelocidad = new System.Windows.Forms.TrackBar();
            this.btnCancelar = new ManiXButton.MyButton();
            this.btnGuardar = new ManiXButton.MyButton();
            this.btnBuscar = new ManiXButton.MyButton();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(19, 30);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 18);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción *:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(126, 27);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(312, 24);
            this.txtDescripcion.TabIndex = 1;
            // 
            // rbLibre
            // 
            this.rbLibre.AutoSize = true;
            this.rbLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLibre.Location = new System.Drawing.Point(133, 146);
            this.rbLibre.Name = "rbLibre";
            this.rbLibre.Size = new System.Drawing.Size(58, 22);
            this.rbLibre.TabIndex = 2;
            this.rbLibre.TabStop = true;
            this.rbLibre.Text = "Libre";
            this.rbLibre.UseVisualStyleBackColor = true;
            // 
            // rbRuta
            // 
            this.rbRuta.AutoSize = true;
            this.rbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRuta.Location = new System.Drawing.Point(198, 146);
            this.rbRuta.Name = "rbRuta";
            this.rbRuta.Size = new System.Drawing.Size(57, 22);
            this.rbRuta.TabIndex = 3;
            this.rbRuta.TabStop = true;
            this.rbRuta.Text = "Ruta";
            this.rbRuta.UseVisualStyleBackColor = true;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(25, 146);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(61, 18);
            this.lblModo.TabIndex = 4;
            this.lblModo.Text = "Modo *:";
            // 
            // rbAveriado
            // 
            this.rbAveriado.AutoSize = true;
            this.rbAveriado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAveriado.Location = new System.Drawing.Point(261, 146);
            this.rbAveriado.Name = "rbAveriado";
            this.rbAveriado.Size = new System.Drawing.Size(83, 22);
            this.rbAveriado.TabIndex = 5;
            this.rbAveriado.TabStop = true;
            this.rbAveriado.Text = "Averiado";
            this.rbAveriado.UseVisualStyleBackColor = true;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidad.Location = new System.Drawing.Point(444, 30);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(86, 18);
            this.lblVelocidad.TabIndex = 6;
            this.lblVelocidad.Text = "Velocidad *:";
            // 
            // trackBarVelocidad
            // 
            this.trackBarVelocidad.AccessibleName = "";
            this.trackBarVelocidad.LargeChange = 10;
            this.trackBarVelocidad.Location = new System.Drawing.Point(536, 27);
            this.trackBarVelocidad.Maximum = 100;
            this.trackBarVelocidad.Name = "trackBarVelocidad";
            this.trackBarVelocidad.Size = new System.Drawing.Size(225, 45);
            this.trackBarVelocidad.SmallChange = 10;
            this.trackBarVelocidad.TabIndex = 8;
            this.trackBarVelocidad.TickFrequency = 10;
            // 
            // btnCancelar
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
            this.btnCancelar.ColorTable = office2010Yellow1;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(586, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Theme = ManiXButton.Theme.MSOffice2010_Yellow;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ColorTable = office2010Yellow1;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(675, 560);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Theme = ManiXButton.Theme.MSOffice2010_Yellow;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            office2010Green1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Green1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Green1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Green1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Green1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Green1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Green1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.TextColor = System.Drawing.Color.White;
            this.btnBuscar.ColorTable = office2010Green1;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(675, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 30);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Theme = ManiXButton.Theme.MSOffice2010_Green;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbCamara
            // 
            this.pbCamara.Location = new System.Drawing.Point(22, 65);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(733, 480);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamara.TabIndex = 13;
            this.pbCamara.TabStop = false;
            // 
            // frmRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(774, 602);
            this.Controls.Add(this.pbCamara);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.trackBarVelocidad);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.rbLibre);
            this.Controls.Add(this.rbRuta);
            this.Controls.Add(this.rbAveriado);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(790, 640);
            this.Name = "frmRobot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRobot";
            this.Load += new System.EventHandler(this.frmRobot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.RadioButton rbLibre;
        private System.Windows.Forms.RadioButton rbRuta;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.RadioButton rbAveriado;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.TrackBar trackBarVelocidad;
        private ManiXButton.MyButton btnGuardar;
        private ManiXButton.MyButton btnCancelar;
        private ManiXButton.MyButton btnBuscar;
        private System.Windows.Forms.PictureBox pbCamara;

    }
}