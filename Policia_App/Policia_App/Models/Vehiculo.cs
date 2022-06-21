using System;
using System.Collections.Generic;

namespace Policia_App.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Multa = new HashSet<Multum>();
        }

        public int IdVehiculo { get; set; }
        public int IdPersona { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual ICollection<Multum> Multa { get; set; }
    }
}
