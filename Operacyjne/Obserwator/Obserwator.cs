using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;

namespace ProjektKoncowy.Operacyjne.Obserwator
{
    public class Obserwator : IObserwator
    {
        public void Aktualizuj(Organizm organizm)
        {
            Console.WriteLine("Monitor: Zmieniono cechy organizmu. Szybkosc={0}, Sila={1}, Zdrowie={2}", organizm.Szybkosc, organizm.Sila, organizm.Zdrowie);
        }
    }
}
