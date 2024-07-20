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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Programa.Formularios
{
    public partial class Agregar_Categoria : Form
    {
        public Agregar_Categoria()
        {
            InitializeComponent();
        }

        private void Agregar_Boton_Click(object sender, EventArgs e)
        {
            try
            {
                //Recogemos todos los datos del formulario
                string nombre = Nombre_textBox.Text;
                string descripcion = Descripcion_Box.Text;
                string ID = ID_Categoria_textBox.Text;


                //Revisamos que no hayan campos vacios
                if (String.IsNullOrWhiteSpace(nombre) |
                    String.IsNullOrWhiteSpace(descripcion) |
                    String.IsNullOrWhiteSpace(ID))
                {
                    string caption = "ERROR";
                    string mensaje = "Debe completar algun/os datos faltantes. Por favor revise.";
                    MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    CategoriaBLL nueva_CategoriaBLL = new CategoriaBLL();
                    int ID_to_int = int.Parse(ID);



                    //Crear el objeto cliente y guardarlo
                    Categoria nueva_Categoria = new Categoria
                    {
                        IdCategoria = ID_to_int,
                        Nombre = nombre,
                        Descripcion = descripcion
                    };

                    if (nueva_CategoriaBLL.Guardar_Categoria(nueva_Categoria))
                    {
                        //Preguntar si se desea agregar un nuevo cliente
                        string caption = "EXITO";
                        string mensaje = "Usted ha registrado una categoria con éxito. Desea agregar otra categoria?";
                        var decision = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (decision == DialogResult.No)
                        {
                            this.Close();
                            Categorias Ventana_Categorias = new Categorias();
                            Ventana_Categorias.Show();
                        }
                        //Limpiar cuadros de texto
                        Nombre_textBox.Clear();
                        ID_Categoria_textBox.Clear();
                        Descripcion_Box.Clear();
                    }
                    else
                    {
                        string caption = "ERROR";
                        string mensaje = ".";
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
    }
}
