using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 9;
            double b = 9;
            double c = 4;
            double P = 7;
            Triangle hashv1 = new Triangle();
            double d = hashv1.Paragic(a,b,c,ref P);
            Console.WriteLine(d);






        }

    }
}
