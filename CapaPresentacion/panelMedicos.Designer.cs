using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class panelMedicos
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
            labelMedicos = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnAgregarMedico = new Button();
            btnQuitarFiltro = new Button();
            btnBuscarMedico = new Button();
            label2 = new Label();
            textBoxMedico = new TextBox();
            label1 = new Label();
            panelInfoMedico = new Panel();
            labelInformacionMedico = new Label();
            dgvInformacionMedicos = new DataGridView();
            panelCitasMedicos = new Panel();
            labelHistorialCitaMedicos = new Label();
            dgvHistorialCitasMedico = new DataGridView();
            panelContenedorMedicos = new Panel();
            panel1.SuspendLayout();
            panelInfoMedico.SuspendLayout();
            ((ISupportInitialize)dgvInformacionMedicos).BeginInit();
            panelCitasMedicos.SuspendLayout();
            ((ISupportInitialize)dgvHistorialCitasMedico).BeginInit();
            panelContenedorMedicos.SuspendLayout();
            SuspendLayout();
            // 
            // labelMedicos
            // 
            labelMedicos.AutoSize = true;
            labelMedicos.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMedicos.Location = new Point(22, 21);
            labelMedicos.Name = "labelMedicos";
            labelMedicos.Size = new Size(100, 27);
            labelMedicos.TabIndex = 1;
            labelMedicos.Text = "Médicos";
            labelMedicos.TextAlign = ContentAlignment.TopRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnAgregarMedico);
            panel1.Controls.Add(btnQuitarFiltro);
            panel1.Controls.Add(btnBuscarMedico);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxMedico);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelMedicos);
            panel1.Location = new Point(18, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 130);
            panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // btnAgregarMedico
            // 
            btnAgregarMedico.Location = new Point(664, 92);
            btnAgregarMedico.Margin = new Padding(2);
            btnAgregarMedico.Name = "btnAgregarMedico";
            btnAgregarMedico.Size = new Size(107, 28);
            btnAgregarMedico.TabIndex = 14;
            btnAgregarMedico.Text = "Agregar Médico";
            btnAgregarMedico.UseVisualStyleBackColor = true;
            btnAgregarMedico.Click += btnAgregarMedico_Click;
            // 
            // btnQuitarFiltro
            // 
            btnQuitarFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitarFiltro.Location = new Point(544, 95);
            btnQuitarFiltro.Name = "btnQuitarFiltro";
            btnQuitarFiltro.Size = new Size(97, 23);
            btnQuitarFiltro.TabIndex = 13;
            btnQuitarFiltro.Text = "Quitar Filtro";
            btnQuitarFiltro.UseVisualStyleBackColor = true;
            btnQuitarFiltro.Click += btnQuitarFiltro_Click;
            // 
            // btnBuscarMedico
            // 
            btnBuscarMedico.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarMedico.Location = new Point(451, 95);
            btnBuscarMedico.Name = "btnBuscarMedico";
            btnBuscarMedico.Size = new Size(75, 23);
            btnBuscarMedico.TabIndex = 8;
            btnBuscarMedico.Text = "Filtrar";
            btnBuscarMedico.UseVisualStyleBackColor = true;
            btnBuscarMedico.Click += btnBuscarMedico_Click;
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
            // textBoxMedico
            // 
            textBoxMedico.Location = new Point(82, 95);
            textBoxMedico.Name = "textBoxMedico";
            textBoxMedico.Size = new Size(145, 23);
            textBoxMedico.TabIndex = 5;
            textBoxMedico.TextChanged += textBoxMedico_TextChanged;
            textBoxMedico.KeyDown += textBoxMedico_KeyDown;
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
            // panelInfoMedico
            // 
            panelInfoMedico.BackColor = Color.White;
            panelInfoMedico.BorderStyle = BorderStyle.Fixed3D;
            panelInfoMedico.Controls.Add(labelInformacionMedico);
            panelInfoMedico.Controls.Add(dgvInformacionMedicos);
            panelInfoMedico.Location = new Point(20, 206);
            panelInfoMedico.Name = "panelInfoMedico";
            panelInfoMedico.Size = new Size(803, 134);
            panelInfoMedico.TabIndex = 12;
            panelInfoMedico.Paint += panelInfoMedico_Paint;
            // 
            // labelInformacionMedico
            // 
            labelInformacionMedico.AutoSize = true;
            labelInformacionMedico.ForeColor = SystemColors.ControlDarkDark;
            labelInformacionMedico.Location = new Point(3, 4);
            labelInformacionMedico.Name = "labelInformacionMedico";
            labelInformacionMedico.Size = new Size(134, 15);
            labelInformacionMedico.TabIndex = 12;
            labelInformacionMedico.Text = "Información del médico";
            // 
            // dgvInformacionMedicos
            // 
            dgvInformacionMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformacionMedicos.Dock = DockStyle.Bottom;
            dgvInformacionMedicos.Location = new Point(0, 23);
            dgvInformacionMedicos.Name = "dgvInformacionMedicos";
            dgvInformacionMedicos.RowHeadersWidth = 62;
            dgvInformacionMedicos.Size = new Size(799, 107);
            dgvInformacionMedicos.TabIndex = 8;
            dgvInformacionMedicos.CellClick += dgvInformacionMedicos_CellClick;
            dgvInformacionMedicos.CellContentClick += dgvInformacionMedicos_CellContentClick;
            // 
            // panelCitasMedicos
            // 
            panelCitasMedicos.BackColor = Color.White;
            panelCitasMedicos.BorderStyle = BorderStyle.Fixed3D;
            panelCitasMedicos.Controls.Add(labelHistorialCitaMedicos);
            panelCitasMedicos.Controls.Add(dgvHistorialCitasMedico);
            panelCitasMedicos.Location = new Point(20, 362);
            panelCitasMedicos.Name = "panelCitasMedicos";
            panelCitasMedicos.Size = new Size(803, 134);
            panelCitasMedicos.TabIndex = 13;
            // 
            // labelHistorialCitaMedicos
            // 
            labelHistorialCitaMedicos.AutoSize = true;
            labelHistorialCitaMedicos.ForeColor = SystemColors.ControlDarkDark;
            labelHistorialCitaMedicos.Location = new Point(3, 4);
            labelHistorialCitaMedicos.Name = "labelHistorialCitaMedicos";
            labelHistorialCitaMedicos.Size = new Size(94, 15);
            labelHistorialCitaMedicos.TabIndex = 12;
            labelHistorialCitaMedicos.Text = "Historial de citas";
            // 
            // dgvHistorialCitasMedico
            // 
            dgvHistorialCitasMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialCitasMedico.Dock = DockStyle.Bottom;
            dgvHistorialCitasMedico.Location = new Point(0, 23);
            dgvHistorialCitasMedico.Name = "dgvHistorialCitasMedico";
            dgvHistorialCitasMedico.RowHeadersWidth = 62;
            dgvHistorialCitasMedico.Size = new Size(799, 107);
            dgvHistorialCitasMedico.TabIndex = 8;
            dgvHistorialCitasMedico.CellContentClick += dgvHistorialCitasMedico_CellContentClick;
            // 
            // panelContenedorMedicos
            // 
            panelContenedorMedicos.AutoSize = true;
            panelContenedorMedicos.Controls.Add(panel1);
            panelContenedorMedicos.Controls.Add(panelCitasMedicos);
            panelContenedorMedicos.Controls.Add(panelInfoMedico);
            panelContenedorMedicos.Dock = DockStyle.Fill;
            panelContenedorMedicos.Location = new Point(0, 0);
            panelContenedorMedicos.Margin = new Padding(2);
            panelContenedorMedicos.Name = "panelContenedorMedicos";
            panelContenedorMedicos.Size = new Size(844, 547);
            panelContenedorMedicos.TabIndex = 14;
            // 
            // panelMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedorMedicos);
            Name = "panelMedicos";
            Size = new Size(844, 547);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInfoMedico.ResumeLayout(false);
            panelInfoMedico.PerformLayout();
            ((ISupportInitialize)dgvInformacionMedicos).EndInit();
            panelCitasMedicos.ResumeLayout(false);
            panelCitasMedicos.PerformLayout();
            ((ISupportInitialize)dgvHistorialCitasMedico).EndInit();
            panelContenedorMedicos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMedicos;
        private Panel panel1;
        private Label label1;
        private Button btnEditarMedicos;
        private Label label2;
        private TextBox textBoxMedico;
        private Button btnBuscarMedico;
        private Panel panelInfoPaciente;
        private Label label9;
        private DataGridView dgvInformacionPaciente;
        private Panel panel2;
        private Label label3;
        private DataGridView dgvHistorialCitasMedico;
        private Button btnQuitarFiltro;

        // Declaraciones añadidas para resolver los CS1061 (componentes referenciados con this.)
        private Panel panelInfoMedico;
        private Label labelInformacionMedico;
        private DataGridView dgvInformacionMedicos;
        private Panel panelCitasMedicos;
        private Label labelHistorialCitaMedicos;
        private Panel panelContenedorMedicos;
        private Button btnAgregarMedico;
        private TextBox textBox1;
    }
}
