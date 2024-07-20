using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Servidor
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());

            //Crear objeto cliente
            Cliente cliente = new Cliente
            {
                IdCliente = 1,
                Identificacion = "123456789",
                Nombre = "Juan",
                PrimerApellido = "Pérez",
                SegundoApellido = "Gómez",
                FechaNacimiento = new DateTime(1980, 1, 1),
                FechaRegistro = DateTime.Now,
                Activo = true
            };
        }
    }
}
