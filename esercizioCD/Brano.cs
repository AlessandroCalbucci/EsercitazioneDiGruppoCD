using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioCD
{
    class Brano
    {
        private string _titolo;
        private string _autore;
        private int _durataInSecondi;

        public string Titolo
        {
            get => _titolo;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Inserire titolo brano valido");

                _titolo = value;
            }
        }

        public string Autore
        {
            get => _autore;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Inserire nome autore valido");

                _autore = value;
            }
        }

        public int DurataInSecondi
        {
            get => _durataInSecondi;
            set
            {
                if (value < 0)
                    throw new Exception("Inserire durata in secondi valida");

                _durataInSecondi = value;
            }
        }

        public Brano(string titolo, string autore, int durataInSecondi)
        {
            Titolo = titolo;
            Autore = autore;
            DurataInSecondi = durataInSecondi;
        }

        public bool ShortSong(int durataBool)
        {
            bool risposta = false;

            if (durataBool <= DurataInSecondi)
                risposta = true;

            return risposta;
        }

        public override string ToString()
        {
            return "Titolo: " + Titolo + "\n" + "Autore: " + Autore + "\n" + "Durata brano (in secondi): " + DurataInSecondi;
        }
    }
}
