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
            int[,] a;
            a = new int[4, 3];
            char[,] c = new char[3, 6];
            Random rd = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    a[i, k] = rd.Next(-100, 100);
                }

            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    Console.Write(a[i, k] + "\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int k = 0; k < c.GetLength(0); k++)
                {
                    a[i, k] = (char)rd.Next((int)'A', (int)'Z' );
                    Console.Write(c[i, k] + "\t");
                }
       
                Console.ReadLine();

            }
        }
    }
}
