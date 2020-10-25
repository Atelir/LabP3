using System;

namespace Zajecia4
{
    class Program
    {

        static void Main(string[] args)
        {

            Produkt nowyProdukt = new Produkt("Chleb", 10, "165155")
            {
                Stan = 25
            };

            var innyProdukt = new Produkt("Bułka", 0.5m, "126515");
            innyProdukt.Stan = 10;

            Tranzakcja tranzakcja = new Tranzakcja
            {
                Czas = DateTime.Now,
                Kwota = 20
            };

            Console.WriteLine(nowyProdukt.Cena);
            nowyProdukt.Cena = 1;
            Console.WriteLine(nowyProdukt.Cena);
            nowyProdukt.Sprzedaj();
            Console.WriteLine(nowyProdukt.Stan);


        }


    }


}
