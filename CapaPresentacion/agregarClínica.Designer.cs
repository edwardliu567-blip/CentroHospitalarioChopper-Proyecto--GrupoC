namespace CapaPresentacion
{
    partial class agregarClínica
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
            numericUpDownID = new NumericUpDown();
            dgvClinica = new DataGridView();
            btnBorrar = new Button();
            btnEditar = new Button();
            textDireccion = new TextBox();
            txtNombreSucursal = new TextBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            labelAgregarClinica = new Label();
            panelAgregarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClinica).BeginInit();
            SuspendLayout();
            // 
            // panelAgregarCita
            // 
            panelAgregarCita.BackColor = Color.PowderBlue;
            panelAgregarCita.BorderStyle = BorderStyle.Fixed3D;
            panelAgregarCita.Controls.Add(label1);
            panelAgregarCita.Controls.Add(numericUpDownID);
            panelAgregarCita.Controls.Add(dgvClinica);
            panelAgregarCita.Controls.Add(btnBorrar);
            panelAgregarCita.Controls.Add(btnEditar);
            panelAgregarCita.Controls.Add(textDireccion);
            panelAgregarCita.Controls.Add(txtNombreSucursal);
            panelAgregarCita.Controls.Add(label8);
            panelAgregarCita.Controls.Add(txtTelefono);
            panelAgregarCita.Controls.Add(btnAgregar);
            panelAgregarCita.Controls.Add(label5);
            panelAgregarCita.Controls.Add(label4);
            panelAgregarCita.Controls.Add(labelAgregarClinica);
            panelAgregarCita.Location = new Point(72, 56);
            panelAgregarCita.Name = "panelAgregarCita";
            panelAgregarCita.Size = new Size(700, 416);
            panelAgregarCita.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(267, 42);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 25;
            label1.Text = "ID:";
            // 
            // numericUpDownID
            // 
            numericUpDownID.Location = new Point(268, 60);
            numericUpDownID.Name = "numericUpDownID";
            numericUpDownID.Size = new Size(171, 23);
            numericUpDownID.TabIndex = 24;
            numericUpDownID.ValueChanged += numericUpDownID_ValueChanged;
            // 
            // dgvClinica
            // 
            dgvClinica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClinica.Location = new Point(268, 89);
            dgvClinica.Name = "dgvClinica";
            dgvClinica.Size = new Size(365, 209);
            dgvClinica.TabIndex = 23;
            dgvClinica.CellClick += dgvClinica_CellClick;
            dgvClinica.CellContentClick += dgvClinica_CellContentClick;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(386, 338);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(287, 338);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(60, 172);
            textDireccion.Margin = new Padding(2);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(172, 23);
            textDireccion.TabIndex = 20;
            // 
            // txtNombreSucursal
            // 
            txtNombreSucursal.Location = new Point(60, 116);
            txtNombreSucursal.Name = "txtNombreSucursal";
            txtNombreSucursal.Size = new Size(172, 23);
            txtNombreSucursal.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 155);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 16;
            label8.Text = "Dirección *";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(59, 234);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(172, 23);
            txtTelefono.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(190, 338);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 216);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Teléfono *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 98);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Surcursal *";
            // 
            // labelAgregarClinica
            // 
            labelAgregarClinica.AutoSize = true;
            labelAgregarClinica.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAgregarClinica.Location = new Point(21, 21);
            labelAgregarClinica.Name = "labelAgregarClinica";
            labelAgregarClinica.Size = new Size(148, 25);
            labelAgregarClinica.TabIndex = 0;
            labelAgregarClinica.Text = "Agregar Clínica";
            // 
            // agregarClínica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAgregarCita);
            Name = "agregarClínica";
            Size = new Size(844, 547);
            panelAgregarCita.ResumeLayout(false);
            panelAgregarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClinica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgregarCita;
        private TextBox textDireccion;
        private TextBox txtNombreSucursal;
        private Label label8;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Label label5;
        private Label label4;
        private Label labelAgregarClinica;
        private DataGridView dgvClinica;
        private Button btnBorrar;
        private Button btnEditar;
        private Label label1;
        private NumericUpDown numericUpDownID;
    }
}
