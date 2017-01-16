using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Մուտքագրել Լատինատառ Բառ");
            Console.WriteLine(  );
            Console.Write("Լատինատառ" + "  ");

            string str = "աբգդեզէըթժիլխծկհձղճմյնշոչպջռսվտրցուփքևօֆ";

            string str1 = "abcdefghjklmnopqrstuvwxyz";
            Dictionary<string, string> lettercollection = new Dictionary<string, string>();

            lettercollection.Add("a", "ա");
            lettercollection.Add("b", "բ");
            lettercollection.Add("c", "ց");
            lettercollection.Add("d", "դ");
            lettercollection.Add("e", "ե");
            lettercollection.Add("f", "ֆ");
            lettercollection.Add("g", "գ");
            lettercollection.Add("h", "հ");
            lettercollection.Add("i", "ի");
            lettercollection.Add("j", "ջ");
            lettercollection.Add("k", "կ");
            lettercollection.Add("l", "լ");
            lettercollection.Add("m", "մ");
            lettercollection.Add("n", "ն");
            lettercollection.Add("o", "օ");
            lettercollection.Add("p", "պ");
            lettercollection.Add("q", "ք");
            lettercollection.Add("r", "ռ");
            lettercollection.Add("s", "ս");
            lettercollection.Add("t", "տ");
            lettercollection.Add("u", "ու");
            lettercollection.Add("v", "վ");
            lettercollection.Add("w", "ո");
            lettercollection.Add("x", "խ");
            lettercollection.Add("y", "յ");
            lettercollection.Add("z", "զ");
            lettercollection.Add("@", "ը");


            // lettercollection.Add("b", "է");
            lettercollection.Add("dz", "ձ");
            lettercollection.Add("ev", "և");
            //lettercollection.Add("r", "ր");
            lettercollection.Add("ch", "չ");
            //lettercollection.Add("ch", "ճ");
            lettercollection.Add("jh", "ժ");
            lettercollection.Add("gh", "ղ");
            lettercollection.Add("sh", "շ");



            string a = Console.ReadLine();
            string newstr = "";
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == 's' && a[i + 1] == 'h'&& i!=a.Length)
                {

                    newstr = newstr + lettercollection["sh"];
                    i++;
                }
                
              else   if (a[i] == 'g' && a[i + 1] == 'h' && i != a.Length )
                {

                    newstr = newstr + lettercollection["gh"];
                    i++;
                }
                else if (a[i] == 'j' && a[i + 1] == 'h' && i != a.Length)
                {

                    newstr = newstr + lettercollection["jh"];
                    i++;
                }
                else if (a[i] == 'e' && a[i + 1] == 'v' && i != a.Length)
                {

                    newstr = newstr + lettercollection["ev"];
                    i++;
                }
                else if (a[i] == 'd' && a[i + 1] == 'z' && i != a.Length)
                {

                    newstr = newstr + lettercollection["dz"];
                    i++;
                }
                else if (a[i] == 'c' && a[i + 1] == 'h' && i != a.Length)
                {

                    newstr = newstr + lettercollection["ch"];
                    i++;
                }
                else
                newstr = newstr + lettercollection[a[i].ToString()];
            }
            Console.Write("Հայատառ"+"  ");
            Console.WriteLine(newstr);
            Console.ReadKey();

          //  KeyValuePair<string, string> aa = new KeyValuePair<string, string>();

           
        }
    }
}
