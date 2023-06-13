using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;
using ProjektKoncowy.Fabryki;

namespace ProjektKoncowy.Struktualne.Kompozyt
{
    public abstract class KomponentOrganizmu
    {
        public string Nazwa { get; protected set; }
        public int Zdrowie { get; set; }
        public int Sila { get; set; }
        public int Szybkosc { get; set; }
        public virtual int WyswietlGrupe()
        {
            throw new NotImplementedException();
        }
        public virtual void WyswietlInformacje()
        {
            throw new NotImplementedException();
        }
        public virtual void Dodaj(KomponentOrganizmu komponent)
        {
            throw new NotImplementedException();
        }
        public virtual void Usun(KomponentOrganizmu komponent)
        {
            throw new NotImplementedException();
        }
        public virtual void WykonajAkcje()
        {
            throw new NotImplementedException();
        }
        public virtual void ProbaZjedzenia(FabrykaOrganizmow fabryka, GrupaOrganizmow grupaWilkow, GrupaOrganizmow grupaKrolikow)
        {
            throw new NotImplementedException();
        }
    }
}
