using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program

    {
        
        static void Main(string[] args)
        {
            Light obj1 = new Light();
            Laser obj2 = new Laser();
            Lusatitik obj3 = new Lusatitik();
            Sun obj4 = new Sun();
            obj1.LightFunc();
            obj2.LaserFunc();
            obj3.Fly();
            obj4.SunFunc();
            obj1.GiveLight();
            obj2.GiveLight();
            Sun sun = new Sun();
            sun.ptt();    
        }
    }
    
}
