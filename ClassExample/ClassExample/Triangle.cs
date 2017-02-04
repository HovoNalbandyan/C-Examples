using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Triangle
    {        
        public Triangle()
        {
            
            Paragic(5, 6, 7);
        }

        public  double Paragic(double a, double b, double c)
        {
            double P;
            P = a + b + c;
            return P;
        }



        public double Area(double a, double b, double c, double p)
        {
            double S = 1;
            S = p*(p - c)(p-b);
            return S;
        }
}
