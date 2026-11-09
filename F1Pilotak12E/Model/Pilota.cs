using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Pilotak12E.Model
{
    internal class Pilota
    {

        private string _nev;
        private string _szuletesiDatum;
        private string _nemzetiseg;
        private string _rajtszam;

        public Pilota()
        {
        }

        public Pilota(string nev, string szuletesiDatum, string nemzetiseg, string rajtszam)
        {
            Nev = nev;
            SzuletesiDatum = szuletesiDatum;
            Nemzetiseg = nemzetiseg;
            Rajtszam = rajtszam;
        }

        public string Nev
        {
            get => _nev;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("A név nem lehet üres");
                }
                _nev = value;
            }
        }
        public string SzuletesiDatum { get => _szuletesiDatum; set => _szuletesiDatum = value; }
        public string Nemzetiseg { get => _nemzetiseg; set => _nemzetiseg = value; }
        public string Rajtszam { get => _rajtszam; set
            {
                if (string.IsNullOrWhiteSpace(value) || value == "")
                {
                    _rajtszam = "999";
                }
            }
        
        }

        public override string ToString()
        {
            return $"Pilóta neve: {Nev}, ({SzuletesiDatum})-({Nemzetiseg}), Rajtszám: {Rajtszam}";
        }
    }
}
