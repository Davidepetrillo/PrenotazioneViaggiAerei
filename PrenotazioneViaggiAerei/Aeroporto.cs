using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrenotazioneViaggiAerei
{
    internal class Aeroporto
    {
        public string LuogoDellAeroporto { get; set; }

        public Aeroporto (string luogoDellAeroporto)
        {
            if (luogoDellAeroporto != "Napoli" && luogoDellAeroporto != "Roma" && luogoDellAeroporto != "Milano"
                && luogoDellAeroporto != "Parigi" && luogoDellAeroporto != "Madrid" && luogoDellAeroporto != "Londra"
                && luogoDellAeroporto != "Berlino" && luogoDellAeroporto != "Mosca" && luogoDellAeroporto != "New York"
                && luogoDellAeroporto != "Pechino" && luogoDellAeroporto != "Sydney" && luogoDellAeroporto != "Tokyo")
            {
                throw new Exception("Mi dispiace ma la nostra compagnia non vola nell'aeroporto da lei selezionato");
            }

            this.LuogoDellAeroporto = luogoDellAeroporto;

        }

    }
}
