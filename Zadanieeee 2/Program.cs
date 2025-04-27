using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanieeee_2
{
    internal class Program
    {
        //Napisz funkcję, która wyznacza n-ty wyraz ciągu Fibonacciego zadany przez argument
        //wywołania funkcji wartości liczby naturalnej.Utwórz wersję rekurencyjną tej funkcji.
        //Napisz program testowy wykorzystujący napisaną funkcję

        static long fib(long n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
                Console.WriteLine("Błędne n");
            Console.WriteLine("Wartość {0}-ego wyrazu ciągu Fibonacciego wynosi {1}", n, fib(n));
            Console.ReadKey();
        }
    }
}
