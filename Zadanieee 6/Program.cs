using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanieee_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tydzien = new string[] { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

            foreach (string element in tydzien)
                Console.WriteLine("{0}, ", element);

            Console.ReadKey(true);
        }
    }
}
