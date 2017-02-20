using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW
{
    //public abstract class A
    //{
    //    public int mass;
    //    public A(int mass)
    //    {
    //        this.mass = 3;
    //    }
    //}
    //public class B :A
    //{
    //    public int weight;
    //    public B(int mass,int weight):base(mass)
    //    {
    //        this.weight = weight;
    //        this.mass = 8;
    //    }
        
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Motorcycle motorcycle = new Motorcycle();
            car.Start();
            //bicycle.Start();
            //motorcycle.Start();
            //virtual method          
            //abstract method
            //car.MotorValue();

        }
    }
}
