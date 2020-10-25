using System;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace Zadanie3
{
    class Program
    {

        static void FunkcjaSum(int[][] tablicaposzarpana)
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

        static void SprawdzTekst (string zdanie)
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

            FunkcjaSum(tablicaPoszarpana);

            Console.WriteLine("Napisz zdanie: ");
            string zdanie = Console.ReadLine();
            if (!string.IsNullOrEmpty(zdanie) && !string.IsNullOrWhiteSpace(zdanie))
            {
                SprawdzTekst(zdanie);
            }
            else
            {
                Console.WriteLine("Wpisz zdanie.");
            }
        }

    }
}
