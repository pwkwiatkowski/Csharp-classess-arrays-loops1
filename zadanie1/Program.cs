using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        //Napisz program wyświetlający w porządku malejącym liczby od 100 do 1 podzielne przez trzy, ale niepodzielne przez 2.
        //Zadanie wykonaj za pomocą trzech rodzajów pętli(for, while, do..while)

        static void Main(string[] args)
        {
            for(int i=100; i>0; i--)
            {
                if(i%3 == 0 && i%2 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine();

            int licznik = 100;
            while(licznik>0)
            {
                if (licznik % 3 == 0 && licznik % 2 != 0)
                {
                    Console.Write("{0} ", licznik);
                }
                licznik--;
            }

            Console.WriteLine();

            licznik = 100;
            do
            {
                if (licznik % 3 == 0 && licznik % 2 != 0)
                {
                    Console.Write("{0} ", licznik);
                }
                licznik--;
            } while (licznik > 0);

            Console.ReadKey();
        }
    }
}
