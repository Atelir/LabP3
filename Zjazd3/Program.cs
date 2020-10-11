using Microsoft.VisualBasic;
using System;
using System.Dynamic;
using System.Text;
using System.Threading;

namespace Zjazd3
{
    class Program
    {
        static void Wypisz(int[] mojaTablica)
        {
            for (int i = 0; i < mojaTablica.Length; i++)
            {

                Console.WriteLine(mojaTablica[i]);

            }


        }

        static int[,] StworzTablice(int x, int y)
        {

            return new int[x, y];


        }

        static void ZmienTekst(ref string tekst)
        {

            tekst = "nowy tekst";

        }
        static void FunkcjaParams (params string[] parametr)
        {

            for (int i = 0; i < parametr.Length; i++)
            {
                Console.WriteLine(parametr[i]);
            }

        }

        static void Main(string[] args)
        {
            #region
            //var rozmiar = int.Parse(Console.ReadLine()); 
            //int[] tablica = new int[rozmiar];

            //Wypisz(tablica);


            //int[,] tablicaDwuwymiarowa = new int[2, 4];

            //for (int i = 0; i < tablicaDwuwymiarowa.GetLength(0); i++)
            //{

            //    for (int j = 0; j < tablicaDwuwymiarowa.GetLength(1); j++)
            //    {

            //        Console.WriteLine(tablicaDwuwymiarowa[i,j]);

            //    }

            //}

            //int[][] tablicaPoszarpana = new int[4][];

            //for (int i = 0; i < tablicaPoszarpana.Length; i++)
            //{
            //    tablicaPoszarpana[i] = new int[i + 1];
            //}

            //for (int i = 0; i < tablicaPoszarpana.Length; i++)
            //{
            //    for (int j = 0; j < tablicaPoszarpana[i].Length; j++)
            //    {
            //        tablicaPoszarpana[i][j] = i * j;
            //    }

            //}

            //for (int i = 0; i < tablicaPoszarpana.Length; i++)
            //{
            //    for (int j = 0; j < tablicaPoszarpana[i].Length; j++)
            //    {
            //        Console.WriteLine(tablicaPoszarpana[i][j] + " ");
            //    }


            //}
            #endregion

            //var tekst = "stary tekst";
            //ZmienTekst(ref tekst);
            //Console.WriteLine(tekst);

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("a");

            //Console.WriteLine(stringBuilder);

            //FunkcjaParams("1", "2");

            var tekst = "mój testowy tekst";
            if (tekst.Contains("test"))
            {
                Console.WriteLine("Zawiera");
            }
        }
    }
}
