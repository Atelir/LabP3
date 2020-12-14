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

        //public class BazaFirm
        //{

        //    public string Nazwa;
        //    string Email;
        //    int DataZalozenia;

        //    public BazaFirm(string nazwa, string email, int dataZalozenia)
        //    {
        //        Nazwa = nazwa;
        //        Email = email;
        //        DataZalozenia = dataZalozenia;
        //    }



        //}

        static int ocena(Komputer komputer)
        {

            int suma;
            suma = (komputer.dysk * 1) + (komputer.pamiec * 1000);
            return suma;
        }

        static void Main(string[] args)
        {

            Komputer komputer1 = new Komputer("1",6000, 2000, 16);
            Komputer komputer2 = new Komputer("2",4500, 1000, 8);
            Komputer komputer3 = new Komputer("3",2500, 500, 4);

            int ocena1 = ocena(komputer1);
            int ocena2 = ocena(komputer2);
            int ocena3 = ocena(komputer3);

            int[] zbior = new int[3] { ocena1, ocena2, ocena3};

            //Najlepsza ocena

            int pozostałe = 0;

            if(ocena1 > ocena2)
            {
                if(ocena1 > ocena3)
                {
                    Console.WriteLine($"Najlepszy komputer to :{komputer1.nazwa}");
                    pozostałe += 1;
                }
                else
                {
                    Console.WriteLine($"Najlepszy komputer to :{komputer3.nazwa}");
                    pozostałe += 3;
                }
            }
            else
            {
                if(ocena2 > ocena3)
                {
                    Console.WriteLine($"Najlepszy komputer to :{komputer2.nazwa}");
                    pozostałe += 2;
                }
                else
                {
                    Console.WriteLine($"Najlepszy komputer to :{komputer3.nazwa}");
                    pozostałe += 3;
                }
            }

            //Najgorsza ocena

            if (ocena1 < ocena2)
            {
                if (ocena1 < ocena3)
                {
                    Console.WriteLine($"Najgorszy komputer to :{komputer1.nazwa}");
                    pozostałe += 1;
                }
                else
                {
                    Console.WriteLine($"Najgorszy komputer to :{komputer3.nazwa}");
                    pozostałe += 3;
                }
            }
            else
            {
                if (ocena2 < ocena3)
                {
                    Console.WriteLine($"Najgorszy komputer to :{komputer2.nazwa}");
                    pozostałe += 2;
                }
                else
                {
                    Console.WriteLine($"Najgorszy komputer to :{komputer3.nazwa}");
                    pozostałe += 3;
                }
            }

            switch (pozostałe)
            {
                case 3:
                    Console.WriteLine($"Średni komputer to: {komputer3.nazwa}");
                    break;
                case 4:
                    Console.WriteLine($"Średni komputer to: {komputer2.nazwa}");
                    break;
                case 5:
                    Console.WriteLine($"Średni komputer to: {komputer1.nazwa}");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
    }
}
