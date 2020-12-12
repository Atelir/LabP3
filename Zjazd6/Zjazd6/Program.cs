using System;
using System.Collections.Generic;
using System.Linq;
namespace Zjazd6
{

    class Program
    {


        public Dictionary<Produkt, int> Magazyn = new Dictionary<Produkt, int>()
        {
            { Dane.Produkty[0], 500 },
            { Dane.Produkty[1], 100 },
            { Dane.Produkty[2], 50 },
            { Dane.Produkty[3], 1000 },
            { Dane.Produkty[4], 750 }
        };

        public static Zamowienie[] Zamowienia = new[]
        {

            new Zamowienie(Dane.Sklepy[0], Enumerable.Repeat(Dane.Produkty[0], 30).ToList()),
            new Zamowienie(Dane.Sklepy[1], Enumerable.Repeat(Dane.Produkty[2], 10).ToList()),
            new Zamowienie(Dane.Sklepy[2], Enumerable.Repeat(Dane.Produkty[4], 45).ToList())

        };


        static void Main(string[] args)
        {

            foreach (var item in Zamowienia)
            {

                Console.WriteLine($"{item.Sklep.Nazwa} {item.Produkty.Sum(x=> x.Cena)}");

                var grupa = item.Produkty.GroupBy(x => x.Nazwa);

            }
        }

    }









}