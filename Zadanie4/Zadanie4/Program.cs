using System;

namespace Zadanie4
{

    public class Ksiazka
    {
        public string Tytul;
        public string Autor;

        public int NrRegalu = 0;
        public int NrPolki = 0;
        public int NrMiejscaNaPolce = 0;


        public Ksiazka(string tytul, string autor, int nrRegalu, int nrPolki, int nrMiejscaNaPolce)
        {
            Tytul = tytul;
            Autor = autor;
            NrRegalu = nrRegalu;
            NrPolki = nrPolki;
            NrMiejscaNaPolce = nrMiejscaNaPolce;
        }

    }
    class Program
    {

        static void WypelnijRegal(Ksiazka[,,] Regal)
        {         
            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {

                        Ksiazka ksiazka = new Ksiazka("Elo" + i + j + k, "test", i, j, k);
                        Regal[i, j, k] = ksiazka;
                    }
                }
            }


            Ksiazka a = new Ksiazka("Chce zdac p3", "Ja", 2, 1, 5);

            Regal[2,1,5] = a;

        }

        static void WyszukanieNazwy(Ksiazka[,,] Regal,string sprawdzenie)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (Regal[i,j,k].Autor.Contains(sprawdzenie, StringComparison.OrdinalIgnoreCase) || Regal[i, j, k].Tytul.Contains(sprawdzenie, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Podana książka znajduje się na: Regale:{Regal[i,j,k].NrRegalu}, Półce: {Regal[i, j, k].NrPolki} oraz na Miejscu: {Regal[i, j, k].NrMiejscaNaPolce}");
                            return;
                        }

                    }

                }
            }
            Console.WriteLine("Brak wpisanego wyrazu w tytule lub autorze ksiazki");
        }

        static void Main(string[] args)
        {

            Ksiazka[,,] Regal = new Ksiazka[3, 6, 10];

            WypelnijRegal(Regal);

            Console.WriteLine("Wpisz string: ");
            string sprawdzenie = Console.ReadLine();

            WyszukanieNazwy(Regal, sprawdzenie);
        }
    }
}
