using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_5
{
    internal class Program
    {
        //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
        //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
        //utworzonej funkcji.

        static int czy_pierwsza(int liczba)
        {
            int i;
            for (i=2; i<=Math.Sqrt(liczba); i++)
                 if (liczba%i==0)
                    return 0;
                return 1;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbę");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", czy_pierwsza(n));
        }
    }
}
