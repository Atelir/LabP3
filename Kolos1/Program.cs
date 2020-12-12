using System;
using System.Linq;

namespace Kolos1
{
    class Program
    {

        public class Komputer
        {

            public int cena;
            public int dysk;
            public int pamiec;

            public Komputer(int cena, int dysk, int pamiec)
            {
                this.cena = cena;
                this.dysk = dysk;
                this.pamiec = pamiec;
            }
        }

        public class BazaFirm
        {

            public string Nazwa;
            string Email;
            int DataZalozenia;

            public BazaFirm(string nazwa, string email, int dataZalozenia)
            {
                Nazwa = nazwa;
                Email = email;
                DataZalozenia = dataZalozenia;
            }



        }

        static int ocena(Komputer komputer)
        {

            int suma;
            suma = ((komputer.dysk * 1) + komputer.pamiec) * 1000;
            return suma;
        }

        static void Main(string[] args)
        {

            Komputer komputer1 = new Komputer(6000, 2000, 16);
            Komputer komputer2 = new Komputer(4500, 1000, 8);
            Komputer komputer3 = new Komputer(2500, 500, 4);

            int ocena1 = ocena(komputer1);
            int ocena2 = ocena(komputer2);
            int ocena3 = ocena(komputer3);

            int[] zbior = new int[3] { ocena1, ocena2, ocena3};
            


            if(zbior.Max() == ocena1)
            {
                Console.WriteLine("Najlepszy komputer to komputer1");

            }
            else if(zbior.Max() == ocena2)
            {

                Console.WriteLine("Najlepszy komputer to komputer2");

            }
            else if(zbior.Max() == ocena3)
            {

                Console.WriteLine("Najlepszy komputer to komputer3");

            }

            if (zbior.Min() == ocena1)    
            {
                Console.WriteLine("Najgorszy komputer to komputer1");
            }
            else if(zbior.Min() == ocena2)
            {

                Console.WriteLine("Najgorszy komputer to komputer2");

            }
            else if(zbior.Min() == ocena3)
            {

                Console.WriteLine("Najgorszy komputer to komputer3");

            }




        }
    }
}
