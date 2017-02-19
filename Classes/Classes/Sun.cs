using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Sun : Planet, ILight
    {
        //------------------------------------------
        public void GiveLight()//ILight Interface Method 
        {
            Console.WriteLine("I am sun");
        }
        //------------------------------------------

        public void SunFunc()//Sun Method
        {
            Console.WriteLine("I can sunero");
        }

        //Abstract Class method
        public override void turn()//abstractna
        {
            Console.WriteLine("Arevn pttvec");
        }
        //virtual 
        public override void ptt()//virtualna  defalut base na kanchum  isk uzenq karanq mern grenq
        {
            Console.WriteLine("I am ovveride");
            base.ptt();
        }
    }
}
