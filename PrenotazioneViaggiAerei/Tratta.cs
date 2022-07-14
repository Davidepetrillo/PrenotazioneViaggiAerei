﻿using System;
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
        public int durataTratta { get; set; }
        public double CostoTratta { get; set; }

        public Tratta(Aeroporto areportoPartenza, Aeroporto aeroportoArrivo)
        {
            this.AeroportoPartenza = areportoPartenza;
            this.AeroportoArrivo = aeroportoArrivo;
            if ((AeroportoPartenza.LuogoDellAeroporto == "Napoli") && (aeroportoArrivo.LuogoDellAeroporto == "Roma"))
            {
                this.CostoTratta = 29.99;
                this.durataTratta = 60;
            } else if ((AeroportoPartenza.LuogoDellAeroporto == "Napoli") && (aeroportoArrivo.LuogoDellAeroporto == "Milano"))
            {
                this.CostoTratta = 39.99;
                this.durataTratta = 90;
            }
            else if ((AeroportoPartenza.LuogoDellAeroporto == "Roma") && (aeroportoArrivo.LuogoDellAeroporto == "Napoli"))
            {
                this.CostoTratta = 24.99;
                this.durataTratta = 55;
            }
            else if ((AeroportoPartenza.LuogoDellAeroporto == "Roma") && (aeroportoArrivo.LuogoDellAeroporto == "Milano"))
            {
                this.CostoTratta = 19.99;
                this.durataTratta = 50;
            }
            else if ((AeroportoPartenza.LuogoDellAeroporto == "Milano") && (aeroportoArrivo.LuogoDellAeroporto == "Roma"))
            {
                this.CostoTratta = 14.99;
                this.durataTratta = 50;
            }
            else if ((AeroportoPartenza.LuogoDellAeroporto == "Milano") && (aeroportoArrivo.LuogoDellAeroporto == "Napoli"))
            {
                this.CostoTratta = 24.99;
                this.durataTratta = 85;
            }
        }
    }
}
