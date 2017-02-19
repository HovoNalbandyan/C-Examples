using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace BMW
{
    class Bicycle : ICaracter
    {

        public void Name()
        {
            Console.WriteLine("Bicycle B1");
        }
        public void Date()
        {
            Console.WriteLine("Bicycle 2014");
        }

        public void Mass()
        {
            Console.WriteLine("Bycycle 14KG");
        }

        public void Price()
        {
            Console.WriteLine("Bycycle 500$");
        }

        public void Speed()
        {
            Console.WriteLine("Bycycle 50km/h");
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
