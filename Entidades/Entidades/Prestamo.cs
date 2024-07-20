using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdCliente { get; set; }
        public int IdSucursal { get; set; }
        public int IdPelicula { get; set; }
        public bool Devolucion { get; set; }
        public DateTime FechaPrestamo { get; set; }
    }
}
