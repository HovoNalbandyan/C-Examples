using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW
{
   public abstract class Motor
    {
        //public double liter;
        //double horsePow;

        //public double HorsePow
        //{
        //    get
        //    {
        //        return horsePow;
        //    }

        //    set
        //    {
        //        horsePow = value;
        //    }
        //}
       
        public abstract void MotorValue();

        public virtual void CrashCar()
        {
            Console.WriteLine("Virtual method Car in Motor");
        }        
    }
   
}
