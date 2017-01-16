using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    public class Parallelepiped
    {
        int a;

        int b;

        int c;

        public Parallelepiped()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public Parallelepiped(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double V()
        {
            return a * b * c;
        }

        public double Area()
        {
            return 2 * a * b + 2 * b * c + 2 * a * c;
        }
    }
}
