namespace CapaPresentacion
{
    partial class agregarAdministrador
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
            s = new Button();
            btnEditarAdmin = new Button();
            dgvAdministradorMan = new DataGridView();
            txtApellidoAdmin = new TextBox();
            txtNombreAdmin = new TextBox();
            txtIDAdmin = new TextBox();
            label8 = new Label();
            txtCorreoAdmin = new TextBox();
            btnAgregarAdmin = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            labelAgregarMedico = new Label();
            panelAgregarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradorMan).BeginInit();
            SuspendLayout();
            // 
            // panelAgregarCita
            // 
            panelAgregarCita.BackColor = Color.PowderBlue;
            panelAgregarCita.BorderStyle = BorderStyle.Fixed3D;
            panelAgregarCita.Controls.Add(s);
            panelAgregarCita.Controls.Add(btnEditarAdmin);
            panelAgregarCita.Controls.Add(dgvAdministradorMan);
            panelAgregarCita.Controls.Add(txtApellidoAdmin);
            panelAgregarCita.Controls.Add(txtNombreAdmin);
            panelAgregarCita.Controls.Add(txtIDAdmin);
            panelAgregarCita.Controls.Add(label8);
            panelAgregarCita.Controls.Add(txtCorreoAdmin);
            panelAgregarCita.Controls.Add(btnAgregarAdmin);
            panelAgregarCita.Controls.Add(label5);
            panelAgregarCita.Controls.Add(label4);
            panelAgregarCita.Controls.Add(label2);
            panelAgregarCita.Controls.Add(labelAgregarMedico);
            panelAgregarCita.Location = new Point(72, 56);
            panelAgregarCita.Name = "panelAgregarCita";
            panelAgregarCita.Size = new Size(700, 416);
            panelAgregarCita.TabIndex = 2;
            // 
            // s
            // 
            s.Location = new Point(386, 338);
            s.Name = "s";
            s.Size = new Size(75, 23);
            s.TabIndex = 23;
            s.Text = "Borrar";
            s.UseVisualStyleBackColor = true;
            s.Click += s_Click;
            // 
            // btnEditarAdmin
            // 
            btnEditarAdmin.Location = new Point(287, 338);
            btnEditarAdmin.Name = "btnEditarAdmin";
            btnEditarAdmin.Size = new Size(75, 23);
            btnEditarAdmin.TabIndex = 22;
            btnEditarAdmin.Text = "Editar";
            btnEditarAdmin.UseVisualStyleBackColor = true;
            btnEditarAdmin.Click += btnEditarAdmin_Click;
            // 
            // dgvAdministradorMan
            // 
            dgvAdministradorMan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministradorMan.Location = new Point(268, 89);
            dgvAdministradorMan.Name = "dgvAdministradorMan";
            dgvAdministradorMan.Size = new Size(365, 209);
            dgvAdministradorMan.TabIndex = 21;
            // 
            // txtApellidoAdmin
            // 
            txtApellidoAdmin.Location = new Point(56, 225);
            txtApellidoAdmin.Margin = new Padding(2);
            txtApellidoAdmin.Name = "txtApellidoAdmin";
            txtApellidoAdmin.Size = new Size(172, 23);
            txtApellidoAdmin.TabIndex = 20;
            // 
            // txtNombreAdmin
            // 
            txtNombreAdmin.Location = new Point(56, 174);
            txtNombreAdmin.Name = "txtNombreAdmin";
            txtNombreAdmin.Size = new Size(172, 23);
            txtNombreAdmin.TabIndex = 19;
            // 
            // txtIDAdmin
            // 
            txtIDAdmin.Location = new Point(56, 116);
            txtIDAdmin.Name = "txtIDAdmin";
            txtIDAdmin.Size = new Size(172, 23);
            txtIDAdmin.TabIndex = 18;
            txtIDAdmin.TextChanged += txtIDAdmin_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 208);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 16;
            label8.Text = "Apellido *";
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(56, 283);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(172, 23);
            txtCorreoAdmin.TabIndex = 12;
            // 
            // btnAgregarAdmin
            // 
            btnAgregarAdmin.Location = new Point(190, 338);
            btnAgregarAdmin.Name = "btnAgregarAdmin";
            btnAgregarAdmin.Size = new Size(75, 23);
            btnAgregarAdmin.TabIndex = 7;
            btnAgregarAdmin.Text = "Agregar";
            btnAgregarAdmin.UseVisualStyleBackColor = true;
            btnAgregarAdmin.Click += btnAgregarAdmin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 265);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Email *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 156);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 98);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Cédula *";
            label2.Click += label2_Click;
            // 
            // labelAgregarMedico
            // 
            labelAgregarMedico.AutoSize = true;
            labelAgregarMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgregarMedico.Location = new Point(38, 26);
            labelAgregarMedico.Name = "labelAgregarMedico";
            labelAgregarMedico.Size = new Size(219, 25);
            labelAgregarMedico.TabIndex = 0;
            labelAgregarMedico.Text = "Agregar Administrador";
            // 
            // agregarAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAgregarCita);
            Name = "agregarAdministrador";
            Size = new Size(844, 547);
            panelAgregarCita.ResumeLayout(false);
            panelAgregarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradorMan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgregarCita;
        private TextBox txtApellidoAdmin;
        private TextBox txtNombreAdmin;
        private TextBox txtIDAdmin;
        private Label label8;
        private TextBox txtCorreoAdmin;
        private Button btnAgregarAdmin;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label labelAgregarMedico;
        private DataGridView dgvAdministradorMan;
        private Button s;
        private Button btnEditarAdmin;
    }
}
