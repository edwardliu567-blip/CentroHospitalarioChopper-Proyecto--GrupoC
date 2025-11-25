namespace CapaPresentacion
{
    partial class mantenimientoMedicos
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
            panelVerInfoMedico = new Panel();
            btnBorrarVerMedico = new Button();
            verTelefonoMedico = new TextBox();
            label8 = new Label();
            verCorreoMedico = new TextBox();
            label7 = new Label();
            verEspecialidadMedico = new TextBox();
            label6 = new Label();
            verApellidoMedico = new TextBox();
            label5 = new Label();
            verNombreMedico = new TextBox();
            label4 = new Label();
            verIDmedico = new NumericUpDown();
            label3 = new Label();
            panelVerInfoMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)verIDmedico).BeginInit();
            SuspendLayout();
            // 
            // panelVerInfoMedico
            // 
            panelVerInfoMedico.BorderStyle = BorderStyle.Fixed3D;
            panelVerInfoMedico.Controls.Add(btnBorrarVerMedico);
            panelVerInfoMedico.Controls.Add(verTelefonoMedico);
            panelVerInfoMedico.Controls.Add(label8);
            panelVerInfoMedico.Controls.Add(verCorreoMedico);
            panelVerInfoMedico.Controls.Add(label7);
            panelVerInfoMedico.Controls.Add(verEspecialidadMedico);
            panelVerInfoMedico.Controls.Add(label6);
            panelVerInfoMedico.Controls.Add(verApellidoMedico);
            panelVerInfoMedico.Controls.Add(label5);
            panelVerInfoMedico.Controls.Add(verNombreMedico);
            panelVerInfoMedico.Controls.Add(label4);
            panelVerInfoMedico.Controls.Add(verIDmedico);
            panelVerInfoMedico.Controls.Add(label3);
            panelVerInfoMedico.Location = new Point(14, 363);
            panelVerInfoMedico.Name = "panelVerInfoMedico";
            panelVerInfoMedico.Size = new Size(805, 166);
            panelVerInfoMedico.TabIndex = 6;
            // 
            // btnBorrarVerMedico
            // 
            btnBorrarVerMedico.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrarVerMedico.Location = new Point(342, 140);
            btnBorrarVerMedico.Name = "btnBorrarVerMedico";
            btnBorrarVerMedico.Size = new Size(75, 23);
            btnBorrarVerMedico.TabIndex = 20;
            btnBorrarVerMedico.Text = "Borrar";
            btnBorrarVerMedico.UseVisualStyleBackColor = true;
            // 
            // verTelefonoMedico
            // 
            verTelefonoMedico.Location = new Point(471, 97);
            verTelefonoMedico.Name = "verTelefonoMedico";
            verTelefonoMedico.Size = new Size(145, 23);
            verTelefonoMedico.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 100);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 18;
            label8.Text = "Teléfono:";
            // 
            // verCorreoMedico
            // 
            verCorreoMedico.Location = new Point(471, 55);
            verCorreoMedico.Name = "verCorreoMedico";
            verCorreoMedico.Size = new Size(145, 23);
            verCorreoMedico.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 58);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 16;
            label7.Text = "Correo electrónico:";
            // 
            // verEspecialidadMedico
            // 
            verEspecialidadMedico.Location = new Point(471, 19);
            verEspecialidadMedico.Name = "verEspecialidadMedico";
            verEspecialidadMedico.Size = new Size(145, 23);
            verEspecialidadMedico.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 22);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 14;
            label6.Text = "Especialidad:";
            // 
            // verApellidoMedico
            // 
            verApellidoMedico.Location = new Point(190, 97);
            verApellidoMedico.Name = "verApellidoMedico";
            verApellidoMedico.Size = new Size(145, 23);
            verApellidoMedico.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 100);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 12;
            label5.Text = "Apellido:";
            // 
            // verNombreMedico
            // 
            verNombreMedico.Location = new Point(190, 55);
            verNombreMedico.Name = "verNombreMedico";
            verNombreMedico.Size = new Size(145, 23);
            verNombreMedico.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 58);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Nombre:";
            // 
            // verIDmedico
            // 
            verIDmedico.Location = new Point(190, 17);
            verIDmedico.Name = "verIDmedico";
            verIDmedico.Size = new Size(147, 23);
            verIDmedico.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 19);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 8;
            label3.Text = "ID:";
            // 
            // mantenimientoMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelVerInfoMedico);
            Name = "mantenimientoMedicos";
            Size = new Size(844, 547);
            panelVerInfoMedico.ResumeLayout(false);
            panelVerInfoMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)verIDmedico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVerInfoMedico;
        private Button btnBorrarVerMedico;
        private TextBox verTelefonoMedico;
        private Label label8;
        private TextBox verCorreoMedico;
        private Label label7;
        private TextBox verEspecialidadMedico;
        private Label label6;
        private TextBox verApellidoMedico;
        private Label label5;
        private TextBox verNombreMedico;
        private Label label4;
        private NumericUpDown verIDmedico;
        private Label label3;
    }
}
