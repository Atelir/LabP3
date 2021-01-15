using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Zadanie_7
{
    class Program
    {

        public interface IPrintable
        {
            void Print();

        }

        private static readonly Random random = new Random();

        class Dowolna : ICloneable, IComparable<Dowolna>, IPrintable
        {



            public int id;
            public string tekst;
            public int[] tab = new int[10];

            public Dowolna(int id, string tekst, int[] tab)
            {
                this.id = id;
                this.tekst = tekst;
                this.tab = tab;
            }

            public object Clone()
            {

                int[] tabCopy = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    tabCopy[i] = tab[i];
                }
                return new Dowolna(this.id,this.tekst,tabCopy);


            }

            public int CompareTo([AllowNull] Dowolna other)
            {

                return this.tekst.CompareTo(other.tekst);

            }

            public void Print()
            {
                Console.WriteLine($"Id: {this.id}");
                Console.WriteLine($"Tekst: {tekst}");
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine($"Element tablict [{i}] = {tab[i]}");
                }
            }


        }

        public static void wypelnijKlase()
        {
            Dowolna[] dowolna1 = new Dowolna[100];
            
            for (int i = 0; i < 100; i++)
            {
                string text = "";
                int[] tablica = new int[10];
                for (int j = 0; j < 10; j++)
                {

                    tablica[j] = random.Next(1,20);
                }
                for (int k = 0; k < 10; k++)
                {
                    text += (char)random.Next('a', 'z');
                }
                dowolna1[i] = new Dowolna(i,text,tablica);
               
            }

            List<Dowolna> klonTablicy = new List<Dowolna>();

            for (int i = 0; i < 100; i++)
            {

                klonTablicy.Add((Dowolna)dowolna1[i].Clone());

                for (int j = 0; j < 10; j++)
                {
                    dowolna1[i].tab[j] = 0;
                }

            }
            klonTablicy.Sort();
            for (int i = 0; i < 100; i++)
            {
                klonTablicy[i].Print();
            }
        }




        static void Main(string[] args)
        {

            wypelnijKlase();
            

        }
    }
}
