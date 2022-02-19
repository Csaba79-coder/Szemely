using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemely
{
    class Ember
    {
        private int szul_ev;
        private string nev;
        private bool ferfi;
        public Ember(string Nev, int Szul_ev,bool Ferfi)
        {
            nev = Nev;
            szul_ev = Szul_ev;
            ferfi = Ferfi;
        }
        public int Getszul_ev() { return szul_ev; }
        public string Getnev() { return nev; }
        public bool Getferfi() { return ferfi; }

        public int GetEletkor()
        {
            return System.DateTime.Now.Year - szul_ev;
        }
    }
}
