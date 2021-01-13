using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie42v2
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                var fizzBuzz = new FizzBuzz();
                try
                {
                    Console.WriteLine("Podaj liczbę\n");
                    var liczba = int.Parse(Console.ReadLine());
                    var wynik = fizzBuzz.GetOutput(liczba);
                    Console.WriteLine(wynik);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine( "Grasz dalej? t/n");
                
                if (Console.ReadLine() == "n") break;

                Console.Clear(); 

            }
        }
    }
}
