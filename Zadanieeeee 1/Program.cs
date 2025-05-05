using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanieeeee_1
{
    internal class Program
    {
        //Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia.
        //Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od
        //użytkownika i wypisz wszystkie pobrane wartości pól na ekranie.

        struct Osoba
        {
            public string imie, nazwisko;
            public int rok_urodzenia;

        }
        static void Main(string[] args)
        {
            Osoba o;
            Console.WriteLine("Podaj imie: ");
            o.imie = Console.ReadLine ();
            Console.WriteLine("Podaj nazwisko: ");
            o.nazwisko = Console.ReadLine(); 
            Console.WriteLine("Podaj rok urodzenia: ");
            o.rok_urodzenia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} urodził(a) się w {2} roku", o.imie, o.nazwisko, o.rok_urodzenia);
            Console.ReadKey(true);
        }
    }
}
