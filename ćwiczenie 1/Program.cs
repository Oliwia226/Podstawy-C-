using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_1
{
    internal class Program
    {
            //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi.Napisz program wykorzystujący funkcję suma.
            
            static int suma(int a, int b)
            {
                return a + b;
            }

            static void Main(string[] args)
            {
            int a, b;
            Console.WriteLine("Podaj pierwsza liczbe a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Suma {0} i {1} wynosi: {2}", a, b, suma(a, b));
            Console.ReadKey(true);
        }
    }
}
