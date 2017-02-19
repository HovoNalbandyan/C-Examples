using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Lune :Planet,ILight
    {
        public void GiveLight()
        {
            Console.WriteLine("i am Lusin");
        }

        public override void turn()
        {
            Console.WriteLine("i Can Fly abstact");
        }
        public 
    }
}
