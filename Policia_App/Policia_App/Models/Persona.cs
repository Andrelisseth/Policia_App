using System;
using System.Collections.Generic;

namespace Policia_App.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdPersona { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
