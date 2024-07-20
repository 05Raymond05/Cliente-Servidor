using System;

namespace Entidades
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
