using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKoncowy.Fabryki;

namespace ProjektKoncowy.Fabryki
{
    public class FabrykaOrganizmow
    {
        private Dictionary<string, OrganizmFactory> _fabryki;

        public FabrykaOrganizmow()
        {
            _fabryki = new Dictionary<string, OrganizmFactory>();
            DodajFabryki();
        }
        public Organizm StworzOrganizm(string typOrganizmu)
        {
            if (_fabryki.ContainsKey(typOrganizmu))
            {
                OrganizmFactory fabryka = _fabryki[typOrganizmu];
                return fabryka.StworzOrganizm();
            }

            throw new ArgumentException("Nieznany typ organizmu.");
        }

        private void DodajFabryki()
        {
            _fabryki.Add("Krolik", KrolikFactory.Instance);
            _fabryki.Add("Wilk", WilkFactory.Instance);
        }
    }
}
