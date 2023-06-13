using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;
using ProjektKoncowy.Fabryki;

namespace ProjektKoncowy.Struktualne.Dekorator
{
    public abstract class Dekorator : IOrganizm
    {
        protected IOrganizm _organizm;
        public Dekorator(IOrganizm organizm)
        {
            _organizm = organizm;
        }
        public virtual void WykonajAkcje()
        {
            _organizm.WykonajAkcje();
        }
        public virtual void WyswietlInformacje()
        {
            _organizm.WyswietlInformacje();
        }
        public virtual void ProbaZjedzenia(FabrykaOrganizmow fabryka, GrupaOrganizmow grupaWilkow, GrupaOrganizmow grupaKrolikow)
        {
            _organizm.ProbaZjedzenia(fabryka, grupaWilkow, grupaKrolikow);
        }
    }
}
