using System;
using System.Globalization;

namespace Z2
{
    class Program
    {
        enum Wyliczenie
        {
            Wariant1,
            Wariant2,
            Wariant3
        }

        [Flags]
        enum RGB
        {
            Czarny = 0,
            Czerwony = 1, //100
            Zielony = 2, //010
            Niebieski = 4 //001
        }



        static void Funkcja(int liczba)
        {

            Console.WriteLine("F: " + liczba);
            liczba = 200;
            Console.WriteLine("F: " + liczba);

        }

        static void FunkcjaTab(int[] tablica) //tablice dziają jak referencje 
        {

            Console.WriteLine("F: " + tablica[0]);
            tablica[0] = 200;
            Console.WriteLine("F: " + tablica[0]);

        }

        static void Main(string[] args)
        {
            #region
            // Typy proste
            int zmienna = 100;
            float liczbaZmiennoprzecinkowa = 2.5f;
            double liczbaZmiennoprzecinkowa2 = 2.5;
            char litera = 'A';
            bool warunek = true;
            string slowo = "100";

            //Console.WriteLine("M: " + zmienna);
            //Funkcja(zmienna);
            //Console.WriteLine("M: " + zmienna);

            //Typy referencjyjne
            //clasy, tablice 
            int[] tablica = { 1, 2, 3 };

            //Console.WriteLine("M: " + tablica[0]);
            //FunkcjaTab(tablica);
            //Console.WriteLine("M: " + tablica[0]);

            //Skrót to console.write - cw oraz 2xtab

            //Referencja to ref przykład (ref int liczba)
            #endregion
            #region
            /*
             * 
             *   Console.WriteLine("Podaj liczbe: ");
             *  string odpowiedz = Console.ReadLine(); //Funkcja zwracająca string
             *   Console.WriteLine("Wypisales liczbe " + odpowiedz); // $"Wpisales slowo {odpowiedz} !"
             *   try
             *   {
             *       //var liczbaOdUzytkownia = Convert.ToInt32(odpowiedz);
             *       //var liczbaOdUzytkownia = int.Parse(odpowiedz); //Parse konwertuje stringi
             *       
             *        int liczbaOdUzytkownia;
             *        bool czySieUdalo = int.TryParse(odpowiedz, out liczbaOdUzytkownia); potem if
             *        
             *       int wynik = liczbaOdUzytkownia + 100;
             *       Console.WriteLine("Twoja powiekszona o 100 liczba to " + wynik);
             *   }
             *   catch (Exception e)
             *   {
             *       Console.WriteLine("Nie udało się przekonwertować liczby");
             *       Console.WriteLine(e.Message);
             *   }
             */

            //float wynik = 10 / 3.0f;
            //Console.WriteLine(wynik);
            #endregion
            //Enum
            //Wyliczenie wyliczenie = Wyliczenie.Wariant1;
            //Wyliczenie wyliczenie1 = (Wyliczenie)1;
            //Wyliczenie wyliczenie2 = (Wyliczenie)Enum.Parse(typeof(Wyliczenie), "Wariant3");
            //Console.WriteLine(wyliczenie);
            //Console.WriteLine(wyliczenie1);
            //Console.WriteLine(wyliczenie2);
            // *

            RGB kolor = RGB.Czerwony;
            kolor |= RGB.Niebieski;
            kolor |= RGB.Zielony;

            switch (kolor)
            {
                case RGB.Czarny:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case RGB.Czerwony:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case RGB.Zielony:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case RGB.Niebieski:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case RGB.Czerwony | RGB.Niebieski:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case RGB.Czerwony | RGB.Niebieski | RGB.Zielony:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Koniec programu");

            var zmiennaVar = 25; //Zmienna musi być ustalona podczas tworzenia - zastępuje wszystkie powyżej

        }
    }
}
