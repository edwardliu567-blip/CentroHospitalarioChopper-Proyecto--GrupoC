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
    public partial class panelClinicas : UserControl
    {
        private CNClinica cnClinica = new CNClinica();
        private bool tablaClinicaFiltrada = false;
        public panelClinicas()
        {
            InitializeComponent();
            dgvClinicas.DataSource = cnClinica.VerClinicas();

        }

        private void btnAgregarClinica_Click(object sender, EventArgs e)
        {
            panelClinicas panelClinicas = new panelClinicas();
            cambiarPanel(new agregarClínica());
        }
        private void cambiarPanel(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            panelContenedorClinica.Controls.Clear();
            panelContenedorClinica.Controls.Add(panel);
            panel.BringToFront();
        }

        private void dgvClinicas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuitarFiltroClinica_Click(object sender, EventArgs e)
        {
            filtroIdClinica.Value = 0;
            tablaClinicaFiltrada = false;
            textBoxNombreClinicas.Clear();
            dgvClinicas.DataSource = cnClinica.VerClinicas();

        }


        private void textBoxNombreClinicas_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnBuscarClinica_Click(object sender, EventArgs e)
        {
            int? idClinica = null;
            if (int.TryParse(filtroIdClinica.Text.Trim(), out int id))
                idClinica = id;
            tablaClinicaFiltrada = true;

            string nombreClinica = textBoxNombreClinicas.Text.Trim();
            dgvClinicas.DataSource = null;


            DataTable dt = cnClinica.FiltrarClinicas(nombreClinica, idClinica);

            if (dt.Rows.Count > 0)
            {
                dgvClinicas.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron clínicas con los criterios especificados.");
                dgvClinicas.DataSource = cnClinica.VerClinicas();

            }

        }
        private void textBoxNombreClinicas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarClinica.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void filtroIdClinica_ValueChanged(object sender, EventArgs e)
        {

        }

        private void filtroIdClinica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarClinica.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void dgvClinicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaClinicaFiltrada)
            {
                MessageBox.Show("No se puede seleccionar registros mientras la tabla está filtrada.", "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClinicas.Rows[e.RowIndex];

                // Validación defensiva por si las columnas cambian
                if (dgvClinicas.Columns.Contains("id_clinica"))
                    filtroIdClinica.Text = fila.Cells["id_clinica"].Value?.ToString();

                if (dgvClinicas.Columns.Contains("nombre_clinica"))
                    textBoxNombreClinicas.Text = fila.Cells["nombre_clinica"].Value?.ToString();
            }

        }
    }
}
