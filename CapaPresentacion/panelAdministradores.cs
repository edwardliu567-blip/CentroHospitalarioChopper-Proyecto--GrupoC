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
            }
            else
            {
                MessageBox.Show("No se encontraron administradores con los criterios especificados.");
                dgvAdmin.DataSource = null;
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
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAdmin.Rows[e.RowIndex];
                textBox1.Text = fila.Cells["id_admin"].Value.ToString();
                textBoxNombreAdmin.Text = fila.Cells["nombre_admin"].Value.ToString() + "," + fila.Cells["apellido_admin"].Value.ToString();
            }
        }
    }
}
