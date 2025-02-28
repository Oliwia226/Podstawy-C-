﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na
            //ekranie objętość i pole całkowite tego stożka.
            double r, h, l, V, Pc;
            Console.WriteLine("Podaj r:");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj h:");
            h = Convert.ToDouble(Console.ReadLine());

            l = Math.Sqrt(r * r + h * h);
            V = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("Objętość wynosi: {0}", V);
            Console.WriteLine("Powierzchnia całkowita wynosi: {0}", Pc);

            Console.ReadKey(true);
        }
    }
}
