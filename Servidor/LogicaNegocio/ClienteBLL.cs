using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    //Esta clase es referencia del video "Sesión Virtual 1 Tutor: Johan Acosta Ibañez"
    public class ClienteBLL
    {
        ClienteAD servicio_datos = new ClienteAD();

        public bool Guardar_Cliente(Cliente cliente_nuevo)
        {
            return servicio_datos.AgregarCliente(cliente_nuevo);
        }

    }
}
