namespace EmuladorV2I.Test
{
    partial class frmProcesamientoDeImagen
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
            this.components = new System.ComponentModel.Container();
            ManiXButton.Office2010Blue office2010Blue1 = new ManiXButton.Office2010Blue();
            this.ibCamara1 = new Emgu.CV.UI.ImageBox();
            this.ibCamara2 = new Emgu.CV.UI.ImageBox();
            this.btnCorregirPerspectiva = new ManiXButton.MyButton();
            this.btnNormal = new ManiXButton.MyButton();
            this.btnDetectarRobots = new ManiXButton.MyButton();
            this.btnDetectarCircuito = new ManiXButton.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara2)).BeginInit();
            this.SuspendLayout();
            // 
            // ibCamara1
            // 
            this.ibCamara1.Location = new System.Drawing.Point(30, 25);
            this.ibCamara1.Name = "ibCamara1";
            this.ibCamara1.Size = new System.Drawing.Size(640, 480);
            this.ibCamara1.TabIndex = 2;
            this.ibCamara1.TabStop = false;
            // 
            // ibCamara2
            // 
            this.ibCamara2.Location = new System.Drawing.Point(701, 25);
            this.ibCamara2.Name = "ibCamara2";
            this.ibCamara2.Size = new System.Drawing.Size(640, 480);
            this.ibCamara2.TabIndex = 6;
            this.ibCamara2.TabStop = false;
            // 
            // btnCorregirPerspectiva
            // 
            office2010Blue1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.TextColor = System.Drawing.Color.White;
            this.btnCorregirPerspectiva.ColorTable = office2010Blue1;
            this.btnCorregirPerspectiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorregirPerspectiva.Location = new System.Drawing.Point(843, 517);
            this.btnCorregirPerspectiva.Name = "btnCorregirPerspectiva";
            this.btnCorregirPerspectiva.Size = new System.Drawing.Size(128, 37);
            this.btnCorregirPerspectiva.TabIndex = 7;
            this.btnCorregirPerspectiva.Text = "Corregir perspectiva";
            this.btnCorregirPerspectiva.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.btnCorregirPerspectiva.UseVisualStyleBackColor = true;
            this.btnCorregirPerspectiva.Click += new System.EventHandler(this.btnCorregirPerspectiva_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.ColorTable = office2010Blue1;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(30, 517);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(128, 37);
            this.btnNormal.TabIndex = 5;
            this.btnNormal.Text = "Normal";
            this.btnNormal.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnDetectarRobots
            // 
            this.btnDetectarRobots.ColorTable = office2010Blue1;
            this.btnDetectarRobots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectarRobots.Location = new System.Drawing.Point(1213, 517);
            this.btnDetectarRobots.Name = "btnDetectarRobots";
            this.btnDetectarRobots.Size = new System.Drawing.Size(128, 37);
            this.btnDetectarRobots.TabIndex = 4;
            this.btnDetectarRobots.Text = "Detectar robots";
            this.btnDetectarRobots.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.btnDetectarRobots.UseVisualStyleBackColor = true;
            this.btnDetectarRobots.Click += new System.EventHandler(this.btnDetectarRobots_Click);
            // 
            // btnDetectarCircuito
            // 
            this.btnDetectarCircuito.ColorTable = office2010Blue1;
            this.btnDetectarCircuito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectarCircuito.Location = new System.Drawing.Point(408, 517);
            this.btnDetectarCircuito.Name = "btnDetectarCircuito";
            this.btnDetectarCircuito.Size = new System.Drawing.Size(128, 37);
            this.btnDetectarCircuito.TabIndex = 3;
            this.btnDetectarCircuito.Text = "Detectar circuito";
            this.btnDetectarCircuito.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.btnDetectarCircuito.UseVisualStyleBackColor = true;
            this.btnDetectarCircuito.Click += new System.EventHandler(this.btnDetectarCircuito_Click);
            // 
            // frmProcesamientoDeImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1374, 562);
            this.Controls.Add(this.btnCorregirPerspectiva);
            this.Controls.Add(this.ibCamara2);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnDetectarRobots);
            this.Controls.Add(this.btnDetectarCircuito);
            this.Controls.Add(this.ibCamara1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1390, 600);
            this.MinimumSize = new System.Drawing.Size(1300, 600);
            this.Name = "frmProcesamientoDeImagen";
            this.Text = "Procesamiento de imágenes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProcesamientoDeImagen_FormClosed);
            this.Load += new System.EventHandler(this.frmProcesamientoDeImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibCamara1;
        private ManiXButton.MyButton btnDetectarCircuito;
        private ManiXButton.MyButton btnDetectarRobots;
        private ManiXButton.MyButton btnNormal;
        private Emgu.CV.UI.ImageBox ibCamara2;
        private ManiXButton.MyButton btnCorregirPerspectiva;
    }
}