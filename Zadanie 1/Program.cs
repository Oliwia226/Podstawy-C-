using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            //liczba parzysta, czy też nieparzysta.
            int a;
            Console.WriteLine("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Jest podzielna");
            else
                Console.WriteLine("Nie jest podzielna");
            Console.ReadKey(true);
        }
    }
}
