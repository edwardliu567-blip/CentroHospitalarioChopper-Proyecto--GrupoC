namespace CapaPresentacion
{
    partial class agregarMedico
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
            txtEspecialidad = new TextBox();
            label1 = new Label();
            btnBorrarMedico = new Button();
            btnEditarMedico = new Button();
            dataGridView1 = new DataGridView();
            txtTelefonoMedico = new TextBox();
            txtCedulaMedico = new TextBox();
            txtApellidoMedico = new TextBox();
            txtNombreMedico = new TextBox();
            label8 = new Label();
            txtEmailMedico = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            labelAgregarMedico = new Label();
            panelAgregarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelAgregarCita
            // 
            panelAgregarCita.BackColor = Color.PowderBlue;
            panelAgregarCita.BorderStyle = BorderStyle.Fixed3D;
            panelAgregarCita.Controls.Add(txtEspecialidad);
            panelAgregarCita.Controls.Add(label1);
            panelAgregarCita.Controls.Add(btnBorrarMedico);
            panelAgregarCita.Controls.Add(btnEditarMedico);
            panelAgregarCita.Controls.Add(dataGridView1);
            panelAgregarCita.Controls.Add(txtTelefonoMedico);
            panelAgregarCita.Controls.Add(txtCedulaMedico);
            panelAgregarCita.Controls.Add(txtApellidoMedico);
            panelAgregarCita.Controls.Add(txtNombreMedico);
            panelAgregarCita.Controls.Add(label8);
            panelAgregarCita.Controls.Add(txtEmailMedico);
            panelAgregarCita.Controls.Add(button1);
            panelAgregarCita.Controls.Add(label7);
            panelAgregarCita.Controls.Add(label5);
            panelAgregarCita.Controls.Add(label4);
            panelAgregarCita.Controls.Add(label2);
            panelAgregarCita.Controls.Add(labelAgregarMedico);
            panelAgregarCita.Location = new Point(72, 36);
            panelAgregarCita.Name = "panelAgregarCita";
            panelAgregarCita.Size = new Size(700, 470);
            panelAgregarCita.TabIndex = 1;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(61, 347);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(172, 23);
            txtEspecialidad.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 327);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(80, 15);
            label1.TabIndex = 25;
            label1.Text = "Especialidad *";
            // 
            // btnBorrarMedico
            // 
            btnBorrarMedico.Location = new Point(386, 400);
            btnBorrarMedico.Name = "btnBorrarMedico";
            btnBorrarMedico.Size = new Size(75, 23);
            btnBorrarMedico.TabIndex = 24;
            btnBorrarMedico.Text = "Borrar";
            btnBorrarMedico.UseVisualStyleBackColor = true;
            btnBorrarMedico.Click += btnBorrarMedico_Click;
            // 
            // btnEditarMedico
            // 
            btnEditarMedico.Location = new Point(287, 400);
            btnEditarMedico.Name = "btnEditarMedico";
            btnEditarMedico.Size = new Size(75, 23);
            btnEditarMedico.TabIndex = 23;
            btnEditarMedico.Text = "Editar";
            btnEditarMedico.UseVisualStyleBackColor = true;
            btnEditarMedico.Click += btnEditarMedico_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(365, 209);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtTelefonoMedico
            // 
            txtTelefonoMedico.Location = new Point(61, 293);
            txtTelefonoMedico.Name = "txtTelefonoMedico";
            txtTelefonoMedico.Size = new Size(172, 23);
            txtTelefonoMedico.TabIndex = 21;
            // 
            // txtCedulaMedico
            // 
            txtCedulaMedico.Location = new Point(61, 186);
            txtCedulaMedico.Margin = new Padding(2);
            txtCedulaMedico.Name = "txtCedulaMedico";
            txtCedulaMedico.Size = new Size(172, 23);
            txtCedulaMedico.TabIndex = 20;
            // 
            // txtApellidoMedico
            // 
            txtApellidoMedico.Location = new Point(61, 133);
            txtApellidoMedico.Name = "txtApellidoMedico";
            txtApellidoMedico.Size = new Size(172, 23);
            txtApellidoMedico.TabIndex = 19;
            // 
            // txtNombreMedico
            // 
            txtNombreMedico.Location = new Point(61, 83);
            txtNombreMedico.Name = "txtNombreMedico";
            txtNombreMedico.Size = new Size(172, 23);
            txtNombreMedico.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 169);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 16;
            label8.Text = "Cédula *";
            // 
            // txtEmailMedico
            // 
            txtEmailMedico.Location = new Point(61, 238);
            txtEmailMedico.Name = "txtEmailMedico";
            txtEmailMedico.Size = new Size(172, 23);
            txtEmailMedico.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(190, 400);
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
            label7.Location = new Point(61, 273);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Teléfono *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 220);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Email *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 115);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido del médico *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 65);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del médico *";
            // 
            // labelAgregarMedico
            // 
            labelAgregarMedico.AutoSize = true;
            labelAgregarMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgregarMedico.Location = new Point(38, 26);
            labelAgregarMedico.Name = "labelAgregarMedico";
            labelAgregarMedico.Size = new Size(156, 25);
            labelAgregarMedico.TabIndex = 0;
            labelAgregarMedico.Text = "Agregar Médico";
            // 
            // agregarMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAgregarCita);
            Margin = new Padding(2);
            Name = "agregarMedico";
            Size = new Size(844, 547);
            panelAgregarCita.ResumeLayout(false);
            panelAgregarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgregarCita;
        private TextBox txtApellidoMedico;
        private TextBox txtNombreMedico;
        private Label label8;
        private TextBox txtEmailMedico;
        private Button button1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label labelAgregarMedico;
        private TextBox txtCedulaMedico;
        private TextBox txtTelefonoMedico;
        private Button btnBorrarMedico;
        private Button btnEditarMedico;
        private DataGridView dataGridView1;
        private TextBox txtEspecialidad;
        private Label label1;
    }
}
