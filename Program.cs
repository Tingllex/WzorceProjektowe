using System;
using ProjektKoncowy.Organizmy;
using ProjektKoncowy.Fabryki;
using ProjektKoncowy.Struktualne.Dekorator;
using ProjektKoncowy.Operacyjne.Strategia;
using ProjektKoncowy.Operacyjne.Obserwator;
using System.Collections.Generic;

namespace ProjektKoncowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontekst kontekst = new();
            kontekst.SetStrategia(new Strategia());
            var ustawienia = kontekst.Ustawienia();

            FabrykaOrganizmow fabryka = new FabrykaOrganizmow();

            Organizm[] kroliki = new Organizm[ustawienia["ilosc krolikow"]];
            Organizm[] wilki = new Organizm[ustawienia["ilosc wilkow"]];

            GrupaOrganizmow grupaKrolikow = new GrupaOrganizmow("GrupaKrolikow");
            GrupaOrganizmow grupaWilkow = new GrupaOrganizmow("GrupaWilkow");

            for (int i = 0; i < ustawienia["ilosc krolikow"]; i++)
            {
                Organizm krolik = fabryka.StworzOrganizm("Krolik");
                kroliki[i] = krolik;
                grupaKrolikow.Dodaj(krolik);
                //kroliki[i].WyswietlInformacje();
            }
            
            for (int i = 0; i < ustawienia["ilosc wilkow"]; i++)
            {
                Organizm wilk = fabryka.StworzOrganizm("Wilk");
                wilki[i] = wilk;
                grupaWilkow.Dodaj(wilk);
                //wilki[i].WyswietlInformacje();
            }

            Obserwowany[] obserwowaneOrganizmy = new Obserwowany[ustawienia["ilosc wilkow"] + ustawienia["ilosc krolikow"]];
            Obserwator monitorCech = new Obserwator();

            for (int i = 0; i < ustawienia["ilosc wilkow"]; i++)
            {
                Obserwowany obserwowanyOrganizm = new(wilki[i]);
                obserwowanyOrganizm.DodajObserwatora(monitorCech);
                obserwowaneOrganizmy[i] = obserwowanyOrganizm;
            }
            for (int i = 0; i < ustawienia["ilosc krolikow"]; i++)
            {
                Obserwowany obserwowanyOrganizm = new(kroliki[i]);
                obserwowanyOrganizm.DodajObserwatora(monitorCech);
                obserwowaneOrganizmy[ustawienia["ilosc wilkow"] + i] = obserwowanyOrganizm;
            }
            Console.WriteLine("");
            foreach(var krolik in kroliki)
            {
                krolik.WyswietlInformacje();
            }
            Console.WriteLine("");
            foreach (var wilk in wilki)
            {
                wilk.WyswietlInformacje();
            }

            for (int i = 1; i < ustawienia["ilosc dni"] + 1; i++)
            {
                Random random = new Random();
                
                if (grupaKrolikow._organizmy.Count == 0)
                {
                    Console.WriteLine("Wszystkie kroliki zostały zjedzone w ciagu {0} dni", i);
                    Console.WriteLine("ZWYCIESTWO WILKOW!");
                    break;
                }

                Console.WriteLine("\nDzien {0}", i);
                Console.WriteLine("Codzienne dodawanie statystyk +10 ({0}% szans)\n", (int)(100 * (1 - Math.Pow(0.913, i))));
                foreach (var item in obserwowaneOrganizmy)
                {
                    if (random.Next(1, 101) <= (int)(100 * (1 - Math.Pow(0.913, i))))
                    {
                        item.ZmienCechy(10, 10, 10);
                    }
                }
                grupaWilkow.ProbaZjedzenia(fabryka, grupaWilkow, grupaKrolikow);
                Console.WriteLine("\nIlosc pozostalych krolikow: {0}, wilkow: {1}", grupaKrolikow.WyswietlGrupe(), grupaWilkow.WyswietlGrupe());
            }
            if (grupaKrolikow.WyswietlGrupe() > 0 )
            {
                Console.WriteLine("ZWYCIESTWO KROLIKOW!");
            }
        }
    }
}
