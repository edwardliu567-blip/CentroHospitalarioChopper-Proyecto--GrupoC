namespace CapaPresentacion
{
    partial class menuPrincipalPanel
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
            labelMenuPrincipal = new Label();
            panelContadorMedicos = new Panel();
            lblMedicos = new Label();
            labelCantMedicos = new Label();
            panelContadorPacientes = new Panel();
            lblPacientes = new Label();
            labelCantPacientes = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            panelCantCitas = new Panel();
            lblCitasHoy = new Label();
            labelCantCitas = new Label();
            panel1.SuspendLayout();
            panelContadorMedicos.SuspendLayout();
            panelContadorPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelCantCitas.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelMenuPrincipal);
            panel1.Location = new Point(18, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 72);
            panel1.TabIndex = 5;
            // 
            // labelMenuPrincipal
            // 
            labelMenuPrincipal.AutoSize = true;
            labelMenuPrincipal.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMenuPrincipal.Location = new Point(22, 21);
            labelMenuPrincipal.Name = "labelMenuPrincipal";
            labelMenuPrincipal.Size = new Size(167, 27);
            labelMenuPrincipal.TabIndex = 1;
            labelMenuPrincipal.Text = "Menú Principal";
            labelMenuPrincipal.TextAlign = ContentAlignment.TopRight;
            // 
            // panelContadorMedicos
            // 
            panelContadorMedicos.BackColor = Color.White;
            panelContadorMedicos.BorderStyle = BorderStyle.Fixed3D;
            panelContadorMedicos.Controls.Add(lblMedicos);
            panelContadorMedicos.Controls.Add(labelCantMedicos);
            panelContadorMedicos.Location = new Point(18, 152);
            panelContadorMedicos.Name = "panelContadorMedicos";
            panelContadorMedicos.RightToLeft = RightToLeft.No;
            panelContadorMedicos.Size = new Size(244, 112);
            panelContadorMedicos.TabIndex = 6;
            panelContadorMedicos.Paint += panelContadorMedicos_Paint;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Segoe UI", 48F);
            lblMedicos.Location = new Point(82, 7);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(72, 86);
            lblMedicos.TabIndex = 1;
            lblMedicos.Text = "1";
            lblMedicos.TextAlign = ContentAlignment.MiddleCenter;
            lblMedicos.Click += label1_Click;
            // 
            // labelCantMedicos
            // 
            labelCantMedicos.AutoSize = true;
            labelCantMedicos.Dock = DockStyle.Bottom;
            labelCantMedicos.ForeColor = SystemColors.ControlDarkDark;
            labelCantMedicos.Location = new Point(0, 93);
            labelCantMedicos.Name = "labelCantMedicos";
            labelCantMedicos.Size = new Size(115, 15);
            labelCantMedicos.TabIndex = 0;
            labelCantMedicos.Text = "Médicos disponibles";
            // 
            // panelContadorPacientes
            // 
            panelContadorPacientes.BackColor = Color.White;
            panelContadorPacientes.BorderStyle = BorderStyle.Fixed3D;
            panelContadorPacientes.Controls.Add(lblPacientes);
            panelContadorPacientes.Controls.Add(labelCantPacientes);
            panelContadorPacientes.Location = new Point(302, 152);
            panelContadorPacientes.Name = "panelContadorPacientes";
            panelContadorPacientes.Size = new Size(244, 112);
            panelContadorPacientes.TabIndex = 7;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Segoe UI", 48F);
            lblPacientes.Location = new Point(84, 7);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(72, 86);
            lblPacientes.TabIndex = 1;
            lblPacientes.Text = "2";
            // 
            // labelCantPacientes
            // 
            labelCantPacientes.AutoSize = true;
            labelCantPacientes.Dock = DockStyle.Bottom;
            labelCantPacientes.ForeColor = SystemColors.ControlDarkDark;
            labelCantPacientes.Location = new Point(0, 93);
            labelCantPacientes.Name = "labelCantPacientes";
            labelCantPacientes.Size = new Size(57, 15);
            labelCantPacientes.TabIndex = 0;
            labelCantPacientes.Text = "Pacientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(375, 150);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(20, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 182);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 12;
            label3.Text = "Médicos disponibles";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(444, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 182);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 13;
            label4.Text = "Citas recientes";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(375, 150);
            dataGridView2.TabIndex = 8;
            // 
            // panelCantCitas
            // 
            panelCantCitas.BackColor = Color.White;
            panelCantCitas.BorderStyle = BorderStyle.Fixed3D;
            panelCantCitas.Controls.Add(lblCitasHoy);
            panelCantCitas.Controls.Add(labelCantCitas);
            panelCantCitas.Location = new Point(577, 152);
            panelCantCitas.Name = "panelCantCitas";
            panelCantCitas.Size = new Size(244, 112);
            panelCantCitas.TabIndex = 12;
            // 
            // lblCitasHoy
            // 
            lblCitasHoy.AutoSize = true;
            lblCitasHoy.Font = new Font("Segoe UI", 48F);
            lblCitasHoy.Location = new Point(84, 7);
            lblCitasHoy.Name = "lblCitasHoy";
            lblCitasHoy.Size = new Size(72, 86);
            lblCitasHoy.TabIndex = 2;
            lblCitasHoy.Text = "1";
            lblCitasHoy.Click += lblCitasHoy_Click;
            // 
            // labelCantCitas
            // 
            labelCantCitas.AutoSize = true;
            labelCantCitas.Dock = DockStyle.Bottom;
            labelCantCitas.ForeColor = SystemColors.ControlDarkDark;
            labelCantCitas.Location = new Point(0, 93);
            labelCantCitas.Name = "labelCantCitas";
            labelCantCitas.Size = new Size(137, 15);
            labelCantCitas.TabIndex = 0;
            labelCantCitas.Text = "Cantidad de citas de hoy";
            // 
            // menuPrincipalPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCantCitas);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelContadorPacientes);
            Controls.Add(panelContadorMedicos);
            Controls.Add(panel1);
            Name = "menuPrincipalPanel";
            Size = new Size(844, 547);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContadorMedicos.ResumeLayout(false);
            panelContadorMedicos.PerformLayout();
            panelContadorPacientes.ResumeLayout(false);
            panelContadorPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelCantCitas.ResumeLayout(false);
            panelCantCitas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelMenuPrincipal;
        private Panel panelContadorMedicos;
        private Label labelCantMedicos;
        private Panel panelContadorPacientes;
        private Label labelCantPacientes;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private DataGridView dataGridView2;
        private Panel panelCantCitas;
        private Label labelCantCitas;
        private Label lblMedicos;
        private Label lblPacientes;
        private Label lblCitasHoy;
    }
}
