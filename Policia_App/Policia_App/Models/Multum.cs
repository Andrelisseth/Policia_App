using System;
using System.Collections.Generic;

namespace Policia_App.Models
{
    public partial class Multum
    {
        public int IdMulta { get; set; }
        public int IdVehiculo { get; set; }
        public int IdPolicia { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Policium IdPoliciaNavigation { get; set; } = null!;
        public virtual Vehiculo IdVehiculoNavigation { get; set; } = null!;
    }
}
