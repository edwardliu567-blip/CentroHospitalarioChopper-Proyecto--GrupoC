namespace CapaPresentacion
{
    partial class panelPacientes
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnAgregarPaciente = new Button();
            btnQuitarFiltro = new Button();
            btnBuscarPaciente = new Button();
            label2 = new Label();
            textBoxPaciente = new TextBox();
            label1 = new Label();
            labelPacientes = new Label();
            panelInfoPaciente = new Panel();
            label3 = new Label();
            dgvInformacionPaciente = new DataGridView();
            panelCitasPaciente = new Panel();
            labelCitasPaciente = new Label();
            dgvCitasPacientes = new DataGridView();
            panelContenedorPacientes = new Panel();
            panel1.SuspendLayout();
            panelInfoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformacionPaciente).BeginInit();
            panelCitasPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasPacientes).BeginInit();
            panelContenedorPacientes.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnAgregarPaciente);
            panel1.Controls.Add(btnQuitarFiltro);
            panel1.Controls.Add(btnBuscarPaciente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxPaciente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelPacientes);
            panel1.Location = new Point(18, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 130);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 16;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Location = new Point(669, 94);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(113, 23);
            btnAgregarPaciente.TabIndex = 15;
            btnAgregarPaciente.Text = "Agregar paciente";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // btnQuitarFiltro
            // 
            btnQuitarFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitarFiltro.Location = new Point(544, 95);
            btnQuitarFiltro.Name = "btnQuitarFiltro";
            btnQuitarFiltro.Size = new Size(97, 23);
            btnQuitarFiltro.TabIndex = 14;
            btnQuitarFiltro.Text = "Quitar Filtro";
            btnQuitarFiltro.UseVisualStyleBackColor = true;
            btnQuitarFiltro.Click += btnQuitarFiltro_Click;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarPaciente.Location = new Point(451, 95);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(75, 23);
            btnBuscarPaciente.TabIndex = 8;
            btnBuscarPaciente.Text = "Filtrar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 98);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // textBoxPaciente
            // 
            textBoxPaciente.Location = new Point(82, 95);
            textBoxPaciente.Name = "textBoxPaciente";
            textBoxPaciente.Size = new Size(147, 23);
            textBoxPaciente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 98);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // labelPacientes
            // 
            labelPacientes.AutoSize = true;
            labelPacientes.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPacientes.Location = new Point(22, 21);
            labelPacientes.Name = "labelPacientes";
            labelPacientes.Size = new Size(117, 27);
            labelPacientes.TabIndex = 1;
            labelPacientes.Text = "Pacientes";
            labelPacientes.TextAlign = ContentAlignment.TopRight;
            // 
            // panelInfoPaciente
            // 
            panelInfoPaciente.BackColor = Color.White;
            panelInfoPaciente.BorderStyle = BorderStyle.Fixed3D;
            panelInfoPaciente.Controls.Add(label3);
            panelInfoPaciente.Controls.Add(dgvInformacionPaciente);
            panelInfoPaciente.Location = new Point(20, 206);
            panelInfoPaciente.Name = "panelInfoPaciente";
            panelInfoPaciente.Size = new Size(803, 134);
            panelInfoPaciente.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 12;
            label3.Text = "Información del paciente";
            // 
            // dgvInformacionPaciente
            // 
            dgvInformacionPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformacionPaciente.Dock = DockStyle.Bottom;
            dgvInformacionPaciente.Location = new Point(0, 23);
            dgvInformacionPaciente.Name = "dgvInformacionPaciente";
            dgvInformacionPaciente.Size = new Size(799, 107);
            dgvInformacionPaciente.TabIndex = 8;
            dgvInformacionPaciente.CellClick += dgvInformacionPaciente_CellClick;
            dgvInformacionPaciente.CellContentClick += dgvInformacionPaciente_CellContentClick;
            // 
            // panelCitasPaciente
            // 
            panelCitasPaciente.BackColor = Color.White;
            panelCitasPaciente.BorderStyle = BorderStyle.Fixed3D;
            panelCitasPaciente.Controls.Add(labelCitasPaciente);
            panelCitasPaciente.Controls.Add(dgvCitasPacientes);
            panelCitasPaciente.Location = new Point(20, 362);
            panelCitasPaciente.Name = "panelCitasPaciente";
            panelCitasPaciente.Size = new Size(803, 134);
            panelCitasPaciente.TabIndex = 12;
            // 
            // labelCitasPaciente
            // 
            labelCitasPaciente.AutoSize = true;
            labelCitasPaciente.ForeColor = SystemColors.ControlDarkDark;
            labelCitasPaciente.Location = new Point(3, 4);
            labelCitasPaciente.Name = "labelCitasPaciente";
            labelCitasPaciente.Size = new Size(94, 15);
            labelCitasPaciente.TabIndex = 12;
            labelCitasPaciente.Text = "Historial de citas";
            // 
            // dgvCitasPacientes
            // 
            dgvCitasPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasPacientes.Dock = DockStyle.Bottom;
            dgvCitasPacientes.Location = new Point(0, 23);
            dgvCitasPacientes.Name = "dgvCitasPacientes";
            dgvCitasPacientes.Size = new Size(799, 107);
            dgvCitasPacientes.TabIndex = 8;
            dgvCitasPacientes.CellContentClick += dgvCitasPacientes_CellContentClick;
            // 
            // panelContenedorPacientes
            // 
            panelContenedorPacientes.Controls.Add(panel1);
            panelContenedorPacientes.Controls.Add(panelCitasPaciente);
            panelContenedorPacientes.Controls.Add(panelInfoPaciente);
            panelContenedorPacientes.Dock = DockStyle.Fill;
            panelContenedorPacientes.Location = new Point(0, 0);
            panelContenedorPacientes.Name = "panelContenedorPacientes";
            panelContenedorPacientes.Size = new Size(844, 547);
            panelContenedorPacientes.TabIndex = 13;
            // 
            // panelPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedorPacientes);
            Name = "panelPacientes";
            Size = new Size(844, 547);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInfoPaciente.ResumeLayout(false);
            panelInfoPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformacionPaciente).EndInit();
            panelCitasPaciente.ResumeLayout(false);
            panelCitasPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasPacientes).EndInit();
            panelContenedorPacientes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBuscarPaciente;
        private Label label2;
        private TextBox textBoxPaciente;
        private Label label1;
        private Label labelPacientes;
        private Panel panelInfoPaciente;
        private Label label3;
        private DataGridView dgvInformacionPaciente;
        private Panel panelCitasPaciente;
        private Label labelCitasPaciente;
        private DataGridView dgvCitasPacientes;
        private Button btnQuitarFiltro;
        private Button btnAgregarPaciente;
        private Panel panelContenedorPacientes;
        private TextBox textBox1;
    }
}
