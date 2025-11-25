namespace CapaPresentacion
{
    partial class panelClinicas
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
            pnlClinicas = new Panel();
            btnAgregarClinica = new Button();
            labelClinica = new Label();
            btnBuscarClinica = new Button();
            btnQuitarFiltroClinica = new Button();
            labelIdClinica = new Label();
            filtroIdClinica = new NumericUpDown();
            textBoxNombreClinicas = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            labelClinicas = new Label();
            dgvClinicas = new DataGridView();
            panelContenedorClinica = new Panel();
            pnlClinicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filtroIdClinica).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClinicas).BeginInit();
            panelContenedorClinica.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClinicas
            // 
            pnlClinicas.BorderStyle = BorderStyle.Fixed3D;
            pnlClinicas.Controls.Add(btnAgregarClinica);
            pnlClinicas.Controls.Add(labelClinica);
            pnlClinicas.Controls.Add(btnBuscarClinica);
            pnlClinicas.Controls.Add(btnQuitarFiltroClinica);
            pnlClinicas.Controls.Add(labelIdClinica);
            pnlClinicas.Controls.Add(filtroIdClinica);
            pnlClinicas.Controls.Add(textBoxNombreClinicas);
            pnlClinicas.Controls.Add(label1);
            pnlClinicas.Location = new Point(18, 51);
            pnlClinicas.Name = "pnlClinicas";
            pnlClinicas.Size = new Size(805, 130);
            pnlClinicas.TabIndex = 0;
            // 
            // btnAgregarClinica
            // 
            btnAgregarClinica.Location = new Point(672, 95);
            btnAgregarClinica.Name = "btnAgregarClinica";
            btnAgregarClinica.Size = new Size(105, 23);
            btnAgregarClinica.TabIndex = 7;
            btnAgregarClinica.Text = "Agregar Clínica";
            btnAgregarClinica.UseVisualStyleBackColor = true;
            btnAgregarClinica.Click += btnAgregarClinica_Click;
            // 
            // labelClinica
            // 
            labelClinica.AutoSize = true;
            labelClinica.Location = new Point(22, 98);
            labelClinica.Name = "labelClinica";
            labelClinica.Size = new Size(54, 15);
            labelClinica.TabIndex = 6;
            labelClinica.Text = "Nombre:";
            // 
            // btnBuscarClinica
            // 
            btnBuscarClinica.Location = new Point(451, 95);
            btnBuscarClinica.Name = "btnBuscarClinica";
            btnBuscarClinica.Size = new Size(75, 23);
            btnBuscarClinica.TabIndex = 5;
            btnBuscarClinica.Text = "Filtrar";
            btnBuscarClinica.UseVisualStyleBackColor = true;
            btnBuscarClinica.Click += btnBuscarClinica_Click;
            // 
            // btnQuitarFiltroClinica
            // 
            btnQuitarFiltroClinica.Location = new Point(544, 95);
            btnQuitarFiltroClinica.Name = "btnQuitarFiltroClinica";
            btnQuitarFiltroClinica.Size = new Size(103, 23);
            btnQuitarFiltroClinica.TabIndex = 4;
            btnQuitarFiltroClinica.Text = "Quitar Filtro";
            btnQuitarFiltroClinica.UseVisualStyleBackColor = true;
            btnQuitarFiltroClinica.Click += btnQuitarFiltroClinica_Click;
            // 
            // labelIdClinica
            // 
            labelIdClinica.AutoSize = true;
            labelIdClinica.Location = new Point(243, 98);
            labelIdClinica.Name = "labelIdClinica";
            labelIdClinica.Size = new Size(21, 15);
            labelIdClinica.TabIndex = 3;
            labelIdClinica.Text = "ID:";
            // 
            // filtroIdClinica
            // 
            filtroIdClinica.Location = new Point(270, 95);
            filtroIdClinica.Name = "filtroIdClinica";
            filtroIdClinica.Size = new Size(147, 23);
            filtroIdClinica.TabIndex = 2;
            filtroIdClinica.ValueChanged += filtroIdClinica_ValueChanged;
            filtroIdClinica.KeyDown += filtroIdClinica_KeyDown;
            // 
            // textBoxNombreClinicas
            // 
            textBoxNombreClinicas.Location = new Point(82, 95);
            textBoxNombreClinicas.Name = "textBoxNombreClinicas";
            textBoxNombreClinicas.Size = new Size(147, 23);
            textBoxNombreClinicas.TabIndex = 1;
            textBoxNombreClinicas.TextChanged += textBoxNombreClinicas_TextChanged;
            textBoxNombreClinicas.KeyDown += textBoxNombreClinicas_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 0;
            label1.Text = "Clínicas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(labelClinicas);
            panel3.Controls.Add(dgvClinicas);
            panel3.Location = new Point(20, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 300);
            panel3.TabIndex = 2;
            // 
            // labelClinicas
            // 
            labelClinicas.AutoSize = true;
            labelClinicas.BackColor = Color.Transparent;
            labelClinicas.ForeColor = SystemColors.ControlDarkDark;
            labelClinicas.Location = new Point(3, 6);
            labelClinicas.Name = "labelClinicas";
            labelClinicas.Size = new Size(48, 15);
            labelClinicas.TabIndex = 1;
            labelClinicas.Text = "Clínicas";
            // 
            // dgvClinicas
            // 
            dgvClinicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinicas.Dock = DockStyle.Bottom;
            dgvClinicas.Location = new Point(0, 28);
            dgvClinicas.Name = "dgvClinicas";
            dgvClinicas.RowHeadersWidth = 62;
            dgvClinicas.Size = new Size(799, 268);
            dgvClinicas.TabIndex = 0;
            dgvClinicas.CellClick += dgvClinicas_CellClick;
            dgvClinicas.CellContentClick += dgvClinicas_CellContentClick;
            // 
            // panelContenedorClinica
            // 
            panelContenedorClinica.Controls.Add(pnlClinicas);
            panelContenedorClinica.Controls.Add(panel3);
            panelContenedorClinica.Dock = DockStyle.Fill;
            panelContenedorClinica.Location = new Point(0, 0);
            panelContenedorClinica.Name = "panelContenedorClinica";
            panelContenedorClinica.Size = new Size(844, 547);
            panelContenedorClinica.TabIndex = 3;
            // 
            // panelClinicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedorClinica);
            Name = "panelClinicas";
            Size = new Size(844, 547);
            pnlClinicas.ResumeLayout(false);
            pnlClinicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filtroIdClinica).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClinicas).EndInit();
            panelContenedorClinica.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClinicas;
        private Panel panel3;
        private Label labelClinicas;
        private DataGridView dgvClinicas;
        private Label label1;
        private Button btnBuscarClinica;
        private Button btnQuitarFiltroClinica;
        private Label labelIdClinica;
        private NumericUpDown filtroIdClinica;
        private TextBox textBoxNombreClinicas;
        private Label labelClinica;
        private Panel panelContenedorClinica;
        private Button btnAgregarClinica;
    }
}
