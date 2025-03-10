using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej
            //odpowiednik rzymski.
            int a;
            Console.WriteLine("Podaj liczbę arabską od 1 do 3999");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 3000)
            {
                Console.Write("MMM");
                a -= 3000;
            }
            else if (a >= 2000)
            {
                Console.Write("MM");
                a -= 2000;
            }
            else if (a >= 1000)
            {
                Console.Write("M");
                a -= 1000;
            }

            if (a >= 900)
            {
                Console.Write("CM");
                a -= 900;
            }
            else if (a >= 800)
            {
                Console.Write("DCCC");
                a -= 800;
            }
            else if (a >= 700)
            {
                Console.Write("DCC");
                a -= 700;
            }
            else if (a >= 600)
            {
                Console.Write("DC");
                a -= 600;
            }
            else if (a >= 500)
            {
                Console.Write("D");
                a -= 500;
            }
            else if (a >= 400)
            {
                Console.Write("CD");
                a -= 400;
            }
            else if (a >= 300)
            {
                Console.Write("CCC");
                a -= 300;
            }
            else if (a >= 200)
            {
                Console.Write("CC");
                a -= 200;
            }
            else if (a >= 100)
            {
                Console.Write("C");
                a -= 100;
            }

            if (a >= 90)
            {
                Console.Write("XC");
                a -= 90;
            }
            else if (a >= 80)
            {
                Console.Write("LXXX");
                a -= 80;
            }
            else if (a >= 70)
            {
                Console.Write("LXX");
                a -= 70;
            }
            else if (a >= 60)
            {
                Console.Write("LX");
                a -= 60;
            }
            else if (a >= 50)
            {
                Console.Write("L");
                a -= 50;
            }
            else if (a >= 40)
            {
                Console.Write("XL");
                a -= 40;
            }
            else if (a >= 30)
            {
                Console.Write("XXX");
                a -= 30;
            }
            else if (a >= 20)
            {
                Console.Write("XX");
                a -= 20;
            }
            else if (a >= 10)
            {
                Console.Write("X");
                a -= 10;
            }

            switch (a)
            {
                case 1: Console.Write("IX"); break;
                case 2: Console.Write("VIII"); break;
                case 3: Console.Write("VII"); break;
                case 4: Console.Write("VI"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("IV"); break;
                case 7: Console.Write("III"); break;
                case 8: Console.Write("II"); break;
                case 9: Console.Write("I"); break;
                default: Console.Write(""); break;
            }

            Console.ReadKey(true);


        }
    }
}
