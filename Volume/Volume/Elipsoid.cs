using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    public class Elipsoid
    {
        int a;

        int b;

        int c;

        public Elipsoid()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public Elipsoid(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double V()
        {
            return (4d/3)*Math.PI*a*b*c;
        }

        public double Area()
        {
            return a * b * c;
        }
    }
}
