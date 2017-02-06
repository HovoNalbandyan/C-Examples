using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Triangle
    {
        
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
            double S = 1;
            double P =Paragic(7,8,9);     
            
            return S=(P-a)*(P-b)*(P-c)*P;
        }
    }
}