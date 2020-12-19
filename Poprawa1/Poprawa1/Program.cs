using System;

namespace Poprawa1
{
    class Program
    {

        public class Logi
        {


            public string Blad = "Test";
            public string Tekst = "test";


            public Logi(string blad, string tekst)
            {

                Blad = blad;
                Tekst = tekst;

            }



        }


        class Budzik
        {

            DateTime data = DateTime.Now;
            string tytul;

            enum Dzwonek
            {
                budzik1,
                budzik2,
                budzik3,
                budzik4,
                budzik5
            };

            bool powtarza;
            bool wylaczony; // 0 wyl 1 wl



        }



        public static void Godziny(string iloscZespolu, string ryzykoStr, string godzinaStr)
        {
            double godzina = double.Parse(godzinaStr);

            godzina += 8;

            int ilosctEST = Int32.Parse(iloscZespolu);
            double iloscZ = Double.Parse(iloscZespolu);
            for (int i = 0; i < ilosctEST; i++)
            {

                godzina += (iloscZ * 0.05)*100;

            }

            iloscZ = Math.Floor(godzina);

            int ryzyko = Int32.Parse(ryzykoStr);

            if (ryzyko > 0 && ryzyko < 8)
            {

                godzina += godzina * 0.3;

            }
            else if(ryzyko >= 8 && ryzyko <= 10)
            {

                godzina += godzina * 0.5;

            }
            else
            {

                Console.WriteLine("Podano złe ryzyko");

            }

            Console.WriteLine($"Czas na projekt to: {godzina}");

        }


        static void Main(string[] args)
        {

            int iloscLogow = 10;

            Logi[] logi = new Logi[iloscLogow];

            Console.WriteLine("Wpisz godziny projektu:");
            string godzinastr = Console.ReadLine();



            Console.WriteLine("Ile osob liczy zespol:");
            string iloscZespolu = Console.ReadLine();


            Console.WriteLine("Jakie jest ryzyko projektu");
            string ryzykoStr = Console.ReadLine();


            Godziny(iloscZespolu, ryzykoStr, godzinastr);

            //for (int i = 0; i < iloscLogow; i++)
            //{
            //    if (i == 9)
            //    {
            //        logi[i].Blad = "Krytyczny";
            //        logi[i].Tekst = "test";

            //    }
            //    else if (i % 2 == 0)
            //    {

            //        logi[i].Blad = "Ostrzezenie";
            //        logi[i].Tekst = "opis";

            //    }
            //    else
            //    {

            //        logi[i].Blad = "Informacja";
            //        logi[i].Tekst = "info";
            //    }
            //}




        }
    }
}
