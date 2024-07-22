using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;
using Programa.Formularios;

namespace Programa.Formularios
{
    public partial class Agregar_Pelicula : Form
    {
        public Agregar_Pelicula()
        {
            InitializeComponent();
        }

        private void Agregar_Boton_Click(object sender, EventArgs e)
        {
            try 
            {
                // Recoger datos del formulario
                string titulo = Titulo_textBox.Text;
                string ID = ID_Pelicula_textBox.Text;
                string idioma = Idioma_textBox.Text;
                string lanzamiento = lanzamiento_textBox.Text;
                Categoria categoria_pelicula = (Categoria)Categoria_comboBox.SelectedItem;

                // Revisar que no haya campos vacíos
                if (String.IsNullOrWhiteSpace(titulo) ||
                    String.IsNullOrWhiteSpace(ID) ||
                    String.IsNullOrWhiteSpace(idioma) ||
                    String.IsNullOrWhiteSpace(lanzamiento) ||
                    categoria_pelicula == null)
                {
                    string caption = "ERROR";
                    string mensaje = "Debe completar algún/os datos faltantes. Por favor revise.";
                    MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PeliculaBLL nueva_peliculaBLL = new PeliculaBLL();
                    int ID_to_int = int.Parse(ID);

                    // Crear el objeto Pelicula y guardarlo
                    Pelicula nueva_pelicula = new Pelicula
                    {
                        IdPelicula = ID_to_int,
                        Titulo = titulo,
                        Nombre = categoria_pelicula.Nombre,
                        Idioma = idioma,
                        AnoLanzamiento = int.Parse(lanzamiento)
                    };

                    if (nueva_peliculaBLL.Guardar_Pelicula(nueva_pelicula))
                    {
                        // Preguntar si se desea agregar una nueva película
                        string caption = "ÉXITO";
                        string mensaje = "Ha registrado una nueva película con éxito. ¿Desea agregar otra película?";
                        var decision = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (decision == DialogResult.No)
                        {
                            this.Close();
                        }

                        // Limpiar cuadros de texto
                        Titulo_textBox.Clear();
                        ID_Pelicula_textBox.Clear();
                        Idioma_textBox.Clear();
                        lanzamiento_textBox.Clear(); 
                        Categoria_comboBox.SelectedIndex = -1;
                        Categoria_label.Text = "Categoría:";
                    }
                    else
                    {
                        string caption = "ERROR";
                        string mensaje = "Ocurrió un error al guardar la película.";
                        MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }
            }
            catch (FormatException)
            {
                string caption = "ERROR";
                string mensaje = "El formato no es correcto.";
                MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                string caption = "ERROR";
                string mensaje = "El valor ingresado es demasiado grande.";
                MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Agregar_Pelicula_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de CategoriaBLL
                CategoriaBLL categoriaBLL = new CategoriaBLL();

                // Obtener una lista con las categorías existentes
                List<Categoria> listaCategorias = categoriaBLL.ObtenerCategorias();

                // Verificar si la lista está vacía
                if (listaCategorias.Count == 0) 
                {
                    throw new Exception();
                }

                // Agregar las categorías al ComboBox
                foreach (var categoria in listaCategorias)
                {
                    Categoria_comboBox.Items.Add(categoria);
                }
                Categoria_comboBox.DisplayMember = "Nombre"; // Muestra el nombre de la categoría en el ComboBox
            }
            catch (Exception)
            {
                string caption = "ERROR";
                string mensaje = "No hay ninguna categoría registrada. Por favor, registre al menos una antes de registrar una película.";
                MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Categoria_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categoria_comboBox.SelectedItem != null)
            {
                Categoria selectedItem = (Categoria)Categoria_comboBox.SelectedItem;
                string texto = "Categoría:\n" + selectedItem.Nombre;
                Categoria_label.Text = texto;
            }
        }
    }
}

