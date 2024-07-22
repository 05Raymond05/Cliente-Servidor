using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Formularios;
using LogicaNegocio;
using Entidades;

namespace Programa.Formularios
{
    public partial class Encargados : Form
    {
        public Encargados()
        {
            InitializeComponent();
        }

        private void Boton_Agregar_Encargado_Click(object sender, EventArgs e)
        {
            Agregar_Encargado Ventana_Agregar_Encargado = new Agregar_Encargado();
            Ventana_Agregar_Encargado.Show();
            this.Close();
        }

        private void Encargados_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener nueva instancia
                EncargadoBLL encargadoBLL = new EncargadoBLL();

                // Obtener lista de encargados
                List<Encargado> listaEncargados = encargadoBLL.ConsultarEncargados();

                // Verificar si la lista está vacía
                if (listaEncargados.Count == 0)
                {
                    throw new Exception();
                }

                // Asignar la lista de encargados al DataGridView
                Encargado_dataGridView.DataSource = listaEncargados;
            }
            catch (Exception)
            {
                string caption = "ERROR";
                string mensaje = "No hay ningún encargado registrado. Por favor, registre al menos uno antes de continuar.";
                MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}

