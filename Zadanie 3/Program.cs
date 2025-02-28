using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.
            int a, b, c;
            Console.WriteLine("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c=");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a>=b) && (a>=c))
                    Console.WriteLine("{0} to wartość najwiejsza", a);
            else if ((b>=a) && (b>=c))
                    Console.WriteLine("{0} to wartość najwiejsza", b);
            else
                Console.WriteLine("{0} to wartość najwiejsza", c);

            if ((a <= b) && (a <= c))
                    Console.WriteLine("{0} to wartość najmniejsza", a);
            else if ((b <= a) && (b <= c))
                    Console.WriteLine("{0} to wartość najmniejsza", b);
            else
                Console.WriteLine("{0} to wartość najmniejsza", c);

            Console.ReadKey(true);
        }
    }
}
