using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioCD
{
    public class CD
    {
        private string _titolo,
            _autore;
        private List<Brano> _brani;

        public CD(string titolo, string autore):this(titolo, autore, new List<Brano>())
        {
        }

        public CD(string titolo, string autore, List<Brano> brani)
        {
            Titolo = titolo;
            Autore = autore;
            Brani = brani;
        }
        public List<Brano> Brani
        {
            get => _brani;
            set => _brani = value;
        }
        public string Titolo {
            get => _titolo;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Titolo non valido");
                _titolo = value;
            }
            
        }
        public int Durata
        {
            get
            {
                int i = 0;
                foreach(Brano b in Brani)
                {
                    i += b.Durata;
                }
                return i;
            }
        }
        public string Autore {
            get => _autore;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Autore non valido");
                _autore = value;
            }
        }
        public override string ToString()
        {
            string s = "Brani presenti: \n";
            foreach (Brano b in Brani)
            {
                s += "- " + b.Titolo + "\n";
            }
            return s;
        }
    }
}
