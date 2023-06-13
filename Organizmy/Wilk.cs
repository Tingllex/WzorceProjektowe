using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Struktualne.Dekorator;

namespace ProjektKoncowy.Organizmy
{
    public class Wilk : Organizm
    {
        public Wilk(int szybkosc, int sila, int zdrowie) : base(szybkosc, sila, zdrowie) { }        
    }
}
