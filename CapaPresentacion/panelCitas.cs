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
    public partial class panelCitas : UserControl
    {
        private bool tablaCitasFiltrada = false;
        private CNCita cNCita = new CNCita();
        public panelCitas()
        {
            InitializeComponent();
            dgvCitas.DataSource = cNCita.VerCitasMenu();

        }
        private void cambiarPanel(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            panelContenedorCita.Controls.Clear();
            panelContenedorCita.Controls.Add(panel);
            panel.BringToFront();
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            agregarCita act = new agregarCita();
            cambiarPanel(act);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            DateTime? fechaInicio = null;
            DateTime? fechaFinal = null;

            if (dateCitaInicio.Checked) fechaInicio = dateCitaInicio.Value.Date;
            if (dateCitaFinal.Checked) fechaFinal = dateCitaFinal.Value.Date;

            string nombrePaciente = txtPacienteNombre.Text.Trim();
            string cedulaPaciente = txtIdPacienteBuscador.Text.Trim();

            dgvCitas.DataSource = null; // limpiar antes de aplicar filtro

            DataTable dt = cNCita.FiltrarCitas(fechaInicio, fechaFinal, nombrePaciente, cedulaPaciente);

            if (dt.Rows.Count > 0)
            {
                dgvCitas.DataSource = dt;
                tablaCitasFiltrada = true;   // ← bandera activada
            }
            else
            {
                MessageBox.Show("No se encontraron citas con los criterios especificados.");
                dgvCitas.DataSource = null;
                tablaCitasFiltrada = false;  // ← bandera desactivada
            }
        }


        private void dateCitaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPacienteNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarCita.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txtIdPacienteBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarCita.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnQuitarFiltroCitas_Click(object sender, EventArgs e)
        {
            dateCitaInicio.Checked = false;
            dateCitaFinal.Checked = false;
            txtPacienteNombre.Clear();
            txtIdPacienteBuscador.Clear();
            dgvCitas.DataSource = cNCita.VerCitasMenu();
            tablaCitasFiltrada = false;
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCitasFiltrada)
            {
                MessageBox.Show("No se puede seleccionar registros mientras la tabla está filtrada.",
                                "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
                if (fila == null || fila.Cells.Cast<DataGridViewCell>().All(c => c.Value == null || string.IsNullOrWhiteSpace(c.Value.ToString())))
                {
                    MessageBox.Show("El registro seleccionado está vacío o no contiene datos válidos.",
                                    "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvCitas.Columns.Contains("Médico"))
                    textBox3.Text = fila.Cells["Médico"].Value?.ToString();

                if (dgvCitas.Columns.Contains("Motivo"))
                    textBox2.Text = fila.Cells["Motivo"].Value?.ToString();

                if (dgvCitas.Columns.Contains("ID Cita"))
                    idCita1.Value = Convert.ToInt32(fila.Cells["ID Cita"].Value);

                if (dgvCitas.Columns.Contains("Paciente"))
                    txtPacienteNombre.Text = fila.Cells["Paciente"].Value?.ToString();

                if (dgvCitas.Columns.Contains("Cédula del paciente"))
                    txtIdPacienteBuscador.Text = fila.Cells["Cédula del paciente"].Value?.ToString();
            }



        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idCita = (int)idCita1.Value;
            cNCita.ActualizarEstadoCita(idCita, "Confirmada");
            MessageBox.Show("La cita ha sido confirmada.");
            dgvCitas.DataSource = cNCita.VerCitasMenu();
        }

        private void btnCompletarCita_Click(object sender, EventArgs e)
        {
            int idCita = (int)idCita1.Value;
            cNCita.ActualizarEstadoCita(idCita, "Completada");
            MessageBox.Show("La cita ha sido marcada como completada.");
            dgvCitas.DataSource = cNCita.VerCitasMenu();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            int idCita = (int)idCita1.Value;
            cNCita.ActualizarEstadoCita(idCita, "Cancelada");
            MessageBox.Show("La cita ha sido cancelada.");
            dgvCitas.DataSource = cNCita.VerCitasMenu();

        }
    }
}
