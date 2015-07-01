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
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.listRobots = new System.Windows.Forms.ListView();
            this.splitDerecho = new System.Windows.Forms.SplitContainer();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.btnBorrarTexto = new System.Windows.Forms.Button();
            this.textBoxConsola = new System.Windows.Forms.TextBox();
            this.panIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDerecho)).BeginInit();
            this.splitDerecho.Panel1.SuspendLayout();
            this.splitDerecho.Panel2.SuspendLayout();
            this.splitDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // panIzquierdo
            // 
            this.panIzquierdo.Controls.Add(this.listRobots);
            this.panIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panIzquierdo.Name = "panIzquierdo";
            this.panIzquierdo.Size = new System.Drawing.Size(210, 661);
            this.panIzquierdo.TabIndex = 0;
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Image = global::EmuladorV2I.Properties.Resources.play_icon;
            this.btnIniciarParar.Location = new System.Drawing.Point(148, 5);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(42, 42);
            this.btnIniciarParar.TabIndex = 3;
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Image = global::EmuladorV2I.Properties.Resources.route_icon;
            this.btnRutas.Location = new System.Drawing.Point(100, 5);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(42, 42);
            this.btnRutas.TabIndex = 2;
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::EmuladorV2I.Properties.Resources.delete_icon;
            this.btnEliminar.Location = new System.Drawing.Point(52, 5);
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
            this.btnNuevo.Location = new System.Drawing.Point(4, 5);
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
            this.listRobots.Location = new System.Drawing.Point(12, 12);
            this.listRobots.Name = "listRobots";
            this.listRobots.Size = new System.Drawing.Size(186, 644);
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
            this.splitDerecho.Panel2.Controls.Add(this.btnIniciarParar);
            this.splitDerecho.Panel2.Controls.Add(this.btnBorrarTexto);
            this.splitDerecho.Panel2.Controls.Add(this.btnRutas);
            this.splitDerecho.Panel2.Controls.Add(this.textBoxConsola);
            this.splitDerecho.Panel2.Controls.Add(this.btnEliminar);
            this.splitDerecho.Panel2.Controls.Add(this.btnNuevo);
            this.splitDerecho.Size = new System.Drawing.Size(919, 661);
            this.splitDerecho.SplitterDistance = 448;
            this.splitDerecho.TabIndex = 1;
            // 
            // pbCamara
            // 
            this.pbCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCamara.Location = new System.Drawing.Point(6, 12);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(903, 430);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamara.TabIndex = 0;
            this.pbCamara.TabStop = false;
            // 
            // btnBorrarTexto
            // 
            this.btnBorrarTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarTexto.Location = new System.Drawing.Point(869, 5);
            this.btnBorrarTexto.Name = "btnBorrarTexto";
            this.btnBorrarTexto.Size = new System.Drawing.Size(42, 42);
            this.btnBorrarTexto.TabIndex = 3;
            this.btnBorrarTexto.UseVisualStyleBackColor = true;
            this.btnBorrarTexto.Click += new System.EventHandler(this.btnBorrarTexto_Click);
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
            this.textBoxConsola.Location = new System.Drawing.Point(6, 50);
            this.textBoxConsola.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxConsola.Multiline = true;
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.ReadOnly = true;
            this.textBoxConsola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsola.Size = new System.Drawing.Size(903, 154);
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.SplitContainer splitDerecho;
        private System.Windows.Forms.TextBox textBoxConsola;
        private System.Windows.Forms.Button btnBorrarTexto;
        private System.Windows.Forms.PictureBox pbCamara;
    }
}