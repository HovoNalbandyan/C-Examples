using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped Para = new Parallelepiped(2, 4, 3);

            Console.WriteLine("Parallelepiped Volume = " + Para.V());

            Console.WriteLine("Parallelepiped Area = " + Para.Area());

            Elipsoid elips = new Elipsoid(2, 3, 4);

            Console.WriteLine("Elipsoid Volume = " + elips.V());

            Console.WriteLine("Elipsoid Area = " + elips.Area());
        }
    }
}
