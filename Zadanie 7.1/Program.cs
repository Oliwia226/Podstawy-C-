using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z
            //uwzględnieniem części całkowitej i reszty z dzielenia
            int a, b;
            Console.WriteLine("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}/{1}={2} r{3}", a, b, a / b, a % b); //($"{a} + {b} = {suma}) - inny zapis
            Console.ReadKey(true);
        }
    }
}
