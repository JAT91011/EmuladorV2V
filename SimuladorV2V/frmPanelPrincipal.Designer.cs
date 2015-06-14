namespace SimuladorV2V
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
            this.components = new System.ComponentModel.Container();
            this.panIzquierdo = new System.Windows.Forms.Panel();
            this.panBotones = new System.Windows.Forms.Panel();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.listRobots = new System.Windows.Forms.ListView();
            this.splitDerecho = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrarTexto = new System.Windows.Forms.Button();
            this.cboMensajes = new System.Windows.Forms.ComboBox();
            this.lblMostrarDesde = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibCamara = new Emgu.CV.UI.ImageBox();
            this.panIzquierdo.SuspendLayout();
            this.panBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDerecho)).BeginInit();
            this.splitDerecho.Panel1.SuspendLayout();
            this.splitDerecho.Panel2.SuspendLayout();
            this.splitDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara)).BeginInit();
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
            this.btnIniciarParar.Image = global::SimuladorV2V.Properties.Resources.play_icon;
            this.btnIniciarParar.Location = new System.Drawing.Point(156, 12);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(42, 42);
            this.btnIniciarParar.TabIndex = 3;
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Image = global::SimuladorV2V.Properties.Resources.route_icon;
            this.btnRutas.Location = new System.Drawing.Point(108, 12);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(42, 42);
            this.btnRutas.TabIndex = 2;
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::SimuladorV2V.Properties.Resources.delete_icon;
            this.btnEliminar.Location = new System.Drawing.Point(60, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(42, 42);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SimuladorV2V.Properties.Resources.add_icon;
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(42, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
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
            this.splitDerecho.Panel1.Controls.Add(this.ibCamara);
            // 
            // splitDerecho.Panel2
            // 
            this.splitDerecho.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitDerecho.Panel2.Controls.Add(this.button1);
            this.splitDerecho.Panel2.Controls.Add(this.btnBorrarTexto);
            this.splitDerecho.Panel2.Controls.Add(this.cboMensajes);
            this.splitDerecho.Panel2.Controls.Add(this.lblMostrarDesde);
            this.splitDerecho.Panel2.Controls.Add(this.textBox1);
            this.splitDerecho.Size = new System.Drawing.Size(919, 661);
            this.splitDerecho.SplitterDistance = 485;
            this.splitDerecho.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(3, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(906, 125);
            this.textBox1.TabIndex = 0;
            // 
            // ibCamara
            // 
            this.ibCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibCamara.Location = new System.Drawing.Point(0, 12);
            this.ibCamara.Name = "ibCamara";
            this.ibCamara.Size = new System.Drawing.Size(911, 461);
            this.ibCamara.TabIndex = 2;
            this.ibCamara.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.ibCamara)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMostrarDesde;
        private System.Windows.Forms.ComboBox cboMensajes;
        private System.Windows.Forms.Button btnBorrarTexto;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox ibCamara;
    }
}