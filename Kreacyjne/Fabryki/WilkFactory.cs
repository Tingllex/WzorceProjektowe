using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Organizmy;

namespace ProjektKoncowy.Fabryki
{
    public class WilkFactory : OrganizmFactory
    {
        private static volatile WilkFactory _instance;
        private static readonly object _syncLock = new object();

        private WilkFactory() { }

        public static WilkFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new WilkFactory();
                        }
                    }
                }
                return _instance;
            }
        }
        public override Organizm StworzOrganizm()
        {
            Random random = new();
            int szybkosc = random.Next(1, 51);
            int sila = random.Next(50, 101);
            int zdrowie = random.Next(1, 101);
            return new Wilk(szybkosc, sila, zdrowie);
        }
    }
}
