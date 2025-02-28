using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.
            int a, b, c, d, e;
            Console.WriteLine("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c=");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj d=");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj e=");
            e = Convert.ToInt32(Console.ReadLine());

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
                Console.WriteLine("{0} to wartość najwiejsza", a);
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
                Console.WriteLine("{0} to wartość najwiejsza", b);
            else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
                Console.WriteLine("{0} to wartość najwiejsza", c);
            else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
                Console.WriteLine("{0} to wartość najwiejsza", d);
            else
                Console.WriteLine("{0} to wartość najwiejsza", e);

            if ((a <= b) && (a <= c) && (a <= d) && (a <= e))
                Console.WriteLine("{0} to wartość najmniejsza", a);
            else if ((b <= a) && (b <= c) && (b <= d) && (b <= e))
                Console.WriteLine("{0} to wartość najmniejsza", b);
            else if ((c <= a) && (c <= b) && (c <= d) && (c <= e))
                Console.WriteLine("{0} to wartość najmniejsza", c);
            else if ((d <= a) && (d <= b) && (d <= c) && (d <= e))
                Console.WriteLine("{0} to wartość najmniejsza", d);
            else
                Console.WriteLine("{0} to wartość najmniejsza", e);
            Console.ReadKey(true);
        }
    }
}