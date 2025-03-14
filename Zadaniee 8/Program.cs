using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniee_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata
            //przestępne od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.
            int i, rokp, rokk;
            Console.WriteLine("Podaj rokp= ");
            rokp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj rokk= ");
            rokk = Convert.ToInt32(Console.ReadLine());

            for (i = rokp; i <= rokk; i++)
                if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
                    Console.Write("{0}, ", i);
            Console.ReadKey(true);
        }
    }
}
