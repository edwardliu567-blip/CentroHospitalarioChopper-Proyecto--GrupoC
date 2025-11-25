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
    public partial class agregarMedico : UserControl
    {
        public agregarMedico()
        {
            InitializeComponent();
            InicializeTable();
        }
        private void InicializeTable()
        {
            dataGridView1.DataSource = cnMedico.VerMedicos();
        }


        private CNMedico cnMedico = new CNMedico();

        private async void button1_Click(object sender, EventArgs e)
        {
            CEMedico medico = new CEMedico
            {
                ced_medico = txtCedulaMedico.Text,
                nombre_medico = txtNombreMedico.Text,
                apellido_medico = txtApellidoMedico.Text,
                especialidad = txtEspecialidad.Text,
                email_medico = txtEmailMedico.Text,
                tel_medico = txtTelefonoMedico.Text
            };

            string resultado = cnMedico.AgregarMedico(medico);
            MessageBox.Show(resultado);

            if (resultado == "Médico agregado correctamente.")
            {
                dataGridView1.DataSource = cnMedico.VerMedicos();
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = cnMedico.VerMedicos();

        }
        private void agregarMedico_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cnMedico.VerMedicos();
        }

        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            CEMedico medico = new CEMedico
            {
                ced_medico = txtCedulaMedico.Text,
                nombre_medico = txtNombreMedico.Text,
                apellido_medico = txtApellidoMedico.Text,
                especialidad = txtEspecialidad.Text,
                email_medico = txtEmailMedico.Text,
                tel_medico = txtTelefonoMedico.Text
            };

            string resultado = cnMedico.ActualizarMedico(medico);
            MessageBox.Show(resultado);

            if (resultado == "Médico actualizado correctamente.")
            {
                dataGridView1.DataSource = cnMedico.VerMedicos(); // refrescar tabla
            }

        }

        private void btnBorrarMedico_Click(object sender, EventArgs e)
        {
            string resultado = cnMedico.EliminarMedico(txtCedulaMedico.Text);
            MessageBox.Show(resultado);

            if (resultado == "Médico eliminado correctamente.")
            {
                dataGridView1.DataSource = cnMedico.VerMedicos(); // refrescar tabla
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtCedulaMedico.Text = fila.Cells["ced_medico"].Value.ToString();
                txtNombreMedico.Text = fila.Cells["nombre_medico"].Value.ToString();
                txtApellidoMedico.Text = fila.Cells["apellido_medico"].Value.ToString();
                txtEspecialidad.Text = fila.Cells["especialidad"].Value.ToString();
                txtEmailMedico.Text = fila.Cells["email_medico"].Value.ToString();
                txtTelefonoMedico.Text = fila.Cells["tel_medico"].Value.ToString();

            }
        }
    }
}
