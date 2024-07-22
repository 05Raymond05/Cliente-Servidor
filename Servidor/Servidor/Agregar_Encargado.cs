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
    public partial class Agregar_Encargado : Form
    {
        public Agregar_Encargado()
        {
            InitializeComponent();
        }

        private void Agregar_Boton_Click(object sender, EventArgs e)
        {
            try
            {
                // Recogemos todos los datos del formulario
                string nombre = Nombre_textBox.Text;
                string identificacion = Identificacion_Box.Text;
                string primer_apellido = Primer_Apellido_textBox.Text;
                string segundo_apellido = Segundo_Apellido_textBox.Text;
                string ID = ID_Encargado_textBox.Text;
                DateTime ingreso = Ingreso_dateTimePicker.Value;
                DateTime nacimiento = Nacimiento_dateTimePicker.Value;

                // Revisamos que no hayan campos vacíos
                if (String.IsNullOrWhiteSpace(nombre) ||
                    String.IsNullOrWhiteSpace(identificacion) ||
                    String.IsNullOrWhiteSpace(primer_apellido) ||
                    String.IsNullOrWhiteSpace(segundo_apellido) ||
                    String.IsNullOrWhiteSpace(ID))
                {
                    string caption = "ERROR";
                    string mensaje = "Debe completar algun/os datos faltantes. Por favor revise.";
                    MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Crear el objeto encargado y guardarlo
                    EncargadoBLL nuevo_EncargadoBLL = new EncargadoBLL();
                    Encargado nuevo_encargado = new Encargado
                    {
                        Identificacion = identificacion,
                        Nombre = nombre,
                        PrimerApellido = primer_apellido,
                        SegundoApellido = segundo_apellido,
                        IdEncargado = int.Parse(ID),
                        FechaNacimiento = nacimiento,
                        FechaIngreso = ingreso
                    };

                    if (nuevo_EncargadoBLL.Guardar_Encargado(nuevo_encargado))
                    {
                        // Preguntar si se desea agregar un nuevo encargado
                        string caption = "ÉXITO";
                        string mensaje = "Usted ha registrado un nuevo encargado con éxito. ¿Desea agregar otro encargado?";
                        var decision = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (decision == DialogResult.No)
                        {
                            this.Close();
                            Encargados Ventana_Encargados = new Encargados();
                            Ventana_Encargados.Show();
                        }

                        // Limpiar cuadros de texto
                        Nombre_textBox.Clear();
                        Identificacion_Box.Clear();
                        Primer_Apellido_textBox.Clear();
                        Segundo_Apellido_textBox.Clear();
                        ID_Encargado_textBox.Clear();
                        Ingreso_dateTimePicker.ResetText();
                        Nacimiento_dateTimePicker.ResetText();
                    }
                    else
                    {
                        string caption = "ERROR";
                        string mensaje = "Error al guardar el encargado.";
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
    }
}

