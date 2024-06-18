using Ejercicios_Prueba.Models;
using Ejercicios_Prueba.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GOT_App.Vistas
{
    public partial class AgregarEditarPersonajes : Form
    { 
        private string idPersonajeSeleccionado;
        PersonajesRepository repo = new PersonajesRepository();

        public AgregarEditarPersonajes()
        {
            InitializeComponent();
            
        }

        public AgregarEditarPersonajes(string idPersonajeSeleccionado)
        {
            this.idPersonajeSeleccionado = idPersonajeSeleccionado;
            InitializeComponent();
            CargarDatosPersonajeEnPantalla();
        }
        public async void CargarDatosPersonajeEnPantalla()
        {
            Personaje? personaje = await repo.ObtenerPorIdAsync(this.idPersonajeSeleccionado);
            if (personaje != null)
            {
                txtNombre.Text = personaje.Nombre_completo;
                numericEdad.Value = personaje.Edad;
                txtAlias.Text = personaje.Alias;
                txtFotoUrl.Text = personaje.Foto_url;
                txtEmblema.Text = personaje.Emblema_url;
                pictureBoxFoto.ImageLocation = personaje.Foto_url;
                pictureBoxEmblema.ImageLocation = personaje.Emblema_url;
            }
            else
            {
                MessageBox.Show("Error: no se encontró el libro");
            }
        }

        

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonajesRepository repo = new PersonajesRepository();

            if (this.idPersonajeSeleccionado != null)
            {
                await repo.ActualizarAsync(
                        txtNombre.Text,
                        (int)numericEdad.Value,
                        txtAlias.Text,
                        txtFotoUrl.Text,
                        txtEmblema.Text,
                        this.idPersonajeSeleccionado);
                this.Close();
            }
            else
            {
                await repo.AgregarAsync(
                         txtNombre.Text,
                         (int)numericEdad.Value,
                         txtAlias.Text,
                         txtFotoUrl.Text,
                         txtEmblema.Text);
                this.Close();
            }
        }
    }
}
