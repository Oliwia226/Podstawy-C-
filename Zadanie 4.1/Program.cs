﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód
            double a, b, pole, obwód;
            Console.WriteLine("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            pole = a * b;
            Console.WriteLine("Pole ={0}", pole);
            obwód = 2 * a + 2 * b;
            Console.WriteLine("Obwód ={0}", obwód);
            Console.ReadKey(true);

        }
    }
}
