using Programa.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Boton_Categoria_Click(object sender, EventArgs e)
        {
            Categorias ventana = new Categorias();
            ventana.Show();
        }

        private void Boton_Clientes_Click(object sender, EventArgs e)
        {
            Clientes ventana = new Clientes();
            ventana.Show();

        }
    }
}
