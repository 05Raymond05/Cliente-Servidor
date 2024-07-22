using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programa.Formularios
{
    public partial class Agregar_Sucursal : Form
    {
        public Agregar_Sucursal()
        {
            InitializeComponent();
        }

        private void Agregar_Boton_Click(object sender, EventArgs e)
        {
            try
            {
                //Recoger datos
                bool activo = Activo_comboBox.SelectedIndex == 0;

                string nombre = Nombre_textBox.Text;
                string telefono = Telefono_textBox.Text;
                string direccion = direccion_textBox.Text;
                Encargado encargado_sucursal = (Encargado)Encargado_comboBox.SelectedItem;

                //Revisar que ningun dato importante este vacio
                if (String.IsNullOrWhiteSpace(nombre) ||
                    String.IsNullOrWhiteSpace(telefono) ||
                    String.IsNullOrWhiteSpace(direccion) ||
                    encargado_sucursal == null)
                {
                    string caption = "ERROR";
                    string mensaje = "Debe completar algun/os datos faltantes. Por favor revise.";
                    MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Crear el objeto sucursal y guardarlo
                    Sucursal nueva_sucursal = new Sucursal
                    {
                        Nombre = nombre,
                        Encargado = encargado_sucursal,
                        Direccion = direccion,
                        Telefono = telefono,
                        Activo = activo
                    };

                    SucursalBLL nueva_sucursalBLL = new SucursalBLL();

                    if (nueva_sucursalBLL.Guardar_Sucursal(nueva_sucursal))
                    {
                        //Preguntar si se desea agregar una nueva sucursal
                        string caption = "ÉXITO";
                        string mensaje = "Usted ha registrado una nueva sucursal con éxito. ¿Desea agregar otra sucursal?";
                        var decision = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (decision == DialogResult.No)
                        {
                            this.Close();
                            Sucursales Ventana_Sucursales = new Sucursales();
                            Ventana_Sucursales.Show();
                        }

                        //Limpiar cuadros de texto
                        Nombre_textBox.Clear();
                        Telefono_textBox.Clear();
                        direccion_textBox.Clear();
                        Activo_comboBox.SelectedIndex = 0;
                        Encargado_comboBox.ResetText();
                        Encargado_Informacion_label.Text = "Información de Encargado";
                    }
                    else
                    {
                        string caption = "ERROR";
                        string mensaje = "Error al guardar la sucursal.";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Agregar_Sucursal_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de EncargadoBLL
                EncargadoBLL nueva_instancia = new EncargadoBLL();

                // Obtener una lista con los encargados existentes
                List<Encargado> listaEncargados = nueva_instancia.ConsultarEncargados();

                // Bandera para lista vacía
                bool Empty_list = true;

                // Agregar uno por uno al combo box
                foreach (Encargado encargado in listaEncargados)
                {
                    if (encargado != null)
                    {
                        Empty_list = false;
                        Encargado_comboBox.Items.Add(encargado);
                        Encargado_comboBox.DisplayMember = "IdEncargado";
                    }
                }

                if (Empty_list) { throw new Exception(); }

                Activo_comboBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                string caption = "ERROR";
                string mensaje = "No hay ningún encargado registrado. " +
                                 "Por favor registre al menos uno antes de registrar una sucursal.";
                MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void Encargado_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encargado selectedItem = (Encargado)Encargado_comboBox.SelectedItem;

            string Texto = "Información de Encargado:\n" +
                           "Nombre del encargado: " + selectedItem.Nombre + "\n" +
                           "Identificación del encargado: " + selectedItem.Identificacion + "\n" +
                           "Primer apellido del encargado: " + selectedItem.PrimerApellido + "\n" +
                           "Segundo apellido del encargado: " + selectedItem.SegundoApellido;

            Encargado_Informacion_label.Text = Texto;
        }
    }
}
