using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartość
            //zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na
            //ekranie.Użyj pętli do -while.
            double x;

            do
            {
                Console.WriteLine("Podaj x ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x <= 0);
            Console.WriteLine("Wczytano liczbę {0}", x);

            Console.ReadKey(true);
        }

    }
}
