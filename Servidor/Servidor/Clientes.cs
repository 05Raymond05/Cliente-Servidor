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
using System.Collections;
using Entidades;
using System.Xml.Linq;

namespace Programa.Formularios
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            LoadData();
        }


        private void Boton_Agregar_Cliente_Click(object sender, EventArgs e)
        {

            Agregar_Cliente Ventana_Agregar_Cliente = new Agregar_Cliente();
            Ventana_Agregar_Cliente.Show();
            this.Close();            

        }

        private void LoadData()
        {
  
            /*
            // Obtener nueva instancia
            ClienteBLL clienteBLL = new ClienteBLL();

            // Crear un ArrayList para mostrar los datos
            Cliente[] clientes = clienteBLL.Consultar();
            Cliente_dataGridView.DataSource = clientes;
            */
        }

        private void Cliente_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_label_Click(object sender, EventArgs e)
        {

        }
    }
}
