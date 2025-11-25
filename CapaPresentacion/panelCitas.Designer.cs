namespace CapaPresentacion
{
    partial class panelCitas
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
            components = new System.ComponentModel.Container();
            pnlCitas = new Panel();
            txtIdPacienteBuscador = new TextBox();
            btnNuevaCita = new Button();
            labelFechaFinal = new Label();
            dateCitaFinal = new DateTimePicker();
            dateCitaInicio = new DateTimePicker();
            labelFechaInicio = new Label();
            txtPacienteNombre = new TextBox();
            btnBuscarCita = new Button();
            label1 = new Label();
            btnQuitarFiltroCitas = new Button();
            label2 = new Label();
            labelCitas = new Label();
            paneldgvCitas = new Panel();
            labelCitasdgv = new Label();
            dgvCitas = new DataGridView();
            panelContenedorCita = new Panel();
            label5 = new Label();
            idCita1 = new NumericUpDown();
            btnConfirmar = new Button();
            btnCancelarCita = new Button();
            btnCompletarCita = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlCitas.SuspendLayout();
            paneldgvCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            panelContenedorCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idCita1).BeginInit();
            SuspendLayout();
            // 
            // pnlCitas
            // 
            pnlCitas.BorderStyle = BorderStyle.Fixed3D;
            pnlCitas.Controls.Add(txtIdPacienteBuscador);
            pnlCitas.Controls.Add(btnNuevaCita);
            pnlCitas.Controls.Add(labelFechaFinal);
            pnlCitas.Controls.Add(dateCitaFinal);
            pnlCitas.Controls.Add(dateCitaInicio);
            pnlCitas.Controls.Add(labelFechaInicio);
            pnlCitas.Controls.Add(txtPacienteNombre);
            pnlCitas.Controls.Add(btnBuscarCita);
            pnlCitas.Controls.Add(label1);
            pnlCitas.Controls.Add(btnQuitarFiltroCitas);
            pnlCitas.Controls.Add(label2);
            pnlCitas.Controls.Add(labelCitas);
            pnlCitas.Location = new Point(18, 51);
            pnlCitas.Name = "pnlCitas";
            pnlCitas.Size = new Size(805, 130);
            pnlCitas.TabIndex = 1;
            // 
            // txtIdPacienteBuscador
            // 
            txtIdPacienteBuscador.Location = new Point(264, 94);
            txtIdPacienteBuscador.Name = "txtIdPacienteBuscador";
            txtIdPacienteBuscador.Size = new Size(171, 23);
            txtIdPacienteBuscador.TabIndex = 11;
            txtIdPacienteBuscador.KeyDown += txtIdPacienteBuscador_KeyDown;
            // 
            // btnNuevaCita
            // 
            btnNuevaCita.Location = new Point(671, 95);
            btnNuevaCita.Name = "btnNuevaCita";
            btnNuevaCita.Size = new Size(75, 23);
            btnNuevaCita.TabIndex = 10;
            btnNuevaCita.Text = "Nueva Cita";
            btnNuevaCita.UseVisualStyleBackColor = true;
            btnNuevaCita.Click += btnNuevaCita_Click;
            // 
            // labelFechaFinal
            // 
            labelFechaFinal.AutoSize = true;
            labelFechaFinal.Location = new Point(15, 97);
            labelFechaFinal.Name = "labelFechaFinal";
            labelFechaFinal.Size = new Size(66, 15);
            labelFechaFinal.TabIndex = 9;
            labelFechaFinal.Text = "Fecha Final";
            // 
            // dateCitaFinal
            // 
            dateCitaFinal.Format = DateTimePickerFormat.Short;
            dateCitaFinal.Location = new Point(94, 93);
            dateCitaFinal.Name = "dateCitaFinal";
            dateCitaFinal.Size = new Size(98, 23);
            dateCitaFinal.TabIndex = 8;
            // 
            // dateCitaInicio
            // 
            dateCitaInicio.Format = DateTimePickerFormat.Short;
            dateCitaInicio.Location = new Point(94, 60);
            dateCitaInicio.Name = "dateCitaInicio";
            dateCitaInicio.Size = new Size(98, 23);
            dateCitaInicio.TabIndex = 7;
            dateCitaInicio.ValueChanged += dateCitaInicio_ValueChanged;
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Location = new Point(15, 66);
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(73, 15);
            labelFechaInicio.TabIndex = 6;
            labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // txtPacienteNombre
            // 
            txtPacienteNombre.Location = new Point(264, 66);
            txtPacienteNombre.Name = "txtPacienteNombre";
            txtPacienteNombre.Size = new Size(171, 23);
            txtPacienteNombre.TabIndex = 7;
            txtPacienteNombre.KeyDown += txtPacienteNombre_KeyDown;
            // 
            // btnBuscarCita
            // 
            btnBuscarCita.Location = new Point(476, 95);
            btnBuscarCita.Name = "btnBuscarCita";
            btnBuscarCita.Size = new Size(75, 23);
            btnBuscarCita.TabIndex = 5;
            btnBuscarCita.Text = "Filtrar";
            btnBuscarCita.UseVisualStyleBackColor = true;
            btnBuscarCita.Click += btnBuscarCita_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 69);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Paciente:";
            // 
            // btnQuitarFiltroCitas
            // 
            btnQuitarFiltroCitas.Location = new Point(569, 95);
            btnQuitarFiltroCitas.Name = "btnQuitarFiltroCitas";
            btnQuitarFiltroCitas.Size = new Size(86, 23);
            btnQuitarFiltroCitas.TabIndex = 4;
            btnQuitarFiltroCitas.Text = "Quitar Filtro";
            btnQuitarFiltroCitas.UseVisualStyleBackColor = true;
            btnQuitarFiltroCitas.Click += btnQuitarFiltroCitas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 99);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Cédula:";
            label2.Click += label2_Click;
            // 
            // labelCitas
            // 
            labelCitas.AutoSize = true;
            labelCitas.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCitas.Location = new Point(22, 21);
            labelCitas.Name = "labelCitas";
            labelCitas.Size = new Size(66, 27);
            labelCitas.TabIndex = 0;
            labelCitas.Text = "Citas";
            // 
            // paneldgvCitas
            // 
            paneldgvCitas.BackColor = Color.White;
            paneldgvCitas.BorderStyle = BorderStyle.Fixed3D;
            paneldgvCitas.Controls.Add(labelCitasdgv);
            paneldgvCitas.Controls.Add(dgvCitas);
            paneldgvCitas.Location = new Point(20, 206);
            paneldgvCitas.Name = "paneldgvCitas";
            paneldgvCitas.Size = new Size(531, 300);
            paneldgvCitas.TabIndex = 3;
            // 
            // labelCitasdgv
            // 
            labelCitasdgv.AutoSize = true;
            labelCitasdgv.BackColor = Color.Transparent;
            labelCitasdgv.ForeColor = SystemColors.ControlDarkDark;
            labelCitasdgv.Location = new Point(3, 6);
            labelCitasdgv.Name = "labelCitasdgv";
            labelCitasdgv.Size = new Size(33, 15);
            labelCitasdgv.TabIndex = 1;
            labelCitasdgv.Text = "Citas";
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Dock = DockStyle.Bottom;
            dgvCitas.Location = new Point(0, 28);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(527, 268);
            dgvCitas.TabIndex = 0;
            dgvCitas.CellClick += dgvCitas_CellClick;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // panelContenedorCita
            // 
            panelContenedorCita.Controls.Add(label5);
            panelContenedorCita.Controls.Add(idCita1);
            panelContenedorCita.Controls.Add(btnConfirmar);
            panelContenedorCita.Controls.Add(btnCancelarCita);
            panelContenedorCita.Controls.Add(btnCompletarCita);
            panelContenedorCita.Controls.Add(label3);
            panelContenedorCita.Controls.Add(textBox3);
            panelContenedorCita.Controls.Add(textBox2);
            panelContenedorCita.Controls.Add(label4);
            panelContenedorCita.Controls.Add(pnlCitas);
            panelContenedorCita.Controls.Add(paneldgvCitas);
            panelContenedorCita.Dock = DockStyle.Fill;
            panelContenedorCita.Location = new Point(0, 0);
            panelContenedorCita.Name = "panelContenedorCita";
            panelContenedorCita.Size = new Size(844, 547);
            panelContenedorCita.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(605, 250);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 15;
            label5.Text = "ID:";
            // 
            // idCita1
            // 
            idCita1.Location = new Point(632, 242);
            idCita1.Name = "idCita1";
            idCita1.Size = new Size(103, 23);
            idCita1.TabIndex = 14;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(575, 397);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.Location = new Point(746, 397);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(75, 23);
            btnCancelarCita.TabIndex = 12;
            btnCancelarCita.Text = "Cancelar";
            btnCancelarCita.UseVisualStyleBackColor = true;
            btnCancelarCita.Click += btnCancelarCita_Click;
            // 
            // btnCompletarCita
            // 
            btnCompletarCita.Location = new Point(660, 397);
            btnCompletarCita.Name = "btnCompletarCita";
            btnCompletarCita.Size = new Size(75, 23);
            btnCompletarCita.TabIndex = 11;
            btnCompletarCita.Text = "Completar";
            btnCompletarCita.UseVisualStyleBackColor = true;
            btnCompletarCita.Click += btnCompletarCita_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 337);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Motivo: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(632, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(632, 329);
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(577, 291);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Médico: ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedorCita);
            Name = "panelCitas";
            Size = new Size(844, 547);
            pnlCitas.ResumeLayout(false);
            pnlCitas.PerformLayout();
            paneldgvCitas.ResumeLayout(false);
            paneldgvCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            panelContenedorCita.ResumeLayout(false);
            panelContenedorCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idCita1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCitas;
        private Label labelFechaInicio;
        private Button btnBuscarCita;
        private Button btnQuitarFiltroCitas;
        private Label label2;
        private Label labelCitas;
        private Panel paneldgvCitas;
        private Label labelCitasdgv;
        private DataGridView dgvCitas;
        private DateTimePicker dateCitaFinal;
        private DateTimePicker dateCitaInicio;
        private Label labelFechaFinal;
        private Button btnNuevaCita;
        private Panel panelContenedorCita;
        private TextBox txtIdPacienteBuscador;
        private Label label4;
        private Label label1;
        private Button btnConfirmar;
        private Button btnCancelarCita;
        private Button btnCompletarCita;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtPacienteNombre;
        private ContextMenuStrip contextMenuStrip1;
        private Label label5;
        private NumericUpDown idCita1;
    }
}
