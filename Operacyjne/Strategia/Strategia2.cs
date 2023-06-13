using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy.Operacyjne.Strategia
{
    public class Strategia2 : IStrategia
    {
        public Dictionary<string, int> OpcjeSymulacji(Dictionary<string, int> _opcje)
        {
            //Console.WriteLine("Ustawienie opcji z wykorzystaniem strategii.");
            _opcje["ilosc wilkow"] = 1;
            _opcje["ilosc krolikow"] = 5;
            _opcje["ilosc dni"] = 10;

            return _opcje;
        }
    }
}
