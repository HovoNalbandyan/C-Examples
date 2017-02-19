using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Lusatitik:ILight
    {
        //Method 
        public void Fly()
        {
             Console.WriteLine("i Can Fly");
        }

        public void GiveLight()
        {
            Console.WriteLine("i am  Lusatitik");
        }
    }
}
