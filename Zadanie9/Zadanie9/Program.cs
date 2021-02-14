using System;

namespace Zadanie9
{
    public class Uzytkownik
    {

        public string Nazwa;
        public int id { get; private set; }
        private static int m_Counter = 0;
        public Uzytkownik(string nazwa)
        {
            Nazwa = nazwa;
            this.id = System.Threading.Interlocked.Increment(ref m_Counter);
        }




        public void SubskrybujKanal(Kanal kanal)
        {
            kanal.IloscSubskrypcji();
            kanal.Opublikowanofilm += Kanal_Opublikowanofilm;

        }

        private void Kanal_Opublikowanofilm(object sender, EventArgs e)
        {
            Console.WriteLine("Nowy film");

        }
    }


    public class Kanal
    {
        public string Nazwa;
        public int Id = 0;
        public int LicznikWyswitlen = 0;
        private static int m_Counter = 0;
        public int LicznikSub = 0;
        public Kanal(string nazwa)
        {
            Nazwa = nazwa;
            this.Id = System.Threading.Interlocked.Increment(ref m_Counter);

        }

        public event EventHandler Opublikowanofilm;

        public void WyswietlFilm(int id)
        {

            LicznikWyswitlen++;

        }

        public void OpublikujFilm()
        {

            Opublikowanofilm.Invoke(this, EventArgs.Empty);

        }

        public void IloscSubskrypcji()
        {

            LicznikSub++;

        }



    }
    public static class KanalExtension
    {

        public static void Wypisz(this Kanal kanal)
        {
            Console.WriteLine($"Nazwa kanału: {kanal.Nazwa} " +
                $"Liczba wyświetleń filmów: {kanal.LicznikWyswitlen} " +
                $"Liczba subskrypcji: {kanal.LicznikSub} ");
        }
    }

    class Program
    {


        static void Main(string[] args)
        {

            Uzytkownik uzytkownik1 = new Uzytkownik("John");
            Uzytkownik uzytkownik2 = new Uzytkownik("Mickael");
            Uzytkownik uzytkownik3 = new Uzytkownik("Johnatan");
            Uzytkownik uzytkownik4 = new Uzytkownik("Avdol");
            Kanal kanal1 = new Kanal("Poziomki");
            uzytkownik1.SubskrybujKanal(kanal1);
            uzytkownik2.SubskrybujKanal(kanal1);
            uzytkownik3.SubskrybujKanal(kanal1);
            uzytkownik4.SubskrybujKanal(kanal1);
            kanal1.OpublikujFilm();
            kanal1.Wypisz();

        }
    }
}
