using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulator1
{
    class Kalkulator
    {
        public int liczba1;
        public int liczba2;

        public Kalkulator(int liczba1, int liczba2)
        {
            this.liczba1 = liczba1;
            this.liczba2 = liczba2;
        }

        public int dodawanie()
        {
            return liczba1 + liczba2;
        }
        public int odejmowanie()
        {
            return liczba1 - liczba2;
        }
        public int mnozenie()
        {
            return liczba1 * liczba2;
        }
        public int dzielenie()
        {
            return liczba1 / liczba2;
        }

        public int modulo()
        {
            return liczba1 % liczba2;
        }
    }
}
