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
    public partial class Agregar_PeliculaxSucursal : Form
    {
        public Agregar_PeliculaxSucursal()
        {
            InitializeComponent();
        }

        private void Boton_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Recoger datos del formulario
                Sucursal sucursal = (Sucursal)Sucursal_comboBox.SelectedItem;
                Pelicula pelicula = (Pelicula)Pelicula_comboBox.SelectedItem;
                string cantidad = cantidad_textBox.Text;

                //Revisar que ningun dato importante este vacio
                if (sucursal == null | pelicula == null | String.IsNullOrWhiteSpace(cantidad))
                {
                    string caption = "ERROR";
                    string mensaje = "Debe completar algun/os datos faltantes. Por favor revise.";
                    MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Revisar ID
                    PeliculaxSucursalBLL nueva = new PeliculaxSucursalBLL();
                    bool Revision;
                    Revision = nueva.Revision_Combinacion(pelicula, sucursal);

                    //Crear el objeto cliente y guardarlo
                    if (Revision)
                    {
                        PeliculaxSucursal nuevo_objeto = new PeliculaxSucursal();
                        
                        nuevo_objeto.Cantidad = int.Parse(cantidad);
                        nuevo_objeto.Pelicula = pelicula;
                        nuevo_objeto.Sucursal = sucursal;

                        nueva.Guardar_PeliculaxSucursal(nuevo_objeto);

                        //Preguntar si se desea agregar una nueva asociacion
                        string caption = "EXITO";
                        string mensaje = "Usted ha registrado un nuevo cliente con éxito. Desea agregar otro cliente?";
                        var decision = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (decision == DialogResult.No)
                        {
                            this.Close();
                            Sucursales Ventana_Sucursales = new Sucursales();
                            Ventana_Sucursales.Show();
                        }

                        //Cargar de nuevo el datagrid
                        Load_help();

                        //Limpiar cuadros de texto
                        cantidad_textBox.Clear();
                        Sucursal_comboBox.ResetText();
                        Pelicula_comboBox.ResetText();

                    }
                    else
                    {
                        MessageBox.Show("Digite una combinacion valido. Esa combinacion ya existe");
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

        private void Agregar_PeliculaxSucursal_Load(object sender, EventArgs e)
        {
            Load_help();
        }

        private void Load_help()
        {
            try
            {

                //Crear instancias
                SucursalBLL nueva_sucursalBll = new SucursalBLL();
                PeliculaBLL nueva_peliculaBLL = new PeliculaBLL();

                //Obtener listas
                Sucursal[] Array_Sucursal = nueva_sucursalBll.Consultar();
                Pelicula[] Array_pelicula = nueva_peliculaBLL.Consultar();

                //Bandera para array vacio
                bool Empty_sucursal = true;
                bool Empty_pelicula = true;

                //Agregar al combo box
                for (int i = 0; i < Array_Sucursal.Length; i++)
                {
                    if (Array_Sucursal[i] != null && Array_Sucursal[i].Activo)
                    {
                        Empty_sucursal = false;
                        Sucursal_comboBox.Items.Add(Array_Sucursal[i]);
                        Sucursal_comboBox.DisplayMember = "Nombre";
                    }

                    if (Array_pelicula[i] != null)
                    {
                        Empty_pelicula = false;
                        Pelicula_comboBox.Items.Add(Array_pelicula[i]);
                        Pelicula_comboBox.DisplayMember = "Titulo";
                    }
                }


                if (Empty_sucursal | Empty_pelicula) { throw new Exception(); }


            }
            catch (Exception)
            {
                string caption = "ERROR";

                string mensaje = "Registre al menos una pelicula y al menos una sucursal activa. ";

                MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            // Obtener nueva instancia
            PeliculaxSucursalBLL nueva_ = new PeliculaxSucursalBLL();

            // Crear un ArrayList para mostrar los datos
            PeliculaxSucursal[] lista = nueva_.Consultar();

            //Solicitar que no se generen automaticamente las columnas
            PeliculaxSucursal_dataGridView.AutoGenerateColumns = false;

            //Establecer la fuente de los datos
            PeliculaxSucursal_dataGridView.DataSource = lista;

            // Añadir columnas al DataGridView
            PeliculaxSucursal_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Sucursal_Id", HeaderText = "Sucursal_Id" });
            PeliculaxSucursal_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Sucursal_Nombre", HeaderText = "Sucursal_Nombre" });
            PeliculaxSucursal_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Pelicula_Id", HeaderText = "Pelicula_Id" });
            PeliculaxSucursal_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Pelicula_Titulo", HeaderText = "Pelicula_Titulo" });
            PeliculaxSucursal_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cantidad", HeaderText = "Cantidad" });
        }

    }
}
