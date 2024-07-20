using System;

namespace Entidades
{
    public class Pelicula : Categoria
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public int AnoLanzamiento { get; set; }
        public string Idioma { get; set; }

    }
}
