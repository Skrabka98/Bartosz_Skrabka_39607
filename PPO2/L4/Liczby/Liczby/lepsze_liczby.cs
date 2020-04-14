using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Liczby
{
    public class lepsze_liczby : Liczby
    {
        protected int d;

        public lepsze_liczby(int a, int b, int c, int d) : base (a,b,c)
        {
            this.d = 0;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int D
        {
            get => d;
            set => d = value;

        }
    }
}