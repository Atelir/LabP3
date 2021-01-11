using System;
using System.Collections.Generic;

namespace Poprawa1
{
    class Program
    {
       
        public enum LogPoziom
        {
            Krytyczny,
            Ostrzezenie,
            Informacja
        }

        public class Logi
        {

            public LogPoziom _poziom;
            public string tekst;

            public Logi(LogPoziom poziom, string tekst)
            {
                _poziom = poziom;
                this.tekst = tekst;
            }
        }

        class Budzik
        {
            enum Dzwonek
            {
                budzik1,
                budzik2,
                budzik3,
                budzik4,
                budzik5
            };

            int godzina = 0;
            int minuta = 0;
            DateTime dataOstatniejAktywacji;
            string tytul;
            Dzwonek dzwonek;
            bool powtarza;
            bool wlaczony; // 0 wyl 1 wl

            public bool Sprawdz(DateTime date)
                {

                if(!wlaczony)
                {
                    return false;
                }

                int aktualnaGodzina = date.Hour;
                int aktualnaMinuta = date.Minute;

                if(aktualnaGodzina != godzina || aktualnaMinuta != minuta)
                {
                    return false;
                }

                if(powtarza && dataOstatniejAktywacji != null)
                {
                    if(dataOstatniejAktywacji.Day == date.Day && dataOstatniejAktywacji.Month == date.Month && dataOstatniejAktywacji.Year == date.Year)
                    {
                        return false; //budzik w tym dniu byl aktywny
                    }
                }

                dataOstatniejAktywacji = date;

                if (!powtarza)
                {
                    wlaczony = false;
                }
                return true;
                }
        }



        public static double Godziny(string iloscZespolu, string ryzykoStr, string godzinaStr)
        {
            double godzina = double.Parse(godzinaStr);

            godzina += 8;

            godzina *= 3_600; // zamiana na sekundy w celu latwiejszego liczenia

            godzina += godzina * 0.2; // buffor



            int ilosctEST = Int32.Parse(iloscZespolu);

            godzina += godzina * (0.05 * ilosctEST);


            int ryzyko = Int32.Parse(ryzykoStr);

            if (ryzyko >= 0 && ryzyko <= 10)
            {
                if (ryzyko > 5 && ryzyko <= 8)
                {

                    godzina += godzina * 0.3; 

                }
                else if(ryzyko > 8)
                {

                    godzina += godzina * 0.5;

                }
            }
            else
            {

                Console.WriteLine("Podano złe ryzyko");

            }

            godzina /= 3_600;

            godzina = Math.Round(godzina, 1);

            return godzina;

        }


        private static readonly List<Logi> _logi = new List<Logi>();

        private static void Wypelnij(LogPoziom logPoziom, string tekst)
        {

            if (_logi.Count < 10)
            {

                _logi.Add(new Logi(logPoziom, tekst));

            }
            else
            {

                _logi.RemoveAt(0);
                _logi.Add(new Logi(logPoziom, tekst));

            }

        }

        private static void DodajLog(LogPoziom logPoziom,string tekst)
        {

            int iloscOstrzezen = 0;
            int iloscKrytycznych = 0;
            int iloscInf = 0;

            Wypelnij(logPoziom, tekst);

            for (int i = 0; i < _logi.Count; i++)
            {

                if(_logi[i]._poziom == LogPoziom.Krytyczny)
                {

                    iloscKrytycznych += 1;

                }
                else if (_logi[i]._poziom == LogPoziom.Informacja)
                {

                    iloscInf += 1;

                }
                else
                {

                    iloscOstrzezen += 1;

                }   

            }
            Console.WriteLine($"Ostrzeżeń: {iloscOstrzezen} / Informacji: {iloscInf} / Krytycznych: {iloscKrytycznych}");

        }

        static void Main(string[] args)
        {
            #region
            /*
            //Zadanie 1
            Console.WriteLine("Wpisz godziny projektu:");
            string godzinastr = Console.ReadLine();



            Console.WriteLine("Ile osob liczy zespol:");
            string iloscZespolu = Console.ReadLine();


            Console.WriteLine("Jakie jest ryzyko projektu");
            string ryzykoStr = Console.ReadLine();

            double godzina = Godziny(iloscZespolu, ryzykoStr, godzinastr);

            Console.WriteLine($"Czas na projekt to: {godzina} h");
            
            //Zadanie 2

            for (int i = 0; i < 3; i++)
            {
                Wypelnij(LogPoziom.Krytyczny, $"Test{i}");
            }
            for (int i = 0; i < 3; i++)
            {
                Wypelnij(LogPoziom.Ostrzezenie, $"Test{i+3}");
            }
            for (int i = 0; i < 4; i++)
            {
                Wypelnij(LogPoziom.Informacja, $"Test{i + 7}");
            }

                Console.WriteLine("Podaj poziom bledu:");
                LogPoziom logPoziom = (LogPoziom)Enum.Parse(typeof(LogPoziom), Console.ReadLine(), true);
                Console.WriteLine("Podaj opis bledy");
                string opis = Console.ReadLine();
                DodajLog(logPoziom, opis);
            */
            #endregion



        }
    }
}
