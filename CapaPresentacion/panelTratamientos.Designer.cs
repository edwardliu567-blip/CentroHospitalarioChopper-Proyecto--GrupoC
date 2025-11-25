namespace CapaPresentacion
{
    partial class panelTratamientos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTratamientos = new Panel();
            btnAgregarTrata = new Button();
            labelNombreTrata = new Label();
            btnBuscarTrata = new Button();
            textBoxNombreTrata = new TextBox();
            btnQuitarFiltroTrata = new Button();
            fitlroIdTrata = new Label();
            filtroIdTrata = new NumericUpDown();
            labelTratamientos = new Label();
            paneldgvTrata = new Panel();
            labelTratadgv = new Label();
            dgvTrata = new DataGridView();
            panelContenedorTratamiento = new Panel();
            pnlTratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filtroIdTrata).BeginInit();
            paneldgvTrata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrata).BeginInit();
            panelContenedorTratamiento.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTratamientos
            // 
            pnlTratamientos.BorderStyle = BorderStyle.Fixed3D;
            pnlTratamientos.Controls.Add(btnAgregarTrata);
            pnlTratamientos.Controls.Add(labelNombreTrata);
            pnlTratamientos.Controls.Add(btnBuscarTrata);
            pnlTratamientos.Controls.Add(textBoxNombreTrata);
            pnlTratamientos.Controls.Add(btnQuitarFiltroTrata);
            pnlTratamientos.Controls.Add(fitlroIdTrata);
            pnlTratamientos.Controls.Add(filtroIdTrata);
            pnlTratamientos.Controls.Add(labelTratamientos);
            pnlTratamientos.Location = new Point(18, 51);
            pnlTratamientos.Name = "pnlTratamientos";
            pnlTratamientos.Size = new Size(805, 130);
            pnlTratamientos.TabIndex = 3;
            // 
            // btnAgregarTrata
            // 
            btnAgregarTrata.Location = new Point(657, 95);
            btnAgregarTrata.Name = "btnAgregarTrata";
            btnAgregarTrata.Size = new Size(129, 23);
            btnAgregarTrata.TabIndex = 9;
            btnAgregarTrata.Text = "Agregar Tratamiento";
            btnAgregarTrata.UseVisualStyleBackColor = true;
            btnAgregarTrata.Click += btnAgregarTrata_Click;
            // 
            // labelNombreTrata
            // 
            labelNombreTrata.AutoSize = true;
            labelNombreTrata.Location = new Point(22, 98);
            labelNombreTrata.Name = "labelNombreTrata";
            labelNombreTrata.Size = new Size(54, 15);
            labelNombreTrata.TabIndex = 8;
            labelNombreTrata.Text = "Nombre:";
            // 
            // btnBuscarTrata
            // 
            btnBuscarTrata.Location = new Point(451, 95);
            btnBuscarTrata.Name = "btnBuscarTrata";
            btnBuscarTrata.Size = new Size(75, 23);
            btnBuscarTrata.TabIndex = 5;
            btnBuscarTrata.Text = "Filtrar";
            btnBuscarTrata.UseVisualStyleBackColor = true;
            btnBuscarTrata.Click += btnBuscarTrata_Click;
            // 
            // textBoxNombreTrata
            // 
            textBoxNombreTrata.Location = new Point(82, 95);
            textBoxNombreTrata.Name = "textBoxNombreTrata";
            textBoxNombreTrata.Size = new Size(147, 23);
            textBoxNombreTrata.TabIndex = 7;
            textBoxNombreTrata.KeyDown += textBoxNombreTrata_KeyDown;
            // 
            // btnQuitarFiltroTrata
            // 
            btnQuitarFiltroTrata.Location = new Point(544, 95);
            btnQuitarFiltroTrata.Name = "btnQuitarFiltroTrata";
            btnQuitarFiltroTrata.Size = new Size(88, 23);
            btnQuitarFiltroTrata.TabIndex = 4;
            btnQuitarFiltroTrata.Text = "Quitar Filtro";
            btnQuitarFiltroTrata.UseVisualStyleBackColor = true;
            btnQuitarFiltroTrata.Click += btnQuitarFiltroTrata_Click_1;
            // 
            // fitlroIdTrata
            // 
            fitlroIdTrata.AutoSize = true;
            fitlroIdTrata.Location = new Point(243, 98);
            fitlroIdTrata.Name = "fitlroIdTrata";
            fitlroIdTrata.Size = new Size(21, 15);
            fitlroIdTrata.TabIndex = 3;
            fitlroIdTrata.Text = "ID:";
            // 
            // filtroIdTrata
            // 
            filtroIdTrata.Location = new Point(270, 95);
            filtroIdTrata.Name = "filtroIdTrata";
            filtroIdTrata.Size = new Size(147, 23);
            filtroIdTrata.TabIndex = 2;
            filtroIdTrata.KeyDown += filtroIdTrata_KeyDown;
            // 
            // labelTratamientos
            // 
            labelTratamientos.AutoSize = true;
            labelTratamientos.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTratamientos.Location = new Point(22, 21);
            labelTratamientos.Name = "labelTratamientos";
            labelTratamientos.Size = new Size(151, 27);
            labelTratamientos.TabIndex = 0;
            labelTratamientos.Text = "Tratamientos";
            // 
            // paneldgvTrata
            // 
            paneldgvTrata.BackColor = Color.White;
            paneldgvTrata.BorderStyle = BorderStyle.Fixed3D;
            paneldgvTrata.Controls.Add(labelTratadgv);
            paneldgvTrata.Controls.Add(dgvTrata);
            paneldgvTrata.Location = new Point(20, 206);
            paneldgvTrata.Name = "paneldgvTrata";
            paneldgvTrata.Size = new Size(803, 300);
            paneldgvTrata.TabIndex = 5;
            // 
            // labelTratadgv
            // 
            labelTratadgv.AutoSize = true;
            labelTratadgv.BackColor = Color.Transparent;
            labelTratadgv.ForeColor = SystemColors.ControlDarkDark;
            labelTratadgv.Location = new Point(3, 6);
            labelTratadgv.Name = "labelTratadgv";
            labelTratadgv.Size = new Size(76, 15);
            labelTratadgv.TabIndex = 1;
            labelTratadgv.Text = "Tratamientos";
            // 
            // dgvTrata
            // 
            dgvTrata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrata.Dock = DockStyle.Bottom;
            dgvTrata.Location = new Point(0, 28);
            dgvTrata.Name = "dgvTrata";
            dgvTrata.RowHeadersWidth = 62;
            dgvTrata.Size = new Size(799, 268);
            dgvTrata.TabIndex = 0;
            dgvTrata.CellClick += dgvTrata_CellClick;
            dgvTrata.CellContentClick += dgvTrata_CellContentClick;
            // 
            // panelContenedorTratamiento
            // 
            panelContenedorTratamiento.Controls.Add(pnlTratamientos);
            panelContenedorTratamiento.Controls.Add(paneldgvTrata);
            panelContenedorTratamiento.Dock = DockStyle.Fill;
            panelContenedorTratamiento.Location = new Point(0, 0);
            panelContenedorTratamiento.Name = "panelContenedorTratamiento";
            panelContenedorTratamiento.Size = new Size(844, 547);
            panelContenedorTratamiento.TabIndex = 6;
            // 
            // panelTratamientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedorTratamiento);
            Name = "panelTratamientos";
            Size = new Size(844, 547);
            pnlTratamientos.ResumeLayout(false);
            pnlTratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filtroIdTrata).EndInit();
            paneldgvTrata.ResumeLayout(false);
            paneldgvTrata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrata).EndInit();
            panelContenedorTratamiento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTratamientos;
        private Label labelNombreTrata;
        private Button btnBuscarTrata;
        private TextBox textBoxNombreTrata;
        private Button btnQuitarFiltroTrata;
        private Label fitlroIdTrata;
        private NumericUpDown filtroIdTrata;
        private Label labelTratamientos;
        private Panel paneldgvTrata;
        private Label labelTratadgv;
        private DataGridView dgvTrata;
        private Panel panelContenedorTratamiento;
        private Button btnAgregarTrata;
    }
}
