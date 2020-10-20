using System;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace Zadanie3
{
    class Program
    {

        static void FunkcjaSum(ref int[][] tablicaposzarpana)
        {
            int wynik = 0;
            for (int i = 0; i < tablicaposzarpana.Length; i++)
            {
                for (int j = 0; j < tablicaposzarpana[i].Length; j++)
                {
                    wynik += tablicaposzarpana[i][j];

                }
            }

            Console.WriteLine($"Suma tablicy poszarpanej jest równa: {wynik}");

        }

        static void SprawdzTekst (ref string zdanie)
        {
            string v = char.ToUpper(zdanie[0]) + zdanie.Substring(1);

            if (v.EndsWith("."))
            {

                Console.WriteLine(v);

            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder(v);
                stringBuilder.Append(".");
                Console.WriteLine(stringBuilder);  
            }
          
        }

        static void Main(string[] args)
        {
            int[][] tablicaPoszarpana = new int[4][];
            Random rnd = new Random();

            //tablicaPoszarpana[0] = new int[] {5, 3, 2, 1, 0 };
            //tablicaPoszarpana[1] = new int[] { -5, 3, 9, 1, -15 };
            //tablicaPoszarpana[2] = new int[] { -8, 3, 5, 8, 4 };
            
            for (int i = 0; i < tablicaPoszarpana.Length; i++)
            {
                tablicaPoszarpana[i] = new int[4];
            }

            for (int i = 0; i < tablicaPoszarpana.Length; i++)
            {
                for (int j = 0; j < tablicaPoszarpana[i].Length; j++)
                {
                    tablicaPoszarpana[i][j] = rnd.Next(0,11);
                }

            }

            FunkcjaSum(ref tablicaPoszarpana);

            Console.WriteLine("Napisz zdanie: ");
            string zdanie = Console.ReadLine();
            if (!string.IsNullOrEmpty(zdanie) && !string.IsNullOrWhiteSpace(zdanie))
            {
                SprawdzTekst(ref zdanie);
            }
            else
            {
                Console.WriteLine("Wpisz zdanie.");
            }
        }

    }
}
