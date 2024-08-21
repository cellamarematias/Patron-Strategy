using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.ImplementacionImpuesto
{
    public class RetencionIvaStrategy : IRetencionesStrategy
    {
        public void Calcular(decimal importe)
        {
            Console.WriteLine(importe * 0.10m);
        }
    }
}
