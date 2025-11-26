using CapaEntidad;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class agregarAdministrador : UserControl
    {
        private CNAdministrador cnAdmin = new CNAdministrador();
        public agregarAdministrador()
        {
            InitializeComponent();
            dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores_ConClave();
            textBoxClave.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAdmin_Click(object sender, EventArgs e)
        {
            CEAdministrador admin = new CEAdministrador
            {
                IdAdmin = txtIDAdmin.Text,
                NombreAdmin = txtNombreAdmin.Text,
                ApellidoAdmin = txtApellidoAdmin.Text,
                EmailAdmin = txtCorreoAdmin.Text,
                clave = textBoxClave.Text

            };

            string resultado = cnAdmin.AgregarAdministrador_ConClave(admin);
            MessageBox.Show(resultado);

            if (resultado == "Administrador agregado correctamente.")
                dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores_ConClave();

        }

        private void txtIDAdmin_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que necesites para el evento TextChanged
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            CEAdministrador admin = new CEAdministrador
            {
                IdAdmin = txtIDAdmin.Text,
                NombreAdmin = txtNombreAdmin.Text,
                ApellidoAdmin = txtApellidoAdmin.Text,
                EmailAdmin = txtCorreoAdmin.Text,
                clave = textBoxClave.Text
            };

            string resultado = cnAdmin.ActualizarAdministrador_ConClave(admin);
            MessageBox.Show(resultado);

            if (resultado == "Administrador actualizado correctamente.")
                dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores_ConClave();

        }

        private void s_Click(object sender, EventArgs e)
        {
            string idAdmin = txtIDAdmin.Text;
            string resultado = cnAdmin.EliminarAdministrador(idAdmin);
            MessageBox.Show(resultado);

            if (resultado == "Administrador eliminado correctamente.")
                dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores_ConClave();

        }

        private void textBoxClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAdministradorMan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdministradorMan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evita clic en encabezado

            DataGridViewRow fila = dgvAdministradorMan.Rows[e.RowIndex];

            // Validación: fila vacía o sin datos
            if (fila == null || fila.Cells.Cast<DataGridViewCell>().All(c => c.Value == null || string.IsNullOrWhiteSpace(c.Value.ToString())))
            {
                MessageBox.Show("El registro seleccionado está vacío o no contiene datos válidos.",
                                "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Carga segura de campos
            if (dgvAdministradorMan.Columns.Contains("ID") && fila.Cells["ID"].Value != null)
                txtIDAdmin.Text = fila.Cells["ID"].Value.ToString();

            if (dgvAdministradorMan.Columns.Contains("Nombre") && fila.Cells["Nombre"].Value != null)
                txtNombreAdmin.Text = fila.Cells["Nombre"].Value.ToString();

            if (dgvAdministradorMan.Columns.Contains("Apellido") && fila.Cells["Apellido"].Value != null)
                txtApellidoAdmin.Text = fila.Cells["Apellido"].Value.ToString();

            if (dgvAdministradorMan.Columns.Contains("Correo") && fila.Cells["Correo"].Value != null)
                txtCorreoAdmin.Text = fila.Cells["Correo"].Value.ToString();

            if (dgvAdministradorMan.Columns.Contains("Clave") && fila.Cells["Clave"].Value != null)
                textBoxClave.Text = fila.Cells["Clave"].Value.ToString();

        }
    }
}
