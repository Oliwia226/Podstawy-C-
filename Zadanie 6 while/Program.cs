using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_while
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
            //Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
            //dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
            //pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0(zero).
            int wybór;
            double a, b;
            do
            {
                Console.WriteLine("Możliwe opcje: ");
                Console.WriteLine("1 - pole prostokąta");
                Console.WriteLine("2 - pole kwadratu");
                Console.WriteLine("3 - pole trójkąta");
                Console.WriteLine("0 - zakończ");
                Console.WriteLine("Twój wybór to: ");
                wybór = Convert.ToInt32(Console.ReadLine());

                switch (wybór)
                {
                    case 0: break;
                    case 1:
                        Console.WriteLine("Podaj a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("pole prostokąta o bokach {0} i {1} wynosi {2}", a, b, a * b);
                        break;
                    case 2:
                        Console.WriteLine("Podaj a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("pole kwadratu o bokach {0} wynosi {1}", a, a * a);
                        break;
                    case 3:
                        Console.WriteLine("Podaj a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj h: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("pole trójkąta o bokach {0} i wysokości {1} wynosi {2}", a, b, (a * b) / 2);
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego wyboru");
                        break;

                }

            }
            while (wybór != 0);
            Console.ReadKey(true);
        }
    }
}
