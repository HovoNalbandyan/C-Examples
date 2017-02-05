using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Triangle
    {
        double a=8;
        double b;
        double c;
        //Ctor      
        public Triangle()
        {      }
        public double Paragic(double a, double b, double c,double P=0)
        {        
            P = a + b + c;
            return P;
        }
        
        public double Area(double a, double b, double c)
        {
            double P =Paragic(7,8,9);          
            double S = Paragic.invoke;
            return S;
        }
    }
}