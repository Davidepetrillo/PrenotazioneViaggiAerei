using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrenotazioneViaggiAerei
{
    internal class Tratta
    {
        public Aeroporto AeroportoPartenza { get; set; }
        public Aeroporto AeroportoArrivo { get; set; }

        public Tratta(Aeroporto areportoPartenza, Aeroporto aeroportoArrivo)
        {
            this.AeroportoPartenza = areportoPartenza;
            this.AeroportoArrivo = aeroportoArrivo;
        }
    }
}
