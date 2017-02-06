using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Triangle
    {
       private double a;
        private double b;
        private double c;
        private double P;
        //Ctor      Defoult
        public Triangle()
        {
            this.a = 7;
            this.b = 8;
            this.c = 9;
                    }
        //Ctor Not Default
        public Triangle(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle( double b, double c)
        {
            this.a = 7;
            this.b = b;
            this.c = c;

        }
       


        public double Paragic()
        {        
            P = a + b + c;
            return P;
        }
        
        public double Area()
        {
            double S = 1;                        
            return S=(P-a)*(P-b)*(P-c)*P;
        }
    }
}