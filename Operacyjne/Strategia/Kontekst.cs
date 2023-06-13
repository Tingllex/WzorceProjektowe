using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy.Operacyjne.Strategia
{
    public class Kontekst
    {
        private IStrategia _strategia;
        private static Dictionary<string, int> _opcje = new();
        public Kontekst() { }

        public Kontekst(IStrategia strategia)
        {
            _strategia = strategia;
        }

        public void SetStrategia(IStrategia strategia)
        {
            _strategia = strategia;
        }

        public Dictionary<string, int> Ustawienia()
        {
            Console.WriteLine("Kontekst: Przypisanie ustawien symulacji przy użyciu strategii:");

            _opcje = _strategia.OpcjeSymulacji(_opcje);
            foreach(var opcja in _opcje)
            {
                Console.WriteLine("{0} = {1}", opcja.Key, opcja.Value);
            }
            return _opcje;
        }
    }
}
