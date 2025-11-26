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
    public partial class panelTratamientos : UserControl
    {
        private CNTratamiento cnTratamiento = new CNTratamiento();
        private bool tablaTratamientosFiltrada = false;

        public panelTratamientos()
        {
            InitializeComponent();
            dgvTrata.DataSource = cnTratamiento.VerTratamientos();
        }

        private void btnAgregarTrata_Click(object sender, EventArgs e)
        {
            panelTratamientos panelTratamientos = new panelTratamientos();
            cambiarPanel(new agregarTratamiento());
        }
        private void cambiarPanel(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            panelContenedorTratamiento.Controls.Clear();
            panelContenedorTratamiento.Controls.Add(panel);
            panel.BringToFront();


        }

        private void dgvTrata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTrata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaTratamientosFiltrada)
            {
                MessageBox.Show("No se puede seleccionar registros mientras la tabla está filtrada.",
                                "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex >= 0) // aseguramos que no sea el header
            {
                DataGridViewRow fila = dgvTrata.Rows[e.RowIndex];
                if (fila == null || fila.Cells.Cast<DataGridViewCell>().All(c => c.Value == null || string.IsNullOrWhiteSpace(c.Value.ToString())))
                {
                    MessageBox.Show("El registro seleccionado está vacío o no contiene datos válidos.",
                                    "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ID en NumericUpDown (conversión segura)
                if (fila.Cells["id_tratamiento"].Value != null)
                {
                    filtroIdTrata.Value = Convert.ToInt32(fila.Cells["id_tratamiento"].Value);
                }
                
                // Nombre en TextBox
                if (fila.Cells["nombre_tratamiento"].Value != null)
                {
                    textBoxNombreTrata.Text = fila.Cells["nombre_tratamiento"].Value.ToString();
                }
            }


        }

        private void btnQuitarFiltroTrata_Click_1(object sender, EventArgs e)
        {
            filtroIdTrata.Value = 0;
            textBoxNombreTrata.Clear();
            dgvTrata.DataSource = cnTratamiento.VerTratamientos();
            tablaTratamientosFiltrada = false;
        }

        private void btnBuscarTrata_Click(object sender, EventArgs e)
        {
            int? idTratamiento = null;
            if (filtroIdTrata.Value > 0)
                idTratamiento = (int)filtroIdTrata.Value;

            string nombreTratamiento = textBoxNombreTrata.Text.Trim();

            dgvTrata.DataSource = null; // limpiar antes de aplicar filtro

            DataTable dt = cnTratamiento.FiltrarTratamientos(idTratamiento, nombreTratamiento);

            if (dt.Rows.Count > 0)
            {
                dgvTrata.DataSource = dt;
                tablaTratamientosFiltrada = true;   // ← bandera activada
            }
            else
            {
                MessageBox.Show("No se encontraron tratamientos con los criterios especificados.");
                dgvTrata.DataSource = null;
                tablaTratamientosFiltrada = false;  // ← bandera desactivada
            }


        }

        private void textBoxNombreTrata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarTrata.PerformClick();
                e.SuppressKeyPress = true;
            }

        }

        private void filtroIdTrata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarTrata.PerformClick(); 
            }

        }
    }
}
