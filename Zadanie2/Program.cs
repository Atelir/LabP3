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

        static void MiejsceZeroweWZerz(int LiczbaB,int LiczbaA)
        {

            int MiejsceZeroweWZerze = (-LiczbaB) / (2 * LiczbaA);
            Console.WriteLine($"Miejsce zerowe jest równe: {MiejsceZeroweWZerze}");
        }

        static void MiejsceZeroweWJedynce(int LiczbaB, int LiczbaA, double Delta)
        {

            double MiejsceZeroweWJedynce1 = ((-LiczbaB) + Delta)/ (2 * LiczbaA);
            double MiejsceZeroweWJedynce2 = ((-LiczbaB) - Delta) / (2 * LiczbaA);
            Console.WriteLine($"Miejsce zerowe jest równe: {MiejsceZeroweWJedynce1} oraz {MiejsceZeroweWJedynce2}");
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
            if (sprawdzA && sprawdzB && sprawdzC)
            {

                int LiczbaA = int.Parse(a);
                int LiczbaB = int.Parse(b);
                int LiczbaC = int.Parse(c);

                int delta = (int)Math.Pow(LiczbaB, 2) - 4 * (LiczbaA * LiczbaC);

                Console.WriteLine($"Twoja delta wynosi: {delta}");

                double pierwiastekZDelty = Math.Sqrt(delta);

                Wyniki wyniki;

                if (delta < 0)
                {
                    wyniki = Wyniki.Mz0;
                    //Brak miejsc zerowych
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
                        MiejsceZeroweWZerz(LiczbaB,LiczbaA);
                        break;
                    case Wyniki.Mz2:
                        Console.WriteLine("Są 2 miejsca zerowe");
                        MiejsceZeroweWJedynce(LiczbaB,LiczbaA, pierwiastekZDelty);
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
