using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;

namespace ProjektKoncowy.Struktualne.Dekorator
{
    public class Klonowanie : Dekorator
    {
        public Klonowanie(IOrganizm organizm) : base(organizm) { }

        public override void WykonajAkcje()
        {
            Console.WriteLine("Sklonowano wilka");
            base.WyswietlInformacje();
        }
    }
}
