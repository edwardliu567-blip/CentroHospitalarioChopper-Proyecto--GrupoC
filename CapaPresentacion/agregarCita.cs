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
    public partial class agregarCita : UserControl
    {
        private CNPaciente cnPaciente = new CNPaciente();
        private CNMedico cnMedico = new CNMedico();
        private CNTratamiento cnTratamiento = new CNTratamiento();
        private CNClinica cnClinica = new CNClinica();
        private CNCita cnCita = new CNCita();
        private CNAdministrador cnAdmin = new CNAdministrador();
        public agregarCita()
        {
            InitializeComponent();
            dataGridView1.DataSource = cnCita.VerCitas();
            CargarMedicos();
            CargarTratamientos();
            CargarClinicas();
            CargarAdministradores();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelAgregarCita_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarMedicos()
        {
            DataTable dt = cnMedico.VerMedicos();
            dt.Columns.Add("NombreCompleto", typeof(string), "nombre_medico + ' ' + apellido_medico");
            cmbMedicoCita.DataSource = dt;
            cmbMedicoCita.DisplayMember = "NombreCompleto";
            cmbMedicoCita.ValueMember = "ced_medico";
            cmbMedicoCita.SelectedIndex = -1;

        }
        private void CargarTratamientos()
        {
            DataTable dtTratamientos = cnTratamiento.VerTratamientos();
            cmbTratamientoCita.DataSource = dtTratamientos;
            cmbTratamientoCita.DisplayMember = "nombre_tratamiento";
            cmbTratamientoCita.ValueMember = "id_tratamiento";
            cmbTratamientoCita.SelectedIndex = -1;
        }
        private void CargarAdministradores()
        {
            DataTable dt = cnAdmin.VerAdministradores();
            if (!dt.Columns.Contains("Nombre"))
                throw new InvalidOperationException("La columna 'Nombre' no está presente en el DataTable.");

            // Crea columna 'NombreCompleto' y copia el valor de 'Nombre'
            dt.Columns.Add("NombreCompleto", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["NombreCompleto"] = row["Nombre"]?.ToString()?.Trim();
            }

            cmbAdminCita.DataSource = dt;
            cmbAdminCita.DisplayMember = "NombreCompleto";
            cmbAdminCita.ValueMember = "id_admin";
            cmbAdminCita.SelectedIndex = -1;

        }

        private void CargarClinicas()
        {
            DataTable dtClinicas = cnClinica.VerClinicas();
            cmbSurcursalCita.DataSource = dtClinicas;
            cmbSurcursalCita.DisplayMember = "nombre_clinica";
            cmbSurcursalCita.ValueMember = "id_clinica";
            cmbSurcursalCita.SelectedIndex = -1;
        }

        private void agregarCita_Load(object sender, EventArgs e)
        {


        }

        private void cmbMedicoCita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDownIDCita.Text)) return;

            CECita cita = new CECita
            {
                FechaCita = dtpFechaCita.Value.Date,
                HoraCita = dtpHoraCita.Value.TimeOfDay,
                EstadoCita = "Pendiente",
                MotivoCita = txtMotivoCita.Text,
                CedMedico = cmbMedicoCita.SelectedValue?.ToString(),
                CedPaciente = textBox1.Text,
                IdClinica = cmbSurcursalCita.SelectedValue != null ? (int)cmbSurcursalCita.SelectedValue : 0,
                IdTratamiento = cmbTratamientoCita.SelectedValue != null ? (int)cmbTratamientoCita.SelectedValue : 0,
                IdAdmin = cmbAdminCita.SelectedValue?.ToString()
            };

            string resultado = cnCita.AgregarCita(cita);
            MessageBox.Show(resultado);
            dataGridView1.DataSource = cnCita.VerCitas();
        }

        private void cmbSurcursalCita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDownIDCita.Text)) return;

            CECita cita = new CECita
            {
                IdCita = int.Parse(numericUpDownIDCita.Text),
                FechaCita = dtpFechaCita.Value.Date,
                HoraCita = dtpHoraCita.Value.TimeOfDay,
                EstadoCita = "Pendiente",
                MotivoCita = txtMotivoCita.Text,
                CedMedico = cmbMedicoCita.SelectedValue?.ToString(),   // puede ser null
                CedPaciente = textBox1.Text,
                IdClinica = cmbSurcursalCita.SelectedValue != null ? (int)cmbSurcursalCita.SelectedValue : 0,
                IdTratamiento = cmbTratamientoCita.SelectedValue != null ? (int)cmbTratamientoCita.SelectedValue : 0,
                IdAdmin = cmbAdminCita.SelectedValue?.ToString()       // puede ser null
            };

            string resultado = cnCita.ActualizarCita(cita);
            MessageBox.Show(resultado);
            dataGridView1.DataSource = cnCita.VerCitas();


        }

        private void numericUpDownIDCita_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Debe seleccionar una cita para eliminar.");
                return;
            }

            int idCita = int.Parse(numericUpDownIDCita.Text);
            string resultado = cnCita.EliminarCita(idCita);
            MessageBox.Show(resultado);

            if (resultado == "Cita eliminada correctamente.")
                dataGridView1.DataSource = cnCita.VerCitas();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                if (fila == null || fila.Cells.Cast<DataGridViewCell>().All(c => c.Value == null || string.IsNullOrWhiteSpace(c.Value.ToString())))
                {
                    MessageBox.Show("El registro seleccionado está vacío o no contiene datos válidos.",
                                    "Acción bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                numericUpDownIDCita.Text = fila.Cells["id_cita"].Value.ToString();
                dtpFechaCita.Value = Convert.ToDateTime(fila.Cells["fecha_cita"].Value);
                dtpHoraCita.Value = DateTime.Today.Add((TimeSpan)fila.Cells["hora_cita"].Value);
                txtMotivoCita.Text = fila.Cells["motivo_cita"].Value.ToString();
                textBox1.Text = fila.Cells["ced_paciente"].Value.ToString();
                txtNombrePacienteCita.Text = fila.Cells["nombre_paciente"].Value.ToString(); ;
                cmbMedicoCita.SelectedValue = fila.Cells["ced_medico"].Value.ToString();
                cmbSurcursalCita.SelectedValue = Convert.ToInt32(fila.Cells["id_clinica"].Value);
                cmbTratamientoCita.SelectedValue = Convert.ToInt32(fila.Cells["id_tratamiento"].Value);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cedula = textBox1.Text.Trim();
                DataTable dt = cnPaciente.VerPacientes();
                DataRow[] resultado = dt.Select($"ced_paciente = '{cedula}'");

                if (resultado.Length > 0)
                {
                    txtNombrePacienteCita.Text = resultado[0]["nombre_paciente"] + " " + resultado[0]["apellido_paciente"];
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado por cédula.");
                    txtNombrePacienteCita.Clear();
                }

                e.SuppressKeyPress = true; // evita el beep
            }

        }

        private void txtNombrePacienteCita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nombre = txtNombrePacienteCita.Text.Trim();
                DataTable dt = cnPaciente.VerPacientes();
                DataRow[] resultado = dt.Select($"nombre_paciente + ' ' + apellido_paciente = '{nombre}'");

                if (resultado.Length > 0)
                {
                    textBox1.Text = resultado[0]["ced_paciente"].ToString();
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado por nombre.");
                    textBox1.Clear();
                }

                e.SuppressKeyPress = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbAdminCita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
