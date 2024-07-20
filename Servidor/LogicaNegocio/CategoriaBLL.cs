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
    public class CategoriaBLL
    {
        CategoriaAD servicio_datos = new CategoriaAD();

        public bool Guardar_Categoria(Categoria categoria_nueva)
        {       
            return servicio_datos.AgregarCategoria(categoria_nueva);
        }

        /*
        public Categoria[] Consultar()
        {
            return ListaCategorias;
        }*/
    }
}
