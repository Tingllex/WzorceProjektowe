using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy.Operacyjne.Strategia
{
    public interface IStrategia
    {
        Dictionary<string, int> OpcjeSymulacji(Dictionary<string, int> opcje);
    }
}
