namespace CapaPresentacion
{
    partial class agregarTratamiento
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
            label1 = new Label();
            numericUpDownIDTrata = new NumericUpDown();
            btnBorrarTrata = new Button();
            btnEditarTrata = new Button();
            dgvTrata = new DataGridView();
            numericUpDownCostoTrata = new NumericUpDown();
            txtDescripcionTrata = new TextBox();
            txtNombreTrata = new TextBox();
            label8 = new Label();
            btnAgregarTratamiento = new Button();
            label7 = new Label();
            label4 = new Label();
            labelAgregarMedico = new Label();
            panelAgregarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDTrata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCostoTrata).BeginInit();
            SuspendLayout();
            // 
            // panelAgregarCita
            // 
            panelAgregarCita.BackColor = Color.PowderBlue;
            panelAgregarCita.BorderStyle = BorderStyle.Fixed3D;
            panelAgregarCita.Controls.Add(label1);
            panelAgregarCita.Controls.Add(numericUpDownIDTrata);
            panelAgregarCita.Controls.Add(btnBorrarTrata);
            panelAgregarCita.Controls.Add(btnEditarTrata);
            panelAgregarCita.Controls.Add(dgvTrata);
            panelAgregarCita.Controls.Add(numericUpDownCostoTrata);
            panelAgregarCita.Controls.Add(txtDescripcionTrata);
            panelAgregarCita.Controls.Add(txtNombreTrata);
            panelAgregarCita.Controls.Add(label8);
            panelAgregarCita.Controls.Add(btnAgregarTratamiento);
            panelAgregarCita.Controls.Add(label7);
            panelAgregarCita.Controls.Add(label4);
            panelAgregarCita.Controls.Add(labelAgregarMedico);
            panelAgregarCita.Location = new Point(72, 56);
            panelAgregarCita.Name = "panelAgregarCita";
            panelAgregarCita.Size = new Size(700, 416);
            panelAgregarCita.TabIndex = 3;
            panelAgregarCita.Paint += panelAgregarCita_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(287, 52);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 26;
            label1.Text = "ID";
            // 
            // numericUpDownIDTrata
            // 
            numericUpDownIDTrata.Location = new Point(287, 70);
            numericUpDownIDTrata.Name = "numericUpDownIDTrata";
            numericUpDownIDTrata.Size = new Size(120, 23);
            numericUpDownIDTrata.TabIndex = 25;
            // 
            // btnBorrarTrata
            // 
            btnBorrarTrata.Location = new Point(386, 373);
            btnBorrarTrata.Name = "btnBorrarTrata";
            btnBorrarTrata.Size = new Size(75, 23);
            btnBorrarTrata.TabIndex = 24;
            btnBorrarTrata.Text = "Borrar";
            btnBorrarTrata.UseVisualStyleBackColor = true;
            btnBorrarTrata.Click += btnBorrarTrata_Click;
            // 
            // btnEditarTrata
            // 
            btnEditarTrata.Location = new Point(287, 373);
            btnEditarTrata.Name = "btnEditarTrata";
            btnEditarTrata.Size = new Size(75, 23);
            btnEditarTrata.TabIndex = 23;
            btnEditarTrata.Text = "Editar";
            btnEditarTrata.UseVisualStyleBackColor = true;
            btnEditarTrata.Click += btnEditarTrata_Click;
            // 
            // dgvTrata
            // 
            dgvTrata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrata.Location = new Point(287, 99);
            dgvTrata.Name = "dgvTrata";
            dgvTrata.Size = new Size(365, 186);
            dgvTrata.TabIndex = 22;
            dgvTrata.CellClick += dgvTrata_CellClick;
            dgvTrata.CellContentClick += dgvTrata_CellContentClick;
            // 
            // numericUpDownCostoTrata
            // 
            numericUpDownCostoTrata.Location = new Point(64, 212);
            numericUpDownCostoTrata.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownCostoTrata.Name = "numericUpDownCostoTrata";
            numericUpDownCostoTrata.Size = new Size(172, 23);
            numericUpDownCostoTrata.TabIndex = 21;
            // 
            // txtDescripcionTrata
            // 
            txtDescripcionTrata.Location = new Point(64, 306);
            txtDescripcionTrata.Name = "txtDescripcionTrata";
            txtDescripcionTrata.Size = new Size(588, 23);
            txtDescripcionTrata.TabIndex = 3;
            // 
            // txtNombreTrata
            // 
            txtNombreTrata.Location = new Point(64, 148);
            txtNombreTrata.Name = "txtNombreTrata";
            txtNombreTrata.Size = new Size(172, 23);
            txtNombreTrata.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 194);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 16;
            label8.Text = "Costo *";
            // 
            // btnAgregarTratamiento
            // 
            btnAgregarTratamiento.Location = new Point(190, 373);
            btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            btnAgregarTratamiento.Size = new Size(75, 23);
            btnAgregarTratamiento.TabIndex = 7;
            btnAgregarTratamiento.Text = "Agregar";
            btnAgregarTratamiento.UseVisualStyleBackColor = true;
            btnAgregarTratamiento.Click += btnAgregarTratamiento_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 288);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(77, 15);
            label7.TabIndex = 6;
            label7.Text = "Descripcion *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 130);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre *";
            // 
            // labelAgregarMedico
            // 
            labelAgregarMedico.AutoSize = true;
            labelAgregarMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgregarMedico.Location = new Point(38, 30);
            labelAgregarMedico.Name = "labelAgregarMedico";
            labelAgregarMedico.Size = new Size(198, 25);
            labelAgregarMedico.TabIndex = 0;
            labelAgregarMedico.Text = "Agregar Tratamiento";
            // 
            // agregarTratamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAgregarCita);
            Name = "agregarTratamiento";
            Size = new Size(844, 547);
            panelAgregarCita.ResumeLayout(false);
            panelAgregarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDTrata).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrata).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCostoTrata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgregarCita;
        private NumericUpDown numericUpDownCostoTrata;
        private TextBox txtDescripcionTrata;
        private TextBox txtNombreTrata;
        private Label label8;
        private Button btnAgregarTratamiento;
        private Label label7;
        private Label label4;
        private Label labelAgregarMedico;
        private Button btnBorrarTrata;
        private Button btnEditarTrata;
        private DataGridView dgvTrata;
        private Label label1;
        private NumericUpDown numericUpDownIDTrata;
    }
}
