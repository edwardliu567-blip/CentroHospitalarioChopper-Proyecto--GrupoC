using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class panelAdministradores : UserControl

    {
        private CNAdministrador cnAdmin = new CNAdministrador();
        private bool tablaAdministradoresFiltrada = false;
        public panelAdministradores()
        {
            InitializeComponent();
            dgvAdmin.DataSource = cnAdmin.VerAdministradores();
           
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarAdmin_Click(object sender, EventArgs e)
        {
            panelAdministradores panelAdministradores = new panelAdministradores();
            cambiarPanel(new agregarAdministrador());
        }
        private void cambiarPanel(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            panelContenedorAdmin.Controls.Clear();
            panelContenedorAdmin.Controls.Add(panel);
            panel.BringToFront();
        }

        private void btnBuscarAdmin_Click(object sender, EventArgs e)
        {
            string idAdmin = textBox1.Text.Trim();
            string nombreAdmin = textBoxNombreAdmin.Text.Trim();

            dgvAdmin.DataSource = null;

            DataTable dt = cnAdmin.FiltrarAdministradores(idAdmin, nombreAdmin);

            if (dt.Rows.Count > 0)
            {
                dgvAdmin.DataSource = dt;
                tablaAdministradoresFiltrada = true;   // ← bandera activada
            }
            else
            {
                MessageBox.Show("No se encontraron administradores con los criterios especificados.");
                dgvAdmin.DataSource = null;
                tablaAdministradoresFiltrada = false;  // ← bandera desactivada
            }



        }

        private void textBoxNombreAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarAdmin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarAdmin.PerformClick();
                e.SuppressKeyPress = true;
            }

        }

        private void btnQuitarFiltroAdmin_Click(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = cnAdmin.VerAdministradores();
            tablaAdministradoresFiltrada = false;
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bloquear si la tabla está filtrada
            if (tablaAdministradoresFiltrada)
            {
                MessageBox.Show("No se puede seleccionar registros mientras la tabla está filtrada.",
                                "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAdmin.Rows[e.RowIndex];

                // Bloquear si el registro es null o vacío
                if (fila == null || fila.Cells.Cast<DataGridViewCell>().All(c => c.Value == null || string.IsNullOrWhiteSpace(c.Value.ToString())))
                {
                    MessageBox.Show("El registro seleccionado está vacío o no contiene datos válidos.",
                                    "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ID del administrador
                if (dgvAdmin.Columns.Contains("id_admin") && fila.Cells["id_admin"].Value != null)
                    textBox1.Text = fila.Cells["id_admin"].Value.ToString();

                // Nombre del administrador
                if (dgvAdmin.Columns.Contains("Nombre") && fila.Cells["Nombre"].Value != null)
                    textBoxNombreAdmin.Text = fila.Cells["Nombre"].Value.ToString();
            }

        }

    }

}

