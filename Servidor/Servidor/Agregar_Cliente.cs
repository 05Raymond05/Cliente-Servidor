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
    public partial class Agregar_Cliente : Form
    {
        public Agregar_Cliente()
        {
            InitializeComponent();
        }

        private void Agregar_Boton_Click(object sender, EventArgs e)
        {
            try
            {                            
                //Recogemos todos los datos del formulario
                bool activo = true;
                if (Activo_comboBox.SelectedIndex == 1) { activo = false; }
                string nombre = Nombre_textBox.Text;
                string identificacion = Identificacion_Box.Text;
                string primer_apelllido = Primer_Apellido_textBox.Text;
                string segundo_apellido = Segundo_Apellido_textBox.Text;
                string ID = ID_Cliente_textBox.Text;            
                DateTime registro = Registro_dateTimePicker.Value;
                DateTime nacimiento = Nacimiento_dateTimePicker.Value;

                //Revisamos que no hayan campos vacios
                if (String.IsNullOrWhiteSpace(nombre) |
                    String.IsNullOrWhiteSpace(identificacion) |
                    String.IsNullOrWhiteSpace(primer_apelllido) |
                    String.IsNullOrWhiteSpace(segundo_apellido) |
                    String.IsNullOrWhiteSpace(ID))
                {
                    string caption = "ERROR";
                    string mensaje = "Debe completar algun/os datos faltantes. Por favor revise.";
                    MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }

                
                else
                {
                    ClienteBLL nuevo_ClienteBLL = new ClienteBLL();
                    bool Revision;
                    int ID_to_int = int.Parse(ID);
                    
                    Cliente nuevo_cliente = new Cliente();
                    nuevo_cliente.Identificacion = identificacion;
                    nuevo_cliente.Nombre = nombre;
                    nuevo_cliente.PrimerApellido = primer_apelllido;
                    nuevo_cliente.SegundoApellido = segundo_apellido;
                    nuevo_cliente.IdCliente = ID_to_int;
                    nuevo_cliente.Activo = activo;
                    nuevo_cliente.FechaNacimiento = nacimiento;
                    nuevo_cliente.FechaRegistro = registro;

                    if (nuevo_ClienteBLL.Guardar_Cliente(nuevo_cliente))
                    {
                        string caption = "EXITO";
                        string mensaje = "Usted ha registrado un nuevo cliente con éxito. Desea agregar otro cliente?";
                        var decision = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (decision == DialogResult.No)
                        {
                            this.Close();
                            Clientes Ventana_Clientes = new Clientes();
                            Ventana_Clientes.Show();
                        }

                        //Limpiar cuadros de texto
                        Nombre_textBox.Clear();
                        Identificacion_Box.Clear();
                        Primer_Apellido_textBox.Clear();
                        Segundo_Apellido_textBox.Clear();
                        ID_Cliente_textBox.Clear();
                        Registro_dateTimePicker.ResetText();
                        Nacimiento_dateTimePicker.ResetText();
                        Activo_comboBox.SelectedIndex = 0;

                    }
                    else
                    {

                    }
                    

                    //Preguntar si se desea agregar un nuevo cliente


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
                string caption = "ERROR";
                MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Activo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Cliente_Load(object sender, EventArgs e)
        {
            Activo_comboBox.SelectedIndex = 0;
        }

        private void ID_Cliente_label_Click(object sender, EventArgs e)
        {

        }

        private void Registro_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ID_Cliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nacimiento_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Segundo_Apellido_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Primer_Apellido_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Identificacion_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activo_Label_Click(object sender, EventArgs e)
        {

        }

        private void Registro_label_Click(object sender, EventArgs e)
        {

        }

        private void Nacimiento_label_Click(object sender, EventArgs e)
        {

        }

        private void Segundo_Apellido_label_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Primer_Apellido_label_Click(object sender, EventArgs e)
        {

        }

        private void Identificiacion_label_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_label_Click(object sender, EventArgs e)
        {

        }

        private void Ingresar_label_Click(object sender, EventArgs e)
        {

        }
    }
}
