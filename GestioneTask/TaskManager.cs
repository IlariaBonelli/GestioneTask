using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneTask
{
    class TaskManager
    {
        private Dictionary<int, Attività> _attività = new Dictionary<int, Attività>();

        public string OttieniElenco(Formato formato)
        {
            string s = "";
            foreach (Attività t in _attività.Values)
                s += t.OttieniElenco(formato) + '\n';
            return s;
        }

        public int ElencoAttività
        {
            get
            {
                int a = 0;
                foreach (Attività t in _attività.Values)
                    a += t.Elenco;
                return a;
            }
        }

        public bool Esiste(int id)
        {
            return _attività.ContainsKey(id);
        }

        public Attività CreaTask(string descrizione, DateTime scadenza, char livello)
        {
            Attività t = new Attività(descrizione, scadenza, livello);

            _attività.Add(t.ID, t);

            return t;
        }

        public int OttieniElenco(int id)
        {
            return _attività[id].Elenco;
        }
    }
}
