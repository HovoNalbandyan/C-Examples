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
            Parallelepiped zug = new Parallelepiped(2, 4, 3);

            Console.WriteLine("Zug Volume = " + zug.V());

            Console.WriteLine("Zug Area = " + zug.Area());

            Elipsoid elips = new Elipsoid(2, 3, 4);

            Console.WriteLine("Elips Volume = " + elips.V());

            Console.WriteLine("Elips Area = " + elips.Area());
        }
    }
}
