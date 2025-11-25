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
    public partial class agregarAdministrador : UserControl
    {
        private CNAdministrador cnAdmin = new CNAdministrador();
        public agregarAdministrador()
        {
            InitializeComponent();
            dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores();
        }
        private void agregarAdministrador_Load(object sender, EventArgs e)
        {
            dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores();
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
                EmailAdmin = txtCorreoAdmin.Text
            };

            string resultado = cnAdmin.AgregarAdministrador(admin);
            MessageBox.Show(resultado);

            if (resultado == "Administrador agregado correctamente.")
                dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores();

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
                EmailAdmin = txtCorreoAdmin.Text
            };

            string resultado = cnAdmin.ActualizarAdministrador(admin);
            MessageBox.Show(resultado);

            if (resultado == "Administrador actualizado correctamente.")
                dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores();

        }

        private void s_Click(object sender, EventArgs e)
        {
            string idAdmin = txtIDAdmin.Text;
            string resultado = cnAdmin.EliminarAdministrador(idAdmin);
            MessageBox.Show(resultado);

            if (resultado == "Administrador eliminado correctamente.")
               dgvAdministradorMan.DataSource = cnAdmin.VerAdministradores();

        }
    }
}
