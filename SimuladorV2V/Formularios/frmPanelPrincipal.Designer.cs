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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panCamara = new System.Windows.Forms.Panel();
            this.panBotoneraCamara = new System.Windows.Forms.Panel();
            this.chkIntersecciones = new System.Windows.Forms.CheckBox();
            this.chkCorregirPerspectiva = new System.Windows.Forms.CheckBox();
            this.panRobots = new System.Windows.Forms.Panel();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gvRobots = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTemperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panCamara.SuspendLayout();
            this.panBotoneraCamara.SuspendLayout();
            this.panRobots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRobots)).BeginInit();
            this.SuspendLayout();
            // 
            // panCamara
            // 
            this.panCamara.Controls.Add(this.pbCamara);
            this.panCamara.Controls.Add(this.panBotoneraCamara);
            resources.ApplyResources(this.panCamara, "panCamara");
            this.panCamara.Name = "panCamara";
            // 
            // panBotoneraCamara
            // 
            this.panBotoneraCamara.Controls.Add(this.chkIntersecciones);
            this.panBotoneraCamara.Controls.Add(this.chkCorregirPerspectiva);
            this.panBotoneraCamara.Controls.Add(this.btnEliminar);
            this.panBotoneraCamara.Controls.Add(this.btnIniciarParar);
            this.panBotoneraCamara.Controls.Add(this.btnNuevo);
            resources.ApplyResources(this.panBotoneraCamara, "panBotoneraCamara");
            this.panBotoneraCamara.Name = "panBotoneraCamara";
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
            this.chkCorregirPerspectiva.Checked = true;
            this.chkCorregirPerspectiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCorregirPerspectiva.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.chkCorregirPerspectiva.Name = "chkCorregirPerspectiva";
            this.chkCorregirPerspectiva.UseVisualStyleBackColor = true;
            // 
            // panRobots
            // 
            this.panRobots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panRobots.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panRobots.Controls.Add(this.gvRobots);
            resources.ApplyResources(this.panRobots, "panRobots");
            this.panRobots.Name = "panRobots";
            // 
            // pbCamara
            // 
            resources.ApplyResources(this.pbCamara, "pbCamara");
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Image = global::EmuladorV2I.Properties.Resources.delete_icon;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Image = global::EmuladorV2I.Properties.Resources.play_icon;
            resources.ApplyResources(this.btnIniciarParar, "btnIniciarParar");
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnNuevo, "btnNuevo");
            this.btnNuevo.Image = global::EmuladorV2I.Properties.Resources.add_icon;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gvRobots
            // 
            this.gvRobots.AllowUserToAddRows = false;
            this.gvRobots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.colId,
            this.colDescripcion,
            this.colModo,
            this.colTemperatura,
            this.colBateria,
            this.colQuitar});
            resources.ApplyResources(this.gvRobots, "gvRobots");
            this.gvRobots.Name = "gvRobots";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRobots.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colDescripcion
            // 
            resources.ApplyResources(this.colDescripcion, "colDescripcion");
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colModo
            // 
            resources.ApplyResources(this.colModo, "colModo");
            this.colModo.Items.AddRange(new object[] {
            "Libre",
            "Averiado"});
            this.colModo.Name = "colModo";
            // 
            // colTemperatura
            // 
            resources.ApplyResources(this.colTemperatura, "colTemperatura");
            this.colTemperatura.Name = "colTemperatura";
            // 
            // colBateria
            // 
            resources.ApplyResources(this.colBateria, "colBateria");
            this.colBateria.Name = "colBateria";
            // 
            // colQuitar
            // 
            resources.ApplyResources(this.colQuitar, "colQuitar");
            this.colQuitar.Name = "colQuitar";
            // 
            // frmPanelPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panCamara);
            this.Controls.Add(this.panRobots);
            this.Name = "frmPanelPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPanelPrincipal_Load);
            this.panCamara.ResumeLayout(false);
            this.panBotoneraCamara.ResumeLayout(false);
            this.panBotoneraCamara.PerformLayout();
            this.panRobots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRobots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Panel panCamara;
        private System.Windows.Forms.Panel panRobots;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panBotoneraCamara;
        private System.Windows.Forms.CheckBox chkCorregirPerspectiva;
        private System.Windows.Forms.CheckBox chkIntersecciones;
        private System.Windows.Forms.DataGridView gvRobots;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn colModo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBateria;
        private System.Windows.Forms.DataGridViewButtonColumn colQuitar;
    }
}