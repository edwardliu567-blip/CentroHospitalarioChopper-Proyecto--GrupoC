namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            menuPrincipalPanel mpp = new menuPrincipalPanel();
            cambiarPanel(mpp);
        }
        private void cambiarPanel(UserControl panel)
        {
            panel.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(panel);
            panel.BringToFront();


        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            panelMedicos cpm = new panelMedicos();
            cambiarPanel(cpm);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuPrincipalPanel mpp = new menuPrincipalPanel();
            cambiarPanel(mpp);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            panelPacientes ppa = new panelPacientes();
            cambiarPanel(ppa);
        }

        private void btnClinicas_Click(object sender, EventArgs e)
        {
            panelClinicas pc = new panelClinicas();
            cambiarPanel(pc);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            panelCitas pct = new panelCitas();
            cambiarPanel(pct);
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            panelAdministradores padmin = new panelAdministradores();
            cambiarPanel(padmin);
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            panelTratamientos pt = new panelTratamientos();
            cambiarPanel(pt);
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Está seguro que desea cerrar sesión?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
    );

            if (resultado == DialogResult.Yes)
            {
                // Ocultas el formulario actual
                this.Hide();

                // Abres el formulario de inicio de sesión
                inicioSesion ins = new inicioSesion();
                ins.Show();
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
                Application.Exit();
            }

        }
    }
}
