using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Implementacion
{
    public class Equipos
    {
        public int NumeroDeJugadores { get; set; }
        public string DirectorTecino { get; set; }

        private ITipoDeJuego _tipoDeJuego;

        public void SetTipoDeJuego(ITipoDeJuego tipoDeJuego)
        {
            _tipoDeJuego = tipoDeJuego;
        }

        public void MostrarEstrategia()
        {
            _tipoDeJuego.Jugar();
        }
    }
}
