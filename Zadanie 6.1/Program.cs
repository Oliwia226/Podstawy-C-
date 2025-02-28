using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.
            double a, b, suma, różnica, iloczyn, iloraz;
            Console.WriteLine("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());

            suma = a + b;
            różnica = a - b;
            iloczyn = a * b;
            iloraz = a / b;

            Console.WriteLine("Suma wynosi: {0}", suma);
            Console.WriteLine("Różnica wynosi: {0}", różnica);
            Console.WriteLine("Iloczyn wynosi: {0}", iloczyn);
            Console.WriteLine("Iloraz wynosi: {0}", iloraz);

            Console.ReadKey(true);
        }
    }
}
