using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_biblioteki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Podaj długość boku a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole kwadratu wynosi {0}", Biblioteka.Class1.Kwadrat(a));
            Console.ReadKey();
        }
    }
}
