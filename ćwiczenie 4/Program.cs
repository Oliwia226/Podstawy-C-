using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenie_4
{
    internal class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba/10 > 0)
            {
                liczba /= 10;
                i++;   
            }
            return i + 1;
        }
        static void Main(string[] args)
        {
            //Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
            //argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.
            int n;
            Console.WriteLine("Podaj liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba {0} ma {1} cyfr", n, ile_cyfr(n));
        }
    }
}
