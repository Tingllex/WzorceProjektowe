using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;

namespace ProjektKoncowy.Operacyjne.Obserwator
{
    public class Obserwowany
    {
        private List<IObserwator> _obserwatorzy = new List<IObserwator>();
        private Organizm _organizm;
        public Obserwowany(Organizm organizm)
        {
            _organizm = organizm;
        }
        public void DodajObserwatora(IObserwator obserwator)
        {
            _obserwatorzy.Add(obserwator);
        }

        public void UsunObserwatora(IObserwator obserwator)
        {
            _obserwatorzy.Remove(obserwator);
        }

        public void PowiadomObserwatorow()
        {
            foreach (IObserwator obserwator in _obserwatorzy)
            {
                obserwator.Aktualizuj(_organizm);
            }
        }
        public void ZmienCechy(int dodajSzybkosc, int dodajSil, int dodajZdrowie)
        {
            _organizm.Szybkosc += dodajSzybkosc;
            _organizm.Sila += dodajSil;
            _organizm.Zdrowie += dodajZdrowie;

            PowiadomObserwatorow();
        }
    }
}
