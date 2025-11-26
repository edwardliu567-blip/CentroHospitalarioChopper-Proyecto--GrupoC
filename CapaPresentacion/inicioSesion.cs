using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaNegocio;
namespace CapaPresentacion
    //holaaaaa
{
    public partial class inicioSesion : Form
    {
        private CNAdministrador cnAdmin = new CNAdministrador();


        public inicioSesion()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idAdmin = textBox1.Text;
            string clave = textBox2.Text;

            string resultado = cnAdmin.IniciarSesion(idAdmin, clave);
            MessageBox.Show(resultado);

            if (resultado == "Acceso concedido.")
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Está seguro que desea salir?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // cierra toda la aplicación
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
