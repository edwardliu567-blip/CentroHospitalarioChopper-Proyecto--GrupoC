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
    public partial class menuPrincipalPanel : UserControl
    {
        private CNMenu cnMenu = new CNMenu();
        public menuPrincipalPanel()
        {
            InitializeComponent();
            lblMedicos.Text = cnMenu.ObtenerTotalMedicos().ToString();
            lblPacientes.Text = cnMenu.ObtenerTotalPacientes().ToString();
            lblCitasHoy.Text = cnMenu.ObtenerTotalCitasHoy().ToString();
            dataGridView1.DataSource = cnMenu.VerMedicos();
            dataGridView2.DataSource = cnMenu.VerCitasHoyYManana();


        }

        private void panelContadorMedicos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
