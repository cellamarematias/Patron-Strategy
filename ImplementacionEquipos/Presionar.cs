using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Implementacion
{
    public class Presionar : ITipoDeJuego
    {
        public void Jugar()
        {
            Console.WriteLine("Presionar arriba");
        }
    }
}
