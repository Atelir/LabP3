using System;
using System.Linq;

namespace Kolokwium2
{
    class Program
    {

        static private readonly Random _random = new Random();
         static public int RandomNumber(int min, int max)
        {

             return _random.Next(min, max+1);
        }

        static void Main(string[] args)
        {
            //Zadanie 1

            int[] tab = new int[100];
            for (int i = 0; i < 100; i++)
            {

                tab[i] = RandomNumber(100,999);

            }

            Console.WriteLine("Podaj liczbe max 3 cyfrowa:");
            string wpisanie = Console.ReadLine();

            int count = 0;
            
            for (int i = 0; i < tab.Length; i++)
            {
                string test = tab[i].ToString();
                if (test.StartsWith(wpisanie) && count < 10)
                {
                    Console.WriteLine(test);
                    count++;

                }

            }
               




        }
    }
}
