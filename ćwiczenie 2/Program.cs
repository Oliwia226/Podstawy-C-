using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_2
{
    internal class Program
    {
        // Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
        //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.

        static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Podaj pierwsza liczbe a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Maksimum {0} i {1} wynosi: {2}", a, b, max(a, b));
            Console.ReadKey(true);
        }
    }
}
