using System;
using System.Collections.Generic;
using System.Text;

namespace Zajecia4
{
    public class Produkt
    {

        public int Id {get; private set; }

        //public int Id; // public z wielkiej litery
        //private int _numer; // private z podkreślnikiem
        public string Nazwa { get; set; }
        private decimal _cena;
        public decimal Cena {
            get
            {

                return _cena;

            } 
            set
            {
                if (value >= 0)
                {
                    _cena = value;
                }
                else
                {
                    Console.WriteLine("Cena nie może być ujemna");
                }

            }
        
        
        }
        public string KodKreskowy;
        private static int _maxId = 1;
        /// <summary>
        /// Ilość produktu na magazynie
        /// </summary>
        public decimal Stan;

        // ctor - skrót do konstruktora

        public void Sprzedaj()
        {

            Stan--;

        }



        public Produkt(string nazwa, decimal cena, string kodKreskowy)
        {
            Id = _maxId++;
            Nazwa = nazwa;
            Cena = cena;
            KodKreskowy = kodKreskowy;
        }
    }
}
