using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
   class JuniorClass : BaseClass
    {
        public bool hybrid;
        public bool electromobile;
        public JuniorClass(bool hybrid,bool electromobile):
            base(string  carname, int petrol, string country, int volumeEngine)
        {
            Console.WriteLine("b");
            this.hybrid = hybrid;
            this.electromobile = electromobile;
        }
    }





}
