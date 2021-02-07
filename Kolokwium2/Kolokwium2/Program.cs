using System;
using System.Linq;

namespace Kolokwium2
{
    class Program
    {

        interface IDokument
        {

            public void Napisz(string tekst);

        }

        class Word : IDokument
        {

            private string tekst;


            public void Napisz(string Tekst)
            {

                tekst = Tekst;

            }


            public void Popraw(string tekstwpisany)
            {

                tekst = tekstwpisany;

            }


        }

        class Dlugopis : IDokument
        {

            public string kolorTuszu;
            private string opis;

            public void Napisz(string Tekst)
            {

            }

            public void Szkicuj(string opisObrazka)
            {
                opis = opisObrazka;


            }

        }

        class MaszynaDoPisania : IDokument
        {


            public void Napisz(string tekst)
            {


            }

        }


        class Chlodnica
        {
            public bool czyOtwarta;
        }

        class ModulChlodzenia : Chlodnica
        {

            public int TemperaturaMax;
            public int TemperaturaMin;

            public ModulChlodzenia(int temperaturaMax, int temperaturaMin)
            {
                TemperaturaMax = temperaturaMax;
                TemperaturaMin = temperaturaMin;
            }

            public event EventHandler Przegrzanie;
            public event EventHandler Przechlodzenie;

            public void Kontrola(int aktualnaTemperaturaSilnika)
            {
                if (aktualnaTemperaturaSilnika > TemperaturaMax)
                {
                    Przegrzanie.Invoke(this, EventArgs.Empty);
                }
                else if (aktualnaTemperaturaSilnika < TemperaturaMin)
                {
                    Przechlodzenie.Invoke(this, EventArgs.Empty);
                }


            }
        }

        class KomputerPokladowy : ModulChlodzenia
        {

            public int Temperatura;

            public KomputerPokladowy(int temperaturaMax, int temperaturaMin) : base(temperaturaMax, temperaturaMin)
            {

                Przegrzanie += (sender, elo) => { czyOtwarta = true; };
                Przechlodzenie += (sender, elo) => { czyOtwarta = false; };
            }

            public void Skan()
            {
                if (!czyOtwarta)
                {
                    Temperatura++;
                }
                else
                {
                    Temperatura--;
                }
                Kontrola(Temperatura);

            }

        }


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
               
            

            Word word1 = new Word();
            Dlugopis dlugopis1 = new Dlugopis();
            MaszynaDoPisania maszynaDoPisania1 = new MaszynaDoPisania();

            word1.Napisz("test1");
            word1.Popraw("test2");
            dlugopis1.Napisz("test3");
            dlugopis1.Szkicuj("jak ja bardzo chce zdac te studia");
            maszynaDoPisania1.Napisz("ale jest ciezko");
            

            Console.WriteLine("Podaj temperatur min");
            int tempmin = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj temperature max");
            int tempmax = Int32.Parse(Console.ReadLine());

            KomputerPokladowy komputerPokladowy1 = new KomputerPokladowy(tempmin,tempmax);

            for (int i = 0; i < 100; i++)
            {

                komputerPokladowy1.Skan();

            }

        }
    }
}
