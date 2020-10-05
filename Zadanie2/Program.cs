using System;
using System.Diagnostics;

namespace Zadanie2
{
    class Program
    {

        public enum Wyniki
        {
            Mz0,
            Mz1,
            Mz2
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe a:");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj liczbe b:");
            string b = Console.ReadLine();
            Console.WriteLine("Podaj liczbe c:");
            string c = Console.ReadLine();
            bool sprawdzA = int.TryParse(a, out _);
            bool sprawdzB = int.TryParse(b, out _);
            bool sprawdzC = int.TryParse(c, out _);
            if (sprawdzA == true && sprawdzB == true && sprawdzC == true)
            {

                int LiczbaA = int.Parse(a);
                int LiczbaB = int.Parse(b);
                int LiczbaC = int.Parse(c);

                int delta = (int)Math.Pow(LiczbaB, 2) - 4 * (LiczbaA * LiczbaC);

                Console.WriteLine($"Twoja delta wynosi: {delta}");

                

                Wyniki wyniki = Wyniki.Mz0;
                wyniki |= Wyniki.Mz1;
                wyniki |= Wyniki.Mz2;

                if (delta < 0)
                {
                    wyniki = Wyniki.Mz0;

                }
                else if(delta == 0)
                {

                    wyniki = Wyniki.Mz1;

                }
                else
                {

                    wyniki = Wyniki.Mz2;

                }


                switch (wyniki)
                {
                    case Wyniki.Mz0:
                        Console.WriteLine("Jest 0 miejsc zerowych");
                        break;
                    case Wyniki.Mz1:
                        Console.WriteLine("Jest 1 miejsce zerowe");
                        break;
                    case Wyniki.Mz2:
                        Console.WriteLine("Są 2 miejsca zerowe");
                        break;
                    default:
                        break;
                }


            }
            else
            {
                Console.WriteLine("Nie podano samych wartosci liczbowych");
            }
        }
    }
}
