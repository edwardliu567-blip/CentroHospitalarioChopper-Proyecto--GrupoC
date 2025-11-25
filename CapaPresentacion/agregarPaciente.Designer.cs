namespace CapaPresentacion
{
    partial class agregarPaciente
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
            btnBorrarPaciente = new Button();
            btnEditarPaciente = new Button();
            dgvPaciente = new DataGridView();
            txtTelefono = new TextBox();
            txtCedula = new TextBox();
            txtApellidoPaciente = new TextBox();
            txtNombrePaciente = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            btnAgregarPaciente = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            labelAgregarMedico = new Label();
            cmbAdmin = new ComboBox();
            lbladmin = new Label();
            panelAgregarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            SuspendLayout();
            // 
            // panelAgregarCita
            // 
            panelAgregarCita.BackColor = Color.PowderBlue;
            panelAgregarCita.BorderStyle = BorderStyle.Fixed3D;
            panelAgregarCita.Controls.Add(btnBorrarPaciente);
            panelAgregarCita.Controls.Add(btnEditarPaciente);
            panelAgregarCita.Controls.Add(dgvPaciente);
            panelAgregarCita.Controls.Add(txtTelefono);
            panelAgregarCita.Controls.Add(txtCedula);
            panelAgregarCita.Controls.Add(txtApellidoPaciente);
            panelAgregarCita.Controls.Add(txtNombrePaciente);
            panelAgregarCita.Controls.Add(label8);
            panelAgregarCita.Controls.Add(txtEmail);
            panelAgregarCita.Controls.Add(btnAgregarPaciente);
            panelAgregarCita.Controls.Add(label7);
            panelAgregarCita.Controls.Add(label5);
            panelAgregarCita.Controls.Add(label4);
            panelAgregarCita.Controls.Add(label2);
            panelAgregarCita.Controls.Add(labelAgregarMedico);
            panelAgregarCita.Location = new Point(72, 56);
            panelAgregarCita.Name = "panelAgregarCita";
            panelAgregarCita.Size = new Size(700, 416);
            panelAgregarCita.TabIndex = 2;
            // 
            // btnBorrarPaciente
            // 
            btnBorrarPaciente.Location = new Point(386, 338);
            btnBorrarPaciente.Name = "btnBorrarPaciente";
            btnBorrarPaciente.Size = new Size(75, 23);
            btnBorrarPaciente.TabIndex = 23;
            btnBorrarPaciente.Text = "Borrar";
            btnBorrarPaciente.UseVisualStyleBackColor = true;
            btnBorrarPaciente.Click += btnBorrarPaciente_Click;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.Location = new Point(287, 338);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Size = new Size(75, 23);
            btnEditarPaciente.TabIndex = 22;
            btnEditarPaciente.Text = "Editar";
            btnEditarPaciente.UseVisualStyleBackColor = true;
            btnEditarPaciente.Click += btnEditarPaciente_Click;
            // 
            // dgvPaciente
            // 
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Location = new Point(268, 89);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.Size = new Size(365, 209);
            dgvPaciente.TabIndex = 21;
            dgvPaciente.CellClick += dgvPaciente_CellClick;
            dgvPaciente.CellContentClick += dgvPaciente_CellContentClick;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(56, 300);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(172, 23);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(56, 190);
            txtCedula.Margin = new Padding(2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(172, 23);
            txtCedula.TabIndex = 20;
            // 
            // txtApellidoPaciente
            // 
            txtApellidoPaciente.Location = new Point(56, 142);
            txtApellidoPaciente.Name = "txtApellidoPaciente";
            txtApellidoPaciente.Size = new Size(172, 23);
            txtApellidoPaciente.TabIndex = 19;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(56, 84);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(172, 23);
            txtNombrePaciente.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 173);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 16;
            label8.Text = "Cédula *";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(56, 244);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 12;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Location = new Point(190, 338);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(75, 23);
            btnAgregarPaciente.TabIndex = 7;
            btnAgregarPaciente.Text = "Agregar";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 283);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Teléfono *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 226);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Email *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 124);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido del paciente *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 66);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del paciente *";
            // 
            // labelAgregarMedico
            // 
            labelAgregarMedico.AutoSize = true;
            labelAgregarMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgregarMedico.Location = new Point(38, 30);
            labelAgregarMedico.Name = "labelAgregarMedico";
            labelAgregarMedico.Size = new Size(165, 25);
            labelAgregarMedico.TabIndex = 0;
            labelAgregarMedico.Text = "Agregar Paciente";
            // 
            // cmbAdmin
            // 
            cmbAdmin.FormattingEnabled = true;
            cmbAdmin.Location = new Point(585, 27);
            cmbAdmin.Name = "cmbAdmin";
            cmbAdmin.Size = new Size(187, 23);
            cmbAdmin.TabIndex = 24;
            cmbAdmin.SelectedIndexChanged += cmbAdmin_SelectedIndexChanged;
            // 
            // lbladmin
            // 
            lbladmin.AutoSize = true;
            lbladmin.Location = new Point(493, 30);
            lbladmin.Name = "lbladmin";
            lbladmin.Size = new Size(86, 15);
            lbladmin.TabIndex = 25;
            lbladmin.Text = "Administrador:";
            // 
            // agregarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbladmin);
            Controls.Add(cmbAdmin);
            Controls.Add(panelAgregarCita);
            Name = "agregarPaciente";
            Size = new Size(844, 547);
            panelAgregarCita.ResumeLayout(false);
            panelAgregarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAgregarCita;
        private TextBox txtTelefono;
        private TextBox txtCedula;
        private TextBox txtApellidoPaciente;
        private TextBox txtNombrePaciente;
        private Label label8;
        private TextBox txtEmail;
        private Button btnAgregarPaciente;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label labelAgregarMedico;
        private Button btnBorrarPaciente;
        private Button btnEditarPaciente;
        private DataGridView dgvPaciente;
        private ComboBox cmbAdmin;
        private Label lbladmin;
    }
}
