using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Liczby L1 = new Liczby(0, 0, 0);
            Liczby L2 = new Liczby(0, 0, 0);

            L1.A = 2;
            L1.B = 3;
            L1.C = 10;
            L2.A = 4;
            L2.B = 5;
            L2.C = 20;
            lepsze_liczby LL1 = new lepsze_liczby(L1.A, L1.B, L1.C, 0);
            LL1.D = 111;
            Console.WriteLine("Liczba nr 1:");
            Console.WriteLine(L1.A + " " + L1.B + " " + L1.C);
            Console.WriteLine("Liczba nr 2:");
            Console.WriteLine(L2.A + " " + L2.B + " " + L2.C);
            Console.WriteLine("Lepsza Liczba nr 1:");
            Console.WriteLine(LL1.A + " " + LL1.B + " " + LL1.C + " " + LL1.D);
            Console.ReadKey();
        }
    }
}
