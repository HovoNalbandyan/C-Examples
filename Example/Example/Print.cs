using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Print
    {
        public string name;
        public string surname;
        public string age;
        public Print()
        {

        }
        public Print(string name, string surname, string age)
        {
            this.age = age;
            this.surname = surname;
            this.name = name;

        }

        public void Print1(string name,string surname,string age)
        {
         Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(age);
        }

    }
    
}
