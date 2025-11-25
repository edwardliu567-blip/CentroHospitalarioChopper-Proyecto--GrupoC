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
    public partial class agregarTratamiento : UserControl
    {
        private CNTratamiento cnTratamiento = new CNTratamiento();

        public agregarTratamiento()
        {
            InitializeComponent();
            dgvTrata.DataSource = cnTratamiento.VerTratamientos();
        }
        private void agregarTratamiento_Load(object sender, EventArgs e)
        {
            dgvTrata.DataSource = cnTratamiento.VerTratamientos();
        }


        private void panelAgregarCita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTrata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarTratamiento_Click(object sender, EventArgs e)
        {
            CETratamiento t = new CETratamiento
            {
                NombreTratamiento = txtNombreTrata.Text,
                Descripcion = txtDescripcionTrata.Text,
                Costo = decimal.Parse(numericUpDownCostoTrata.Text)
            };

            string resultado = cnTratamiento.AgregarTratamiento(t);
            MessageBox.Show(resultado);

            if (resultado == "Tratamiento agregado correctamente.")
                dgvTrata.DataSource = cnTratamiento.VerTratamientos();

        }

        private void btnEditarTrata_Click(object sender, EventArgs e)
        {
            CETratamiento t = new CETratamiento
            {
                IdTratamiento = int.Parse(numericUpDownIDTrata.Text),
                NombreTratamiento = txtNombreTrata.Text,
                Descripcion = txtDescripcionTrata.Text,
                Costo = decimal.Parse(numericUpDownCostoTrata.Text)
            };

            string resultado = cnTratamiento.ActualizarTratamiento(t);
            MessageBox.Show(resultado);

            if (resultado == "Tratamiento actualizado correctamente.")
                dgvTrata.DataSource = cnTratamiento.VerTratamientos();

        }

        private void btnBorrarTrata_Click(object sender, EventArgs e)
        {
            int idTratamiento = int.Parse(numericUpDownIDTrata.Text);
            string resultado = cnTratamiento.EliminarTratamiento(idTratamiento);
            MessageBox.Show(resultado);

            if (resultado == "Tratamiento eliminado correctamente.")
                dgvTrata.DataSource = cnTratamiento.VerTratamientos();

        }

        private void dgvTrata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTrata.Rows[e.RowIndex];
                numericUpDownIDTrata.Text = fila.Cells["id_tratamiento"].Value.ToString();
                txtNombreTrata.Text = fila.Cells["nombre_tratamiento"].Value.ToString();
                txtDescripcionTrata.Text = fila.Cells["descripcion"].Value.ToString();
                numericUpDownCostoTrata.Text = fila.Cells["costo"].Value.ToString();
            }

        }
    }
}
