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

namespace CapaPresentacion
{
    public partial class agregarPaciente : UserControl
    {
        public agregarPaciente()
        {
            InitializeComponent();
            CargarAdministradores();
            dgvPaciente.DataSource = cnPaciente.VerPacientes();

        }
        private CNPaciente cnPaciente = new CNPaciente();
        private CNAdministrador cnAdmin = new CNAdministrador();
        private void CargarAdministradores()
        {
            DataTable dt = cnAdmin.VerAdministradores();
            dt.Columns.Add("NombreCompleto", typeof(string), "nombre_admin + ' ' + apellido_admin");
            cmbAdmin.DataSource = dt;
            cmbAdmin.DisplayMember = "NombreCompleto";
            cmbAdmin.ValueMember = "id_admin";
            cmbAdmin.SelectedIndex = -1;
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            CEPaciente paciente = new CEPaciente
            {
                CedPaciente = txtCedula.Text,
                NombrePaciente = txtNombrePaciente.Text,
                ApellidoPaciente = txtApellidoPaciente.Text,
                EmailPaciente = txtEmail.Text,
                TelefonoPaciente = txtTelefono.Text,
                IdAdmin = cmbAdmin.SelectedValue != null ? cmbAdmin.SelectedValue.ToString() : null
            };

            string resultado = cnPaciente.AgregarPaciente(paciente);
            MessageBox.Show(resultado);

            if (resultado == "Paciente agregado correctamente.")
                dgvPaciente.DataSource = cnPaciente.VerPacientes();


        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            CEPaciente paciente = new CEPaciente
            {
                CedPaciente = txtCedula.Text,
                NombrePaciente = txtNombrePaciente.Text,
                ApellidoPaciente = txtApellidoPaciente.Text,
                EmailPaciente = txtEmail.Text,
                TelefonoPaciente = txtTelefono.Text,
                IdAdmin = cmbAdmin.SelectedValue != null ? cmbAdmin.SelectedValue.ToString() : null
            };

            string resultado = cnPaciente.ActualizarPaciente(paciente);
            MessageBox.Show(resultado);

            if (resultado == "Paciente actualizado correctamente.")
                dgvPaciente.DataSource = cnPaciente.VerPacientes();


        }

        private void btnBorrarPaciente_Click(object sender, EventArgs e)
        {
            string resultado = cnPaciente.EliminarPaciente(txtCedula.Text);
            MessageBox.Show(resultado);

            if (resultado == "Paciente eliminado correctamente.")
                dgvPaciente.DataSource = cnPaciente.VerPacientes();

        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPaciente.Rows[e.RowIndex];
                txtCedula.Text = fila.Cells["ced_paciente"].Value.ToString();
                txtNombrePaciente.Text = fila.Cells["nombre_paciente"].Value.ToString();
                txtApellidoPaciente.Text = fila.Cells["apellido_paciente"].Value.ToString();
                txtEmail.Text = fila.Cells["email_paciente"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono_paciente"].Value.ToString();
            }

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
