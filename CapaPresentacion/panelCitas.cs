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
        private CNCita cNCita = new CNCita();
        public panelCitas()
        {
            InitializeComponent();
            dgvCitas.DataSource = cNCita.VerCitas();

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
            }
            else
            {
                MessageBox.Show("No se encontraron citas con los criterios especificados.");
                dgvCitas.DataSource = null;
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
            dgvCitas.DataSource = cNCita.VerCitas();
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
                // Nombre completo del médico
                if (fila.Cells["nombre_medico"].Value != null)
                    textBox3.Text = fila.Cells["nombre_medico"].Value.ToString();

                // Motivo de la cita
                if (fila.Cells["motivo_cita"].Value != null)
                    textBox2.Text = fila.Cells["motivo_cita"].Value.ToString();

                // Guardar el ID de la cita para actualizar estado después
                if (fila.Cells["id_Cita"].Value != null)
                    idCita1.Value = Convert.ToInt32(fila.Cells["id_Cita"].Value);
                if (fila.Cells["nombre_paciente"].Value !=null)
                    txtPacienteNombre.Text = fila.Cells["nombre_paciente"].Value.ToString();
                if (fila.Cells["ced_paciente"].Value != null)
                    txtIdPacienteBuscador.Text = fila.Cells["ced_paciente"].Value.ToString();

            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idCita = (int)idCita1.Value;
            cNCita.ActualizarEstadoCita(idCita, "Confirmada");
            MessageBox.Show("La cita ha sido confirmada.");
            dgvCitas.DataSource = cNCita.VerCitas();
        }

        private void btnCompletarCita_Click(object sender, EventArgs e)
        {
            int idCita = (int)idCita1.Value;
            cNCita.ActualizarEstadoCita(idCita, "Completada");
            MessageBox.Show("La cita ha sido marcada como completada.");
            dgvCitas.DataSource = cNCita.VerCitas();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            int idCita = (int)idCita1.Value;
            cNCita.ActualizarEstadoCita(idCita, "Cancelada");
            MessageBox.Show("La cita ha sido cancelada.");
            dgvCitas.DataSource = cNCita.VerCitas();

        }
    }
}
