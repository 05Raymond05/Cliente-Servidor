using AccesoDatos;
using Entidades;
using System.Collections.Generic;

//Esta clase es referencia del video "Sesión Virtual 1 Tutor: Johan Acosta Ibañez"

namespace LogicaNegocio
{
    public class EncargadoBLL
    {
        EncargadoAD servicio_datos = new EncargadoAD();

        public bool Guardar_Encargado(Encargado pencargado)
        {
            return servicio_datos.AgregarEncargado(pencargado);
        }

        public List<Encargado> ConsultarEncargados()
        {
            return servicio_datos.ObtenerEncargados();
        }
    }
}
