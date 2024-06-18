using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios_Prueba.Repositories;
using Ejercicios_Prueba.Models;



namespace GOT_App.Vistas
{
    public partial class GestionPersonajes : Form
    {
        PersonajesRepository repo = new PersonajesRepository();
        public GestionPersonajes()
        {
            InitializeComponent();
            CargarPersonajesALaGrilla();
        }

        private async void CargarPersonajesALaGrilla()
        {
            dataGridPersonajes.DataSource = await repo.ObtenerPersonajesAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarPersonajes agregarEditarPersonajes = new AgregarEditarPersonajes();
            agregarEditarPersonajes.ShowDialog();
            CargarPersonajesALaGrilla();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        { //obtener el id del libro seleccionado y su nombre
            string? idPersonajeSeleccionado = (string)dataGridPersonajes.CurrentRow.Cells[0].Value;
            string? NombrePersonajeSeleccionado = (string)dataGridPersonajes.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que preguna si esta seguro que sea borrar
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea eliminar el personaje {NombrePersonajeSeleccionado} ?",
                            "Eliminar personaje",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            //si el usuario seleccion que quiere borrar, enviamos a borrar el libro, utilizando el id y la repo
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idPersonajeSeleccionado);
                CargarPersonajesALaGrilla();
            }
           
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obtener el ID del personaje seleccionado
            string? idPersonajeSeleccionado = (string)dataGridPersonajes.CurrentRow.Cells[0].Value;


            //intanciar la ventana AgregarEditarPersonajes y pasarle ese id a su constructor
            //(vamos a crear un nuevo constructor en ese formulario que este preparado para recibir ese ID)
            AgregarEditarPersonajes AgregarEditarPersonajes = new AgregarEditarPersonajes(idPersonajeSeleccionado);
            AgregarEditarPersonajes.ShowDialog();




            //recargamos la grilla
            CargarPersonajesALaGrilla();
        }

    }
}

