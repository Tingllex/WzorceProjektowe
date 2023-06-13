using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Fabryki;

namespace ProjektKoncowy.Organizmy
{
    public interface IOrganizm
    {
        void WykonajAkcje();
        void WyswietlInformacje();
        void ProbaZjedzenia(FabrykaOrganizmow fabryka, GrupaOrganizmow grupaWilkow, GrupaOrganizmow grupaKrolikow);
    }
}
