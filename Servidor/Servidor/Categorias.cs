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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Boton_Agregar_Categoria_Click(object sender, EventArgs e)
        {
            Agregar_Categoria Ventana_agregar_Categorias = new Agregar_Categoria();
            Ventana_agregar_Categorias.Show();
            this.Close();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            /*
            // Obtener nueva instancia
            CategoriaBLL categoriaBLL = new CategoriaBLL();

            // Crear un ArrayList para mostrar los datos
            Categoria[] categorias = categoriaBLL.Consultar();
            Categoria_dataGridView.DataSource = categorias;
            */
        }
    }
}
