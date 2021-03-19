using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneTask
{
    enum Livello //inserisco i livelli di importanza delle attività
    {
        B,
        M,
        A
    }
    enum Formato
    {
        Plain,
        CSV
    }

    class Attività
    {
        private static int _ID;
        public int ID { get; }
        public string Descrizione { get;}
        public DateTime Scadenza { get; }
        public char Livello { get; }
       
        public string OttieniElenco(Formato formato)
        {
            switch (formato)
            {
                case Formato.Plain:
                    return $"Attività: {ID}, Descrizione: {Descrizione}, Scadenza: {Scadenza}, Livello: {Livello}";
                case Formato.CSV:
                    return $"{ID};\"{Descrizione}; {Scadenza}; {Livello}";
                default:
                    throw new NotImplementedException();
            }
                
        }

        public Attività(string descrizione, DateTime scadenza, char livello) //costruttore
        {
            Descrizione = descrizione;
            Scadenza = scadenza;
            Livello = livello;
            ID = ++_ID;

        }
    }
}
