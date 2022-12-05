using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek_form
{
    internal class jatek
    {
        string nev;
        string jatekido;
        string studio;
        double ertekeles;

        public string Nev { get => nev; set => nev = value; }
        public string Jatekido { get => jatekido; set => jatekido = value; }
        public string Studio { get => studio; set => studio = value; }
        public double Ertekeles { get => ertekeles; set => ertekeles = value; }
        public jatek(string nev, string jatekido, string studio, double ertekeles)
        {
            Nev = nev;
            Jatekido = jatekido;
            Studio = studio;
            Ertekeles = ertekeles;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
