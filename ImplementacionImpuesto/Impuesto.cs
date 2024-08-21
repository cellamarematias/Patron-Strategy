using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.ImplementacionImpuesto
{
    public class Impuesto
    {
        public int TipoImpuesto { get; set; }
        public decimal ImporteNeto { get; set; }
        public decimal ImporteRetencion { get; set; }
        public decimal ImporteBruto { get; set; }

    }
}
