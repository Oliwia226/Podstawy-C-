using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanieeee_1
{
    internal class Program
    {
        //Napisz funkcję , która oblicza wartość silni z zadanej przez argument wywołania funkcji
        //wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
        //Napisz program testowy wykorzystujący napisaną funkcję.

        static int silnia(int n)
        {
            if (n == 0)
                return 1;
            else return (n * (silnia(n - 1)));
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj n>=0: ");
            n =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silnia z {0} wynosi {1}", n, silnia(n));
            Console.ReadKey();
        }
    }
}
