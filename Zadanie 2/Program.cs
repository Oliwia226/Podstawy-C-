using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
            //dodatnia, ujemna, czy też równa zero.
            int a;
            Console.WriteLine("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
                Console.WriteLine("Jest dodatnia");
            else if (a == 0)
                Console.WriteLine("Jest równa 0");
            else
                Console.WriteLine("Jest ujemna");
            Console.ReadKey(true);
        }
    }
}
