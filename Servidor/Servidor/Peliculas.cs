using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa.Formularios
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
            LoadData();
        }

        // Evento para el botón de agregar película
        private void Boton_Agregar_Pelicula_Click(object sender, EventArgs e)
        {
            Agregar_Pelicula Ventana_Agregar_Pelicula = new Agregar_Pelicula();
            Ventana_Agregar_Pelicula.Show();
            this.Close();
        }

        // Método para cargar los datos de las películas en el DataGridView
        private void LoadData()
        {
            // Obtener nueva instancia
            PeliculaBLL peliculaBLL = new PeliculaBLL();

            // Crear una lista para mostrar los datos
            List<Pelicula> peliculas = peliculaBLL.ObtenerPeliculas();
            Pelicula_dataGridView.DataSource = peliculas;
        }

        // Evento para manejar el clic en las celdas del DataGridView de películas
        private void Pelicula_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Evento para manejar el clic en la etiqueta de películas
        private void Peliculas_label_Click(object sender, EventArgs e)
        {

        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
