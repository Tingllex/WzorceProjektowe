using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;
using ProjektKoncowy.Struktualne.Kompozyt;
using ProjektKoncowy.Fabryki;

namespace ProjektKoncowy.Organizmy
{
    public class GrupaOrganizmow : KomponentOrganizmu, IOrganizm
    {
        public List<KomponentOrganizmu> _organizmy;

        public GrupaOrganizmow(string nazwa)
        {
            Nazwa = nazwa;
            _organizmy = new List<KomponentOrganizmu>();
        }
        public override int WyswietlGrupe()
        {
            return _organizmy.Count;
        }

        public override void Dodaj(KomponentOrganizmu komponent)
        {
            _organizmy.Add(komponent);
        }

        public override void Usun(KomponentOrganizmu komponent)
        {
            _organizmy.Remove(komponent);
        }

        public override void WykonajAkcje()
        {
            Console.WriteLine("Wykonanie akcji grupy organizmów: " + Nazwa);
            foreach (var organizm in _organizmy)
            {
                organizm.WykonajAkcje();
            }
        }

        public override void ProbaZjedzenia(FabrykaOrganizmow fabryka, GrupaOrganizmow grupaWilkow, GrupaOrganizmow grupaKrolikow)
        {
            var kopiaOrganizmow = new List<KomponentOrganizmu>(_organizmy);

            foreach (var _organizm in kopiaOrganizmow)
            {
                _organizm.ProbaZjedzenia(fabryka, grupaWilkow, grupaKrolikow);
            }
        }

        public override void WyswietlInformacje()
        {
            foreach (var organizm in _organizmy)
            {
                organizm.WyswietlInformacje();
            }
        }
    }
}
