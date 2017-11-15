using System;

namespace kalkulator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kal = new Kalkulator(10, 5);

            Console.WriteLine("Dodawanie: " + kal.dodawanie() + " Odejmowanie:  " + kal.odejmowanie()
                + " Mnozenie: " + kal.mnozenie() + " Dzielenie: " + kal.dzielenie() + " Modulo: " + kal.modulo());
            Console.ReadKey();
        }
    }
}
