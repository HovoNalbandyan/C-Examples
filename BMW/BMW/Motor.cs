using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW
{
   public abstract class Motor
    {
        double Liter;
        double HorsePow;
        public abstract void MotorValue();
        public virtual void CrashCar()
        {
            Console.WriteLine("Virtual Metod PTT");
        }
        
    }
   
}
