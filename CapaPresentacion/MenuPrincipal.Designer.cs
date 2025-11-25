namespace CapaPresentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            linkCerrarSesion = new LinkLabel();
            btnTratamientos = new Button();
            btnAdministradores = new Button();
            btnCitas = new Button();
            btnClinicas = new Button();
            btnPacientes = new Button();
            btnMedicos = new Button();
            btnMenu = new Button();
            panelContenedor = new Panel();
            linkLabel1 = new LinkLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 64);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(linkCerrarSesion);
            panel2.Controls.Add(btnTratamientos);
            panel2.Controls.Add(btnAdministradores);
            panel2.Controls.Add(btnCitas);
            panel2.Controls.Add(btnClinicas);
            panel2.Controls.Add(btnPacientes);
            panel2.Controls.Add(btnMedicos);
            panel2.Controls.Add(btnMenu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 547);
            panel2.TabIndex = 1;
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.Location = new Point(74, 473);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(76, 15);
            linkCerrarSesion.TabIndex = 7;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesión";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // btnTratamientos
            // 
            btnTratamientos.BackColor = Color.White;
            btnTratamientos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTratamientos.ForeColor = Color.Black;
            btnTratamientos.Location = new Point(0, 343);
            btnTratamientos.Name = "btnTratamientos";
            btnTratamientos.Size = new Size(220, 48);
            btnTratamientos.TabIndex = 6;
            btnTratamientos.Text = "Tratamientos";
            btnTratamientos.UseVisualStyleBackColor = false;
            btnTratamientos.Click += btnTratamientos_Click;
            // 
            // btnAdministradores
            // 
            btnAdministradores.BackColor = Color.White;
            btnAdministradores.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdministradores.ForeColor = Color.Black;
            btnAdministradores.Location = new Point(0, 397);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.Size = new Size(220, 48);
            btnAdministradores.TabIndex = 5;
            btnAdministradores.Text = "Administradores";
            btnAdministradores.UseVisualStyleBackColor = false;
            btnAdministradores.Click += btnAdministradores_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.White;
            btnCitas.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCitas.ForeColor = Color.Black;
            btnCitas.Location = new Point(0, 289);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(220, 48);
            btnCitas.TabIndex = 4;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnClinicas
            // 
            btnClinicas.BackColor = Color.White;
            btnClinicas.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClinicas.ForeColor = Color.Black;
            btnClinicas.Location = new Point(0, 235);
            btnClinicas.Name = "btnClinicas";
            btnClinicas.Size = new Size(220, 48);
            btnClinicas.TabIndex = 3;
            btnClinicas.Text = "Clínicas";
            btnClinicas.UseVisualStyleBackColor = false;
            btnClinicas.Click += btnClinicas_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.White;
            btnPacientes.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacientes.ForeColor = Color.Black;
            btnPacientes.Location = new Point(0, 181);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(220, 48);
            btnPacientes.TabIndex = 2;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = Color.White;
            btnMedicos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMedicos.ForeColor = Color.Black;
            btnMedicos.Location = new Point(0, 127);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(220, 48);
            btnMedicos.TabIndex = 1;
            btnMedicos.Text = "Médicos";
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(0, 73);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(220, 48);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menú Principal";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BorderStyle = BorderStyle.Fixed3D;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 64);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(844, 547);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(89, 501);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(39, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cerrar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 611);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuPrincipal";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelContenedor;
        private Button btnMenu;
        private Button btnTratamientos;
        private Button btnAdministradores;
        private Button btnCitas;
        private Button btnClinicas;
        private Button btnPacientes;
        private Button btnMedicos;
        private LinkLabel linkCerrarSesion;
        private LinkLabel linkLabel1;
    }
}
