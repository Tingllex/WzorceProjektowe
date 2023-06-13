using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;
using ProjektKoncowy.Struktualne.Kompozyt;
using ProjektKoncowy.Struktualne.Dekorator;
using ProjektKoncowy.Fabryki;

namespace ProjektKoncowy
{
    public class Organizm : KomponentOrganizmu, IOrganizm
    {
        public Organizm(int szybkosc, int sila, int zdrowie)
        {
            Szybkosc = szybkosc;
            Sila = sila;
            Zdrowie = zdrowie;
        }

        public override void WyswietlInformacje()
        {
            Console.WriteLine("Organizm: " + this.GetType().Name);
            Console.WriteLine("Szybkość: " + Szybkosc);
            Console.WriteLine("Siła: " + Sila);
            Console.WriteLine("Zdrowie: " + Zdrowie);
        }

        public override void WykonajAkcje()
        {
            Console.WriteLine("Wykonanie podstawowej akcji organizmu.!");
        }

        public override void ProbaZjedzenia(FabrykaOrganizmow fabryka, GrupaOrganizmow grupaWilkow, GrupaOrganizmow grupaKrolikow)
        {
            Random random = new Random();
            KomponentOrganizmu ofiara = null;

            if (grupaKrolikow._organizmy.Count > 0)
            {
                int index = random.Next(grupaKrolikow._organizmy.Count);
                ofiara = grupaKrolikow._organizmy[index];
            }
            
            if (ofiara != null)
            {
                double szansa = 0;
                if (ofiara.Szybkosc + ofiara.Sila > Szybkosc + Sila)
                {
                    szansa = 0.25;
                }
                else szansa = 0.5;
                if (random.NextDouble() <= szansa)
                {
                    Console.WriteLine("\nzdrowie zjadanej ofiary " + ofiara.Zdrowie);
                    Zdrowie += ofiara.Zdrowie;
                    Sila += ofiara.Sila;
                    Szybkosc += ofiara.Szybkosc;
                    grupaKrolikow.Usun(ofiara);
                    Console.WriteLine("Wilk zjada organizm!");
                }
            }
            
            if (Zdrowie > 100)
            {
                Sila = (int)(Sila * 0.5);
                Szybkosc = (int)(Szybkosc * 0.5);
                Zdrowie = (int)(Zdrowie * 0.5);
                var nowyWilk = new Klonowanie(this);
                nowyWilk.WykonajAkcje();
                var freshWilk = fabryka.StworzOrganizm("Wilk");
                grupaWilkow.Dodaj(freshWilk);
            }
        }
    }
}
