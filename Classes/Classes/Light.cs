using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Light:ILight
    {
        public void GiveLight()
        {
            Console.WriteLine("i fonar");
        }

        public void LightFunc()
        {
            Console.WriteLine("I can Lighting");
        }
    }
}
