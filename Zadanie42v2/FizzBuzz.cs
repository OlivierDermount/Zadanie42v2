using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie42v2
{
    class FizzBuzz
    {
        public string GetOutput(int liczba)
        {
            string wynik;
            if (liczba % 3 == 0) wynik = "Fizz";
            else if(liczba % 5 == 0) wynik = "Buzz";
            else if (liczba % 15 == 0 ) wynik = "FizzBuzz";
            else wynik = liczba.ToString();
            
            return wynik;

        }
    }
}
