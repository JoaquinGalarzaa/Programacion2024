using GOT_App.Vistas;

namespace GOT_App
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void personajesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestionPersonajes gestionPersonajes = new GestionPersonajes();
            gestionPersonajes.ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Esta seguro que desea salir de la aplicacion?",
                            "Salir",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }       
}
