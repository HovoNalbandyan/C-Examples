using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultidimensionalMassive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Weight=");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Height=");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            int[,] a;                     //Create massive
            a = new int[h, w];            
            Random rd = new Random();     //Random Numbers Generate
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    a[i, k] = rd.Next(-100, 100);
                    Console.Write(a[i, k] + "\t");  //Write member of massive and write Space
                }
                Console.WriteLine();       //Write New Line
            }        
        }
    }
}
