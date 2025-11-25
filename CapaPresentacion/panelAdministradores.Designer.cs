namespace CapaPresentacion
{
    partial class panelAdministradores
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
            pnlAdmin = new Panel();
            textBox1 = new TextBox();
            btnAgregarAdmin = new Button();
            labelNombreAdmin = new Label();
            btnBuscarAdmin = new Button();
            textBoxNombreAdmin = new TextBox();
            btnQuitarFiltroAdmin = new Button();
            label2 = new Label();
            labelAdministradores = new Label();
            paneldgvAdmin = new Panel();
            labelAdmindgv = new Label();
            dgvAdmin = new DataGridView();
            panelContenedorAdmin = new Panel();
            pnlAdmin.SuspendLayout();
            paneldgvAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            panelContenedorAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdmin
            // 
            pnlAdmin.BorderStyle = BorderStyle.Fixed3D;
            pnlAdmin.Controls.Add(textBox1);
            pnlAdmin.Controls.Add(btnAgregarAdmin);
            pnlAdmin.Controls.Add(labelNombreAdmin);
            pnlAdmin.Controls.Add(btnBuscarAdmin);
            pnlAdmin.Controls.Add(textBoxNombreAdmin);
            pnlAdmin.Controls.Add(btnQuitarFiltroAdmin);
            pnlAdmin.Controls.Add(label2);
            pnlAdmin.Controls.Add(labelAdministradores);
            pnlAdmin.Location = new Point(18, 51);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(805, 130);
            pnlAdmin.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 17;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // btnAgregarAdmin
            // 
            btnAgregarAdmin.Location = new Point(642, 95);
            btnAgregarAdmin.Name = "btnAgregarAdmin";
            btnAgregarAdmin.Size = new Size(141, 23);
            btnAgregarAdmin.TabIndex = 9;
            btnAgregarAdmin.Text = "Agregar Administrador";
            btnAgregarAdmin.UseVisualStyleBackColor = true;
            btnAgregarAdmin.Click += btnAgregarAdmin_Click;
            // 
            // labelNombreAdmin
            // 
            labelNombreAdmin.AutoSize = true;
            labelNombreAdmin.Location = new Point(22, 98);
            labelNombreAdmin.Name = "labelNombreAdmin";
            labelNombreAdmin.Size = new Size(54, 15);
            labelNombreAdmin.TabIndex = 8;
            labelNombreAdmin.Text = "Nombre:";
            // 
            // btnBuscarAdmin
            // 
            btnBuscarAdmin.Location = new Point(461, 95);
            btnBuscarAdmin.Name = "btnBuscarAdmin";
            btnBuscarAdmin.Size = new Size(75, 23);
            btnBuscarAdmin.TabIndex = 5;
            btnBuscarAdmin.Text = "Filtrar";
            btnBuscarAdmin.UseVisualStyleBackColor = true;
            btnBuscarAdmin.Click += btnBuscarAdmin_Click;
            // 
            // textBoxNombreAdmin
            // 
            textBoxNombreAdmin.Location = new Point(82, 95);
            textBoxNombreAdmin.Name = "textBoxNombreAdmin";
            textBoxNombreAdmin.Size = new Size(147, 23);
            textBoxNombreAdmin.TabIndex = 7;
            textBoxNombreAdmin.TextChanged += textBoxNombreAdmin_TextChanged;
            textBoxNombreAdmin.KeyDown += textBoxNombreAdmin_KeyDown;
            // 
            // btnQuitarFiltroAdmin
            // 
            btnQuitarFiltroAdmin.Location = new Point(554, 95);
            btnQuitarFiltroAdmin.Name = "btnQuitarFiltroAdmin";
            btnQuitarFiltroAdmin.Size = new Size(75, 23);
            btnQuitarFiltroAdmin.TabIndex = 4;
            btnQuitarFiltroAdmin.Text = "QuitarFiltro";
            btnQuitarFiltroAdmin.UseVisualStyleBackColor = true;
            btnQuitarFiltroAdmin.Click += btnQuitarFiltroAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 98);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Cédula:";
            // 
            // labelAdministradores
            // 
            labelAdministradores.AutoSize = true;
            labelAdministradores.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdministradores.Location = new Point(22, 21);
            labelAdministradores.Name = "labelAdministradores";
            labelAdministradores.Size = new Size(184, 27);
            labelAdministradores.TabIndex = 0;
            labelAdministradores.Text = "Administradores";
            // 
            // paneldgvAdmin
            // 
            paneldgvAdmin.BackColor = Color.White;
            paneldgvAdmin.BorderStyle = BorderStyle.Fixed3D;
            paneldgvAdmin.Controls.Add(labelAdmindgv);
            paneldgvAdmin.Controls.Add(dgvAdmin);
            paneldgvAdmin.Location = new Point(20, 206);
            paneldgvAdmin.Name = "paneldgvAdmin";
            paneldgvAdmin.Size = new Size(803, 300);
            paneldgvAdmin.TabIndex = 4;
            // 
            // labelAdmindgv
            // 
            labelAdmindgv.AutoSize = true;
            labelAdmindgv.BackColor = Color.Transparent;
            labelAdmindgv.ForeColor = SystemColors.ControlDarkDark;
            labelAdmindgv.Location = new Point(3, 6);
            labelAdmindgv.Name = "labelAdmindgv";
            labelAdmindgv.Size = new Size(94, 15);
            labelAdmindgv.TabIndex = 1;
            labelAdmindgv.Text = "Administradores";
            // 
            // dgvAdmin
            // 
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.Dock = DockStyle.Bottom;
            dgvAdmin.Location = new Point(0, 28);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.Size = new Size(799, 268);
            dgvAdmin.TabIndex = 0;
            dgvAdmin.CellClick += dgvAdmin_CellClick;
            dgvAdmin.CellContentClick += dgvAdmin_CellContentClick;
            // 
            // panelContenedorAdmin
            // 
            panelContenedorAdmin.Controls.Add(pnlAdmin);
            panelContenedorAdmin.Controls.Add(paneldgvAdmin);
            panelContenedorAdmin.Dock = DockStyle.Fill;
            panelContenedorAdmin.Location = new Point(0, 0);
            panelContenedorAdmin.Name = "panelContenedorAdmin";
            panelContenedorAdmin.Size = new Size(844, 547);
            panelContenedorAdmin.TabIndex = 9;
            // 
            // panelAdministradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedorAdmin);
            Name = "panelAdministradores";
            Size = new Size(844, 547);
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            paneldgvAdmin.ResumeLayout(false);
            paneldgvAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            panelContenedorAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdmin;
        private Button btnBuscarAdmin;
        private Button btnQuitarFiltroAdmin;
        private Label label2;
        private Label labelAdministradores;
        private Label labelNombreAdmin;
        private TextBox textBoxNombreAdmin;
        private Panel paneldgvAdmin;
        private Label labelAdmindgv;
        private DataGridView dgvAdmin;
        private Panel panelContenedorAdmin;
        private Button btnAgregarAdmin;
        private TextBox textBox1;
    }
}
