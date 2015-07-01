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
            this.panIzquierdo = new System.Windows.Forms.Panel();
            this.panBotones = new System.Windows.Forms.Panel();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.listRobots = new System.Windows.Forms.ListView();
            this.splitDerecho = new System.Windows.Forms.SplitContainer();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrarTexto = new System.Windows.Forms.Button();
            this.cboMensajes = new System.Windows.Forms.ComboBox();
            this.lblMostrarDesde = new System.Windows.Forms.Label();
            this.textBoxConsola = new System.Windows.Forms.TextBox();
            this.panIzquierdo.SuspendLayout();
            this.panBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDerecho)).BeginInit();
            this.splitDerecho.Panel1.SuspendLayout();
            this.splitDerecho.Panel2.SuspendLayout();
            this.splitDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // panIzquierdo
            // 
            this.panIzquierdo.Controls.Add(this.panBotones);
            this.panIzquierdo.Controls.Add(this.listRobots);
            this.panIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panIzquierdo.Name = "panIzquierdo";
            this.panIzquierdo.Size = new System.Drawing.Size(210, 661);
            this.panIzquierdo.TabIndex = 0;
            // 
            // panBotones
            // 
            this.panBotones.Controls.Add(this.btnIniciarParar);
            this.panBotones.Controls.Add(this.btnRutas);
            this.panBotones.Controls.Add(this.btnEliminar);
            this.panBotones.Controls.Add(this.btnNuevo);
            this.panBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBotones.Location = new System.Drawing.Point(0, 0);
            this.panBotones.Name = "panBotones";
            this.panBotones.Size = new System.Drawing.Size(210, 60);
            this.panBotones.TabIndex = 1;
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Image = global::EmuladorV2I.Properties.Resources.play_icon;
            this.btnIniciarParar.Location = new System.Drawing.Point(156, 12);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(42, 42);
            this.btnIniciarParar.TabIndex = 3;
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Image = global::EmuladorV2I.Properties.Resources.route_icon;
            this.btnRutas.Location = new System.Drawing.Point(108, 12);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(42, 42);
            this.btnRutas.TabIndex = 2;
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::EmuladorV2I.Properties.Resources.delete_icon;
            this.btnEliminar.Location = new System.Drawing.Point(60, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(42, 42);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImage = global::EmuladorV2I.Properties.Resources.add_icon;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(42, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // listRobots
            // 
            this.listRobots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listRobots.Location = new System.Drawing.Point(12, 0);
            this.listRobots.Name = "listRobots";
            this.listRobots.Size = new System.Drawing.Size(186, 656);
            this.listRobots.TabIndex = 0;
            this.listRobots.UseCompatibleStateImageBehavior = false;
            // 
            // splitDerecho
            // 
            this.splitDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.splitDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDerecho.Location = new System.Drawing.Point(210, 0);
            this.splitDerecho.Name = "splitDerecho";
            this.splitDerecho.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDerecho.Panel1
            // 
            this.splitDerecho.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitDerecho.Panel1.Controls.Add(this.pbCamara);
            // 
            // splitDerecho.Panel2
            // 
            this.splitDerecho.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitDerecho.Panel2.Controls.Add(this.txtEnviar);
            this.splitDerecho.Panel2.Controls.Add(this.btnEnviar);
            this.splitDerecho.Panel2.Controls.Add(this.lblEnviar);
            this.splitDerecho.Panel2.Controls.Add(this.button1);
            this.splitDerecho.Panel2.Controls.Add(this.btnBorrarTexto);
            this.splitDerecho.Panel2.Controls.Add(this.cboMensajes);
            this.splitDerecho.Panel2.Controls.Add(this.lblMostrarDesde);
            this.splitDerecho.Panel2.Controls.Add(this.textBoxConsola);
            this.splitDerecho.Size = new System.Drawing.Size(919, 661);
            this.splitDerecho.SplitterDistance = 485;
            this.splitDerecho.TabIndex = 1;
            // 
            // pbCamara
            // 
            this.pbCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCamara.Location = new System.Drawing.Point(6, 12);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(903, 467);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamara.TabIndex = 0;
            this.pbCamara.TabStop = false;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviar.Location = new System.Drawing.Point(54, 144);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(791, 22);
            this.txtEnviar.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(851, 143);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(60, 25);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblEnviar
            // 
            this.lblEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEnviar.AutoEllipsis = true;
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.ForeColor = System.Drawing.Color.LightGray;
            this.lblEnviar.Location = new System.Drawing.Point(0, 147);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(48, 16);
            this.lblEnviar.TabIndex = 5;
            this.lblEnviar.Text = "Enviar:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(884, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTexto
            // 
            this.btnBorrarTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarTexto.Location = new System.Drawing.Point(851, 11);
            this.btnBorrarTexto.Name = "btnBorrarTexto";
            this.btnBorrarTexto.Size = new System.Drawing.Size(27, 25);
            this.btnBorrarTexto.TabIndex = 3;
            this.btnBorrarTexto.UseVisualStyleBackColor = true;
            this.btnBorrarTexto.Click += new System.EventHandler(this.btnBorrarTexto_Click);
            // 
            // cboMensajes
            // 
            this.cboMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMensajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMensajes.FormattingEnabled = true;
            this.cboMensajes.Location = new System.Drawing.Point(165, 11);
            this.cboMensajes.Name = "cboMensajes";
            this.cboMensajes.Size = new System.Drawing.Size(680, 24);
            this.cboMensajes.TabIndex = 2;
            this.cboMensajes.SelectedIndexChanged += new System.EventHandler(this.cboMensajes_SelectedIndexChanged);
            // 
            // lblMostrarDesde
            // 
            this.lblMostrarDesde.AutoEllipsis = true;
            this.lblMostrarDesde.AutoSize = true;
            this.lblMostrarDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMostrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDesde.ForeColor = System.Drawing.Color.LightGray;
            this.lblMostrarDesde.Location = new System.Drawing.Point(0, 14);
            this.lblMostrarDesde.Name = "lblMostrarDesde";
            this.lblMostrarDesde.Size = new System.Drawing.Size(159, 16);
            this.lblMostrarDesde.TabIndex = 1;
            this.lblMostrarDesde.Text = "Mostrar mensajes desde:";
            // 
            // textBoxConsola
            // 
            this.textBoxConsola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxConsola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsola.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxConsola.Location = new System.Drawing.Point(3, 42);
            this.textBoxConsola.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxConsola.Multiline = true;
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.ReadOnly = true;
            this.textBoxConsola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsola.Size = new System.Drawing.Size(906, 96);
            this.textBoxConsola.TabIndex = 0;
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1129, 661);
            this.Controls.Add(this.splitDerecho);
            this.Controls.Add(this.panIzquierdo);
            this.Name = "frmPanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimuladorV2V";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPanelPrincipal_Load);
            this.panIzquierdo.ResumeLayout(false);
            this.panBotones.ResumeLayout(false);
            this.splitDerecho.Panel1.ResumeLayout(false);
            this.splitDerecho.Panel2.ResumeLayout(false);
            this.splitDerecho.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDerecho)).EndInit();
            this.splitDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panIzquierdo;
        private System.Windows.Forms.ListView listRobots;
        private System.Windows.Forms.Panel panBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.SplitContainer splitDerecho;
        private System.Windows.Forms.TextBox textBoxConsola;
        private System.Windows.Forms.Label lblMostrarDesde;
        private System.Windows.Forms.ComboBox cboMensajes;
        private System.Windows.Forms.Button btnBorrarTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.PictureBox pbCamara;
    }
}