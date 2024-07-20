using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    //Esta clase es referencia del video "Sesión Virtual 1 Tutor: Johan Acosta Ibañez"
    public class EncargadoBLL
    {
        EncargadoAD servicio_datos = new EncargadoAD();

        public bool Guardar_Encargado(Encargado pencargado)
        {
            return servicio_datos.AgregarEncargado(pencargado);
        }
    }
}
