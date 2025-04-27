using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            bool pierwsza = true;
            
            for (i = 2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    pierwsza = false;
                    break;
                }
               
            }
            if (pierwsza)
                Console.WriteLine("{0} jest pierwsza", n);
            else
                Console.WriteLine("{0} nie jest pierwsza", n);
        }
    }
}
