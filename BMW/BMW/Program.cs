using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Motorcycle motorcycle = new Motorcycle();
            car.Start();
            bicycle.Start();
            motorcycle.Start();


        }
    }
}
