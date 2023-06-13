using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;

namespace ProjektKoncowy.Fabryki
{
    public class KrolikFactory : OrganizmFactory
    {
        private static volatile KrolikFactory _instance;
        private static readonly object _syncLock = new object();

        private KrolikFactory() { }

        public static KrolikFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new KrolikFactory();
                        }
                    }
                }
                return _instance;
            }
        }
        public override Organizm StworzOrganizm()
        {
            Random random = new();
            int szybkosc = random.Next(50, 101);
            int sila = random.Next(1, 51);
            int zdrowie = random.Next(1, 101);
            return new Krolik(szybkosc, sila, zdrowie);
        }
    }
}
