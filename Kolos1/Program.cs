using System;

namespace Kolos1
{
    class Program
    {

        public class Komputer
        {
            public string nazwa;
            public int cena;
            public int dysk;
            public int pamiec;

            public Komputer(string nazwa,int cena, int dysk, int pamiec)
            {
                this.nazwa = nazwa;
                this.cena = cena;
                this.dysk = dysk;
                this.pamiec = pamiec;
            }
        }

        public class BazaFirm
        {

            public string Nazwa;
            string Email;
            DateTime Date;
            

            public BazaFirm(string nazwa, string email, DateTime date)
            {

                bool check;
                bool check1;
                DateTime dzisiaj = DateTime.UtcNow;


                check = char.IsUpper(nazwa, 0);
                check1 = email.Contains("@");

                if (check)
                {
                    Nazwa = nazwa;
                }
                else {
                    
                    throw new ArgumentException("Nazwa nie zaczyna się od dużej litery");

                }

                if (check1)
                {

                    Email = email;

                }
                else {

                    throw new ArgumentException("Email nie zawiera @");

                }

                if (date < dzisiaj) {

                    Date = date;
                }
                else
                {

                    throw new ArgumentException("Podano złą datę");


                }

                
            }



        }

        public static void Wylicz(int ocena1, int ocena2, int ocena3)
        {


            #region
            //Najlepsza ocena

            //int pozostałe = 0;

            //if (ocena1 > ocena2)
            //{
            //    if (ocena1 > ocena3)
            //    {
            //        Console.WriteLine($"Najlepszy komputer to : komputer1");
            //        pozostałe += 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Najlepszy komputer to :komputer3");
            //        pozostałe += 3;
            //    }
            //}
            //else
            //{
            //    if (ocena2 > ocena3)
            //    {
            //        Console.WriteLine($"Najlepszy komputer to :komputer2");
            //        pozostałe += 2;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Najlepszy komputer to :komputer3");
            //        pozostałe += 3;
            //    }
            //}

            ////Najgorsza ocena

            //if (ocena1 < ocena2)
            //{
            //    if (ocena1 < ocena3)
            //    {
            //        Console.WriteLine($"Najgorszy komputer to :komputer1");
            //        pozostałe += 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Najgorszy komputer to :komputer3");
            //        pozostałe += 3;
            //    }
            //}
            //else
            //{
            //    if (ocena2 < ocena3)
            //    {
            //        Console.WriteLine($"Najgorszy komputer to :komputer2");
            //        pozostałe += 2;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Najgorszy komputer to :komputer3");
            //        pozostałe += 3;
            //    }
            //}

            //switch (pozostałe)
            //{
            //    case 3:
            //        Console.WriteLine($"Średni komputer to: komputer3");
            //        break;
            //    case 4:
            //        Console.WriteLine($"Średni komputer to: komputer2");
            //        break;
            //    case 5:
            //        Console.WriteLine($"Średni komputer to: komputer1");
            //        break;
            //    default:
            //        Console.WriteLine("ERROR");
            //        break;
            //}
            #endregion

        }


        static void Zadanie2(int ile)
        {

            string[] nazwy = new string[ile];
            int[] ilosc = new int[ile];
            double[] cena = new double[ile];

            nazwy[0] = "elo1";
            nazwy[1] = "elo2";

            ilosc[0] = 5;
            ilosc[1] = 10;

            cena[0] = 2;
            cena[1] = 9;

            double sumaZVat = 0;
            double sumaBezVat = 0;

            for (int i = 0; i < ile; i++)
            {
                Console.Write(i + 1);
                Console.Write($" {nazwy[i]}");
                Console.Write($" {ilosc[i]}");
                Console.Write($" {cena[i]}");
                Console.Write($" {ilosc[i] * cena[i]}");
                Console.Write($" {cena[i] * 1.23}");
                sumaBezVat += cena[i];
                sumaZVat += cena[i] * 1.23;
                Console.WriteLine();

            }
            Console.WriteLine($"Cena bez vat: {sumaBezVat}");
            Console.WriteLine($"Cena z vat: {sumaZVat}");



        }

        public static int ocena(Komputer komputer)
        {

            int suma;
            suma = (komputer.dysk * 1) + (komputer.pamiec * 1000);
            return suma;
        }

        static void Main(string[] args)
        {

            //Zadanie 1

            Komputer komputer1 = new Komputer("1",6000, 2000, 16);
            Komputer komputer2 = new Komputer("2",4500, 1000, 8);
            Komputer komputer3 = new Komputer("3",2500, 500, 4);

            int ocena1 = ocena(komputer1)/ komputer1.cena;
            int ocena2 = ocena(komputer2) / komputer2.cena;
            int ocena3 = ocena(komputer3) / komputer3.cena;

            int elementy = 3;

            Komputer[] oceny = new Komputer[elementy];

            oceny[0] = komputer1;
            oceny[1] = komputer2;
            oceny[2] = komputer3;

            Array.Sort(oceny, delegate (Komputer cena1, Komputer Cena2) { return cena1.cena.CompareTo(Cena2.cena); });

            Console.WriteLine($"Najlepszy komputer to komputer nr:  {oceny[2].nazwa}");
            Console.WriteLine($"Najgorszy komputer to komputer nr:  {oceny[0].nazwa}");
            Console.WriteLine($"Średni komputer to komputer nr:  {oceny[1].nazwa}");

            //

            // Zadanie 2
            Console.WriteLine("Podaj ilość produktów:");
            string wpisz = Console.ReadLine();
            int ile = Int16.Parse(wpisz);

            Zadanie2(ile);

            //Zadanie2 3

            DateTime test = new DateTime(2019, 12, 20);

            BazaFirm bazaFirm = new BazaFirm("Nazwa","test@test.pl",test);

        }
    }
}
