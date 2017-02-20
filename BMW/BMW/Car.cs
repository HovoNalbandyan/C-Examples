using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW
{
    class Car : Motor,ICaracter
    {
        public void Name()
        {
            Console.WriteLine("Car BMW_E60");
        }
        public void Date()
        {
            Console.WriteLine("Car 2007");
        }

        public void Mass()
        {
            Console.WriteLine("Car 1700KG");
        }

        public void Price()
        {
            Console.WriteLine("Car 25000$");
        }

        public void Speed()
        {
            Console.WriteLine("Car 370 KM/H");
        }
        public void Start()
        {
            Name();
            Date();
            Mass();
            Price();
            Speed();
        }
        public override void MotorValue()
        {
            Console.WriteLine("Override Abs Method ");

        }
        public override void CrashCar()
        {
            Console.WriteLine("CarCrash oVerride Virtual Method");
        }
    }
}
