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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        private void Boton_Agregar_Sucursal_Click(object sender, EventArgs e)
        {
            Agregar_Sucursal Nueva_Ventana_Agregar_Sucurusales = new Agregar_Sucursal();
            Nueva_Ventana_Agregar_Sucurusales.Show();
            this.Close();
        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            // Obtener nueva instancia
            SucursalBLL sucursalBLL = new SucursalBLL();

            // Crear un ArrayList para mostrar los datos
            List<Sucursal> sucursales = sucursalBLL.ObtenerSucursales();

            //Solicitar que no se generen automaticamente las columnas
            Sucursales_dataGridView.AutoGenerateColumns = false;

            //Establecer la fuente de los datos
            Sucursales_dataGridView.DataSource = sucursales;
            
            // Añadir columnas al DataGridView
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdSucursal", HeaderText = "ID Sucursal" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nombre", HeaderText = "Nombre" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Direccion", HeaderText = "Dirección" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Telefono", HeaderText = "Teléfono" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Activo", HeaderText = "Activo" });

            // Añadir columnas para las propiedades del Encargado
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Encargado_ID", HeaderText = "Encargado_ID" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Encargado_Nombre", HeaderText = "Encargado_Nombre" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Encargado_Primer_Apellido", HeaderText = "Encargado_Primer_Apellido" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Encargado_Segundo_Apellido", HeaderText = "Encargado_Segundo_Apellido" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Encargado_Fecha_Nacimiento", HeaderText = "Encargado_Fecha_Nacimiento" });
            Sucursales_dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Encargado_Fecha_Ingreso", HeaderText = "Encargado_Fecha_Ingreso" });
            

        }
    }
}
