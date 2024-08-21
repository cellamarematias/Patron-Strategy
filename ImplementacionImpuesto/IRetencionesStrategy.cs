using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.ImplementacionImpuesto
{
    public interface IRetencionesStrategy
    {
        public void Calcular(decimal importe);
    }
}
