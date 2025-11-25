using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class panelMedicos : UserControl
    {
        private CNMedico cnMedico = new CNMedico();

        public panelMedicos()
        {
            InitializeComponent();
            dgvInformacionMedicos.DataSource = cnMedico.VerMedicos();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // stub: manejador asociado desde el diseñador
        }

        private void panelVerInfoMedico_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cambiarPanel(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            panelContenedorMedicos.Controls.Clear();
            panelContenedorMedicos.Controls.Add(panel);
            panel.BringToFront();


        }
        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            panelMedicos panelMedicos = new panelMedicos();
            cambiarPanel(new agregarMedico());
        }

        private void panelInfoMedico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvInformacionMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInformacionMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvInformacionMedicos.Rows[e.RowIndex];

                textBox1.Text = fila.Cells["ced_medico"].Value.ToString();
                textBoxMedico.Text = fila.Cells["nombre_medico"].Value.ToString() + " " + fila.Cells["apellido_medico"].Value.ToString();
            }

        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxMedico.Clear();
            dgvHistorialCitasMedico.DataSource = null;
        }

        private void textBoxMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            string cedMedico = textBox1.Text.Trim();
            string nombreMedico = textBoxMedico.Text.Trim();

            DataTable dt = cnMedico.FiltrarCitasPorMedico(cedMedico, nombreMedico);

            if (dt.Rows.Count > 0)
            {
                dgvHistorialCitasMedico.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron citas para el médico especificado.");
                dgvHistorialCitasMedico.DataSource = null;
            }

        }

        private void textBoxMedico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarMedico.PerformClick();
                e.SuppressKeyPress = true;
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarMedico.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvHistorialCitasMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
