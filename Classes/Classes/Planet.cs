using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     abstract class Planet
    {
        double r;
        double massa;
        public abstract void turn();
        //body chi kara unena

        public virtual void ptt()
        {
            Console.WriteLine("Virtual Metod PTT");
        } 
    }
}
