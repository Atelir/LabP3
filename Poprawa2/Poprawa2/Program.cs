using System;

namespace Poprawa2
{
    class Program
    {

        static void paginujTresc(int nrStrony, int iloscElem)
        {
            int[] tab = new int[1000];
            

            for (int i = 0; i < 1000; i++)
            {
                tab[i] = i+1;
            }

            int pierwszyIndex = (nrStrony-1)* iloscElem;
            int ostatniIndex = pierwszyIndex + iloscElem;

            for (int i = pierwszyIndex; i < ostatniIndex; i++)
            {

                Console.Write($"{tab[i]},");


            }
            Console.WriteLine();
        }

        class Konto
        {

            private string login;
            private string haslo;
            DateTime OstatniaAktywnosc;
            bool CzyAktywny;
            string Skrzynka;

            public Konto(string login, string haslo)
            {
                this.login = login;
                this.haslo = haslo;
            }

            public string Login 
            {
                set { login = value; }  
            }

            public string Haslo
            {

                set { haslo = value; }

            }

            public void nowaWiadomosc(string tekstWiadomosci)
            {
                if (CzyAktywny)
                {
                   Console.WriteLine(tekstWiadomosci);
                }
                else
                {
                    if (Skrzynka == null)
                    {
                        Skrzynka = tekstWiadomosci;
                    }
                    else
                    {

                        Skrzynka += Environment.NewLine;
                        Skrzynka += tekstWiadomosci;
                    }
                }
            }

            public void zaloguj(string login, string haslo)
            {
                if (login.Equals(this.login) && haslo.Equals(this.haslo))
                {
                    CzyAktywny = true;
                    OstatniaAktywnosc = DateTime.Now;
                    Console.WriteLine(Skrzynka);
                    Skrzynka = null;
                }



            }

            public void wyloguj()
            {
                CzyAktywny = false;
                OstatniaAktywnosc = DateTime.Now;
            }
        }

        static void oplatTab(double[] tab, double balans) {

            double srednia = 0;

            for (int i = 0; i < 12; i++)
            {
                srednia += tab[i];
            }
            
            
        }

        static void Main(string[] args)
        {
            //Zadanie 1
            Console.WriteLine("Podaj nr strony");
            int nrStrony = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilosc elementów");
            int iloscElem = Int32.Parse(Console.ReadLine());
            paginujTresc(nrStrony, iloscElem);


            //Zadanie 2
            double[] oplaty = new double[12];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                oplaty[i] = rnd.NextDouble() * (200 - 50) + 50;
            }


            //Zadanie 3

            Konto konto1 = new Konto("abc", "123");

            Console.WriteLine("Podaj login:");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj haslo:");
            string haslo = Console.ReadLine();
            konto1.nowaWiadomosc("wiadomosc testowa - niezalogowany");
            konto1.zaloguj(login, haslo);
            konto1.nowaWiadomosc("wiadomosc testowa - zalogowany");


        }



    }
}
