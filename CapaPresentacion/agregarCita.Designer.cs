namespace CapaPresentacion
{
    partial class agregarCita
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
            panelAgregarCita = new Panel();
            label10 = new Label();
            cmbAdminCita = new ComboBox();
            numericUpDownIDCita = new NumericUpDown();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            cmbSurcursalCita = new ComboBox();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            label9 = new Label();
            cmbMedicoCita = new ComboBox();
            txtNombrePacienteCita = new TextBox();
            label8 = new Label();
            txtMotivoCita = new TextBox();
            dtpHoraCita = new DateTimePicker();
            dtpFechaCita = new DateTimePicker();
            cmbTratamientoCita = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelAgregarCita = new Label();
            panelAgregarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDCita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelAgregarCita
            // 
            panelAgregarCita.BackColor = Color.PowderBlue;
            panelAgregarCita.BorderStyle = BorderStyle.Fixed3D;
            panelAgregarCita.Controls.Add(numericUpDownIDCita);
            panelAgregarCita.Controls.Add(label4);
            panelAgregarCita.Controls.Add(button3);
            panelAgregarCita.Controls.Add(button2);
            panelAgregarCita.Controls.Add(dataGridView1);
            panelAgregarCita.Controls.Add(label1);
            panelAgregarCita.Controls.Add(cmbSurcursalCita);
            panelAgregarCita.Controls.Add(textBox1);
            panelAgregarCita.Controls.Add(btnBuscar);
            panelAgregarCita.Controls.Add(label9);
            panelAgregarCita.Controls.Add(cmbMedicoCita);
            panelAgregarCita.Controls.Add(txtNombrePacienteCita);
            panelAgregarCita.Controls.Add(label8);
            panelAgregarCita.Controls.Add(txtMotivoCita);
            panelAgregarCita.Controls.Add(dtpHoraCita);
            panelAgregarCita.Controls.Add(dtpFechaCita);
            panelAgregarCita.Controls.Add(cmbTratamientoCita);
            panelAgregarCita.Controls.Add(button1);
            panelAgregarCita.Controls.Add(label7);
            panelAgregarCita.Controls.Add(label6);
            panelAgregarCita.Controls.Add(label5);
            panelAgregarCita.Controls.Add(label3);
            panelAgregarCita.Controls.Add(label2);
            panelAgregarCita.Controls.Add(labelAgregarCita);
            panelAgregarCita.Location = new Point(39, 49);
            panelAgregarCita.Name = "panelAgregarCita";
            panelAgregarCita.Size = new Size(760, 433);
            panelAgregarCita.TabIndex = 0;
            panelAgregarCita.Paint += panelAgregarCita_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(531, 23);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 33;
            label10.Text = "Administrador:";
            // 
            // cmbAdminCita
            // 
            cmbAdminCita.FormattingEnabled = true;
            cmbAdminCita.Location = new Point(620, 20);
            cmbAdminCita.Name = "cmbAdminCita";
            cmbAdminCita.Size = new Size(164, 23);
            cmbAdminCita.TabIndex = 32;
            cmbAdminCita.SelectedIndexChanged += cmbAdminCita_SelectedIndexChanged;
            // 
            // numericUpDownIDCita
            // 
            numericUpDownIDCita.Location = new Point(429, 110);
            numericUpDownIDCita.Name = "numericUpDownIDCita";
            numericUpDownIDCita.Size = new Size(75, 23);
            numericUpDownIDCita.TabIndex = 31;
            numericUpDownIDCita.ValueChanged += numericUpDownIDCita_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(429, 92);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 30;
            label4.Text = "ID";
            // 
            // button3
            // 
            button3.Location = new Point(429, 381);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 28;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(323, 381);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(429, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(314, 170);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 317);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 25;
            label1.Text = "Sucursal *";
            // 
            // cmbSurcursalCita
            // 
            cmbSurcursalCita.FormattingEnabled = true;
            cmbSurcursalCita.Location = new Point(246, 335);
            cmbSurcursalCita.Name = "cmbSurcursalCita";
            cmbSurcursalCita.Size = new Size(165, 23);
            cmbSurcursalCita.TabIndex = 24;
            cmbSurcursalCita.SelectedIndexChanged += cmbSurcursalCita_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 23;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(45, 139);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 257);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 21;
            label9.Text = "Médico *";
            // 
            // cmbMedicoCita
            // 
            cmbMedicoCita.FormattingEnabled = true;
            cmbMedicoCita.Location = new Point(246, 275);
            cmbMedicoCita.Name = "cmbMedicoCita";
            cmbMedicoCita.Size = new Size(165, 23);
            cmbMedicoCita.TabIndex = 20;
            cmbMedicoCita.SelectedIndexChanged += cmbMedicoCita_SelectedIndexChanged;
            // 
            // txtNombrePacienteCita
            // 
            txtNombrePacienteCita.Location = new Point(246, 94);
            txtNombrePacienteCita.Name = "txtNombrePacienteCita";
            txtNombrePacienteCita.Size = new Size(162, 23);
            txtNombrePacienteCita.TabIndex = 18;
            txtNombrePacienteCita.KeyDown += txtNombrePacienteCita_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 76);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 16;
            label8.Text = "Id Paciente:";
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(45, 275);
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(179, 23);
            txtMotivoCita.TabIndex = 12;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(246, 206);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.Size = new Size(162, 23);
            dtpHoraCita.TabIndex = 11;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.Location = new Point(45, 206);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(171, 23);
            dtpFechaCita.TabIndex = 10;
            // 
            // cmbTratamientoCita
            // 
            cmbTratamientoCita.FormattingEnabled = true;
            cmbTratamientoCita.Location = new Point(45, 335);
            cmbTratamientoCita.Name = "cmbTratamientoCita";
            cmbTratamientoCita.Size = new Size(179, 23);
            cmbTratamientoCita.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(211, 381);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 316);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 6;
            label7.Text = "Tratamiento *";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 188);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha de la cita *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 257);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Motivo *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 188);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Hora de la cita *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 76);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del paciente";
            // 
            // labelAgregarCita
            // 
            labelAgregarCita.AutoSize = true;
            labelAgregarCita.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgregarCita.Location = new Point(45, 29);
            labelAgregarCita.Name = "labelAgregarCita";
            labelAgregarCita.Size = new Size(124, 25);
            labelAgregarCita.TabIndex = 0;
            labelAgregarCita.Text = "Agregar Cita";
            labelAgregarCita.Click += label1_Click;
            // 
            // agregarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(panelAgregarCita);
            Controls.Add(cmbAdminCita);
            Name = "agregarCita";
            Size = new Size(844, 547);
            panelAgregarCita.ResumeLayout(false);
            panelAgregarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDCita).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAgregarCita;
        private Label labelAgregarCita;
        private TextBox txtNombrePacienteCita;
        private Label label8;
        private TextBox txtMotivoCita;
        private DateTimePicker dtpHoraCita;
        private DateTimePicker dtpFechaCita;
        private ComboBox cmbTratamientoCita;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label9;
        private ComboBox cmbMedicoCita;
        private Button btnBuscar;
        private TextBox textBox1;
        private ComboBox cmbSurcursalCita;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private NumericUpDown numericUpDownIDCita;
        private Label label4;
        private Label label10;
        private ComboBox cmbAdminCita;
    }
}
