﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Laser:ILight
    {
        public void GiveLight()
        {
            Console.WriteLine("i am Laser");
        }

        public void LaserFunc()
        {
            Console.WriteLine("i can laserit");
        }
    }
}
