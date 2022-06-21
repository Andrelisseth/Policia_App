using System;
using System.Collections.Generic;

namespace Policia_App.Models
{
    public partial class Policium
    {
        public Policium()
        {
            Multa = new HashSet<Multum>();
        }

        public int IdPolicia { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Oni { get; set; }

        public virtual ICollection<Multum> Multa { get; set; }
    }
}
