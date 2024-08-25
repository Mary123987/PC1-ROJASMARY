using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC1_ROJASMARY.Models
{
    public class Inversion
    {
         public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public List<string>? Instrumentos { get; set; }
        public decimal MontoAbonar { get; set; }

        public decimal Comision { get { return MontoAbonar <= 300 ? 1 : 3; } }
        public decimal IGV { get { return (MontoAbonar + Comision) * 0.18m; } }
        public decimal TotalPagar { get { return MontoAbonar + Comision + IGV; } }
    }
}