using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW
{
    class Motorcycle : ICaracter
    {
        public void Name()
        {
            Console.WriteLine("Motorcycle ZR1");
        }
        public void Date()
        {
            Console.WriteLine("Motorcycle 2016");
        }

        public void Mass()
        {
            Console.WriteLine("Motorcycle 250KG");
        }

        public void Price()
        {
            Console.WriteLine("Motorcycle 38000$");
        }

        public void Speed()
        {
            Console.WriteLine("Motorcycle 420 KM/H");
        }
        public void Start()
        {
            Name();
            Date();
            Mass();
            Price();
            Speed();
        }
    }
}
