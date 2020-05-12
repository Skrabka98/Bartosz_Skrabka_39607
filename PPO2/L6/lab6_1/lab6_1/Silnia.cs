using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    public class Silnia
    {
        int n;
       public Silnia(int n)
        {
            this.n = n;

        }
        public int oblicz()
        {
            int suma = 1;
            if (n == 0) return 1;

            for (int i = 1; i <= n; i++)
            {
                suma *= i;
            }
            return suma;
        }
    }
}
