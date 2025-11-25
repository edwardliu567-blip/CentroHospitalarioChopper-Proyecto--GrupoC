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
    public partial class panelPacientes : UserControl
    {
        private CNPaciente cnPaciente = new CNPaciente();


        public panelPacientes()
        {
            InitializeComponent();
            dgvInformacionPaciente.DataSource = cnPaciente.VerPacientes();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            panelPacientes panelPacientes = new panelPacientes();
            cambiarPanel(new agregarPaciente());
        }
        private void cambiarPanel(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            panelContenedorPacientes.Controls.Clear();
            panelContenedorPacientes.Controls.Add(panel);
            panel.BringToFront();
        }

        private void dgvInformacionPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInformacionPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvInformacionPaciente.Rows[e.RowIndex];
                textBox1.Text = fila.Cells["ced_paciente"].Value.ToString();
                textBoxPaciente.Text = fila.Cells["nombre_paciente"].Value.ToString() + "," + fila.Cells["apellido_paciente"].Value.ToString();

            }

        }

        private void dgvCitasPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string cedPaciente = textBox1.Text.Trim();
            string nombrePaciente = textBoxPaciente.Text.Trim();

            // Llamamos al método de negocio que conecta con el SP sp_Historial_Citas_Paciente
            DataTable dt = cnPaciente.HistorialCitasPaciente(cedPaciente, nombrePaciente);

            if (dt.Rows.Count > 0)
            {
                dgvCitasPacientes.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron citas para el paciente especificado.");
                dgvCitasPacientes.DataSource = null;
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarPaciente.PerformClick();
                e.SuppressKeyPress = true;
            }

        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxPaciente.Clear();
            dgvCitasPacientes.DataSource = null;
        }
    }
}
