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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panIzquierdo = new System.Windows.Forms.Panel();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnRobots = new System.Windows.Forms.Button();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.panCamara = new System.Windows.Forms.Panel();
            this.panBotoneraCamara = new System.Windows.Forms.Panel();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.panRobots = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gvRobots = new System.Windows.Forms.DataGridView();
            this.IdRobot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Bateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panIzquierdo.SuspendLayout();
            this.panCamara.SuspendLayout();
            this.panBotoneraCamara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            this.panRobots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRobots)).BeginInit();
            this.SuspendLayout();
            // 
            // panIzquierdo
            // 
            this.panIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panIzquierdo.Controls.Add(this.btnAjustes);
            this.panIzquierdo.Controls.Add(this.btnInicio);
            this.panIzquierdo.Controls.Add(this.btnRutas);
            this.panIzquierdo.Controls.Add(this.btnRobots);
            this.panIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panIzquierdo.Name = "panIzquierdo";
            this.panIzquierdo.Size = new System.Drawing.Size(210, 661);
            this.panIzquierdo.TabIndex = 0;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Image = global::EmuladorV2I.Properties.Resources.settings_icon;
            this.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.Location = new System.Drawing.Point(15, 225);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(180, 42);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.Text = "Configuración";
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjustes.UseCompatibleTextRendering = true;
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::EmuladorV2I.Properties.Resources.webcam_icon;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(15, 60);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(180, 42);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseCompatibleTextRendering = true;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.Image = global::EmuladorV2I.Properties.Resources.route_icon;
            this.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.Location = new System.Drawing.Point(15, 170);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(180, 42);
            this.btnRutas.TabIndex = 2;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRutas.UseCompatibleTextRendering = true;
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnRobots
            // 
            this.btnRobots.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobots.Image = global::EmuladorV2I.Properties.Resources.car_icon;
            this.btnRobots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobots.Location = new System.Drawing.Point(15, 115);
            this.btnRobots.Name = "btnRobots";
            this.btnRobots.Size = new System.Drawing.Size(180, 42);
            this.btnRobots.TabIndex = 1;
            this.btnRobots.Text = "Robots";
            this.btnRobots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobots.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRobots.UseCompatibleTextRendering = true;
            this.btnRobots.UseVisualStyleBackColor = true;
            this.btnRobots.Click += new System.EventHandler(this.btnRobots_Click);
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Image = global::EmuladorV2I.Properties.Resources.play_icon;
            this.btnIniciarParar.Location = new System.Drawing.Point(16, 3);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(42, 42);
            this.btnIniciarParar.TabIndex = 3;
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // panCamara
            // 
            this.panCamara.Controls.Add(this.panBotoneraCamara);
            this.panCamara.Controls.Add(this.pbCamara);
            this.panCamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCamara.Location = new System.Drawing.Point(210, 0);
            this.panCamara.Name = "panCamara";
            this.panCamara.Size = new System.Drawing.Size(919, 661);
            this.panCamara.TabIndex = 1;
            // 
            // panBotoneraCamara
            // 
            this.panBotoneraCamara.Controls.Add(this.btnIniciarParar);
            this.panBotoneraCamara.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBotoneraCamara.Location = new System.Drawing.Point(0, 611);
            this.panBotoneraCamara.Name = "panBotoneraCamara";
            this.panBotoneraCamara.Size = new System.Drawing.Size(919, 50);
            this.panBotoneraCamara.TabIndex = 1;
            // 
            // pbCamara
            // 
            this.pbCamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCamara.Location = new System.Drawing.Point(0, 0);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(919, 661);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamara.TabIndex = 0;
            this.pbCamara.TabStop = false;
            // 
            // panRobots
            // 
            this.panRobots.Controls.Add(this.progressBar);
            this.panRobots.Controls.Add(this.btnEliminar);
            this.panRobots.Controls.Add(this.btnNuevo);
            this.panRobots.Controls.Add(this.gvRobots);
            this.panRobots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRobots.Location = new System.Drawing.Point(210, 0);
            this.panRobots.Name = "panRobots";
            this.panRobots.Size = new System.Drawing.Size(919, 661);
            this.panRobots.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(6, 627);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(906, 31);
            this.progressBar.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::EmuladorV2I.Properties.Resources.delete_icon;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(112, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::EmuladorV2I.Properties.Resources.add_icon;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(6, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 32);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gvRobots
            // 
            this.gvRobots.AllowUserToAddRows = false;
            this.gvRobots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRobots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvRobots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRobots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRobot,
            this.Descripcion,
            this.Modo,
            this.Bateria,
            this.Temperatura});
            this.gvRobots.Location = new System.Drawing.Point(6, 60);
            this.gvRobots.Name = "gvRobots";
            this.gvRobots.Size = new System.Drawing.Size(906, 561);
            this.gvRobots.TabIndex = 1;
            // 
            // IdRobot
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdRobot.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdRobot.HeaderText = "ID";
            this.IdRobot.MaxInputLength = 3;
            this.IdRobot.Name = "IdRobot";
            this.IdRobot.ReadOnly = true;
            this.IdRobot.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.FillWeight = 200F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Modo
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Modo.HeaderText = "Modo";
            this.Modo.Items.AddRange(new object[] {
            "Libre",
            "Averiado"});
            this.Modo.Name = "Modo";
            // 
            // Bateria
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bateria.DefaultCellStyle = dataGridViewCellStyle5;
            this.Bateria.HeaderText = "Batería";
            this.Bateria.Name = "Bateria";
            this.Bateria.ReadOnly = true;
            // 
            // Temperatura
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperatura.DefaultCellStyle = dataGridViewCellStyle6;
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.ReadOnly = true;
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1129, 661);
            this.Controls.Add(this.panRobots);
            this.Controls.Add(this.panCamara);
            this.Controls.Add(this.panIzquierdo);
            this.Name = "frmPanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emulador V2I";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPanelPrincipal_Load);
            this.panIzquierdo.ResumeLayout(false);
            this.panCamara.ResumeLayout(false);
            this.panBotoneraCamara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            this.panRobots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRobots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panIzquierdo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnRobots;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Panel panCamara;
        private System.Windows.Forms.Panel panRobots;
        private System.Windows.Forms.DataGridView gvRobots;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panBotoneraCamara;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRobot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}