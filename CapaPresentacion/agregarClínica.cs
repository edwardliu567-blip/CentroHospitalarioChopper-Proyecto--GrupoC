using CapaDatos;
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
    public partial class agregarClínica : UserControl
    {
        private CNClinica cnClinica = new CNClinica();

        public agregarClínica()
        {
            InitializeComponent();
            dgvClinica.DataSource = cnClinica.VerClinicas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEClinica clinica = new CEClinica
            {
                NombreClinica = txtNombreSucursal.Text,
                Direccion = textDireccion.Text,
                Telefono = txtTelefono.Text
            };

            string resultado = cnClinica.AgregarClinica(clinica);
            MessageBox.Show(resultado);

            if (resultado == "Clínica agregada correctamente.")
                dgvClinica.DataSource = cnClinica.VerClinicas();
        }

        private void dgvClinica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CEClinica clinica = new CEClinica
            {
                IdClinica = int.Parse(numericUpDownID.Text),
                NombreClinica = txtNombreSucursal.Text,
                Direccion = textDireccion.Text,
                Telefono = txtTelefono.Text
            };

            string resultado = cnClinica.ActualizarClinica(clinica);
            MessageBox.Show(resultado);

            if (resultado == "Clínica actualizada correctamente.")
                dgvClinica.DataSource = cnClinica.VerClinicas();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idClinica = int.Parse(numericUpDownID.Text);
            string resultado = cnClinica.EliminarClinica(idClinica);
            MessageBox.Show(resultado);

            if (resultado == "Clínica eliminada correctamente.")
                dgvClinica.DataSource = cnClinica.VerClinicas();

        }

        private void dgvClinica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClinica.Rows[e.RowIndex];
                numericUpDownID.Text = fila.Cells["id_clinica"].Value.ToString();
                txtNombreSucursal.Text = fila.Cells["nombre_clinica"].Value.ToString();
                textDireccion.Text = fila.Cells["direccion"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
            }

        }

        private void numericUpDownID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
