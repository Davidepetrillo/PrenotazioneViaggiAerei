using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrenotazioneViaggiAerei
{
    internal class PrenotazioneVolo
    {
        public string CodiceVolo;
        public Cliente ClienteX { get; set; }
        public string AeroportoPartenza { get; set; }
        public string AeroportoArrivo { get; set; }
        public DateTime DataPartenza { get; set; }
        public int numeroPostiDisponibili { get; set; }
        public int NumeroPostiPrenotati { get; set; }


        public long GetCodice()
        {
            Random random = new Random();
            long codice = random.Next(1000000000);
            return codice;
        }
        public PrenotazioneVolo(string codiceVolo, Cliente clienteX, string aeroportoPartenza, string aeroportoArrivo, DateTime dataPartenza, int numeroPostiPrenotati)
        {
            this.CodiceVolo = codiceVolo; 
            this.ClienteX = clienteX;

            this.AeroportoPartenza = aeroportoPartenza;

            this.AeroportoArrivo = aeroportoArrivo;

            if (DataPartenza < DateTime.Now)
            {
                throw new InvalidDataException("La data dell'appuntamento non può essere nel passato");
            }

            this.DataPartenza = dataPartenza;

            this.numeroPostiDisponibili = numeroPostiDisponibili;

            if(numeroPostiPrenotati > numeroPostiDisponibili)
            {
                throw new Exception("Non è possibile prenotare il numero di posti da lei selezionato per questo volo");
            }
            this.NumeroPostiPrenotati = numeroPostiPrenotati
        }

    }
}
