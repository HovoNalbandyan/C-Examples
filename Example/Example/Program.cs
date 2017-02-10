using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A=");
            int a = int.Parse(Console.ReadLine());

            Print obj1 = new Print();


            for(int i=0;i<a;i++)
            {
                obj1.x = Console.ReadLine(obj1.name)/*+obj1.surname+obj1.age);*/;
            }






        }
    }
}
