using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            int j = 9;
            Triangle hashv1 = new Triangle();
            double d = hashv1.Paragic(5, 8, j);
            Console.WriteLine(d);
            double d1 = hashv1.Area(5, j, 7);
            Console.WriteLine(d1);
            
        }

    }
}
