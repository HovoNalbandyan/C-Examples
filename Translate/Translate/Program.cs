using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"‪C:\Users\Hovhannes\Desktop\input.txt");
            


           /* Console.WriteLine("Մուտքագրել Լատինատառ Բառ");
            Console.WriteLine(  );
            Console.Write("Լատինատառ" + "  ");*/

            string str = "աբգդեզէըթժիլխծկհձղճմյնշոչպջռսվտրցուփքևօֆ";

            string str1 = "abcdefghjklmnopqrstuvwxyz";
            Dictionary<string, string> lettercollection = new Dictionary<string, string>();

            //lettercollection.Add("b", "է");
            lettercollection.Add("dz", "ձ");
            lettercollection.Add("ev", "և");
            //lettercollection.Add("r", "ր");
            lettercollection.Add("ch", "չ");
            //lettercollection.Add("ch", "ճ");
            lettercollection.Add("jh", "ժ");
            lettercollection.Add("gh", "ղ");
            lettercollection.Add("sh", "շ");
            lettercollection.Add(":)", "\u263A");
            lettercollection.Add("kh", "խ");

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
            lettercollection.Add(" ", " ");

            string a = Console.ReadLine();
            string newstr = "";
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (i != a.Length - 1)
            //    {
            //        if (a[i] == 's' && a[i + 1] == 'h') newstr = newstr + lettercollection["sh"];

            //        else if (a[i] == 'g' && a[i + 1] == 'h') newstr = newstr + lettercollection["gh"];

            //        else if (a[i] == 'j' && a[i + 1] == 'h') newstr = newstr + lettercollection["jh"];

            //        else if (a[i] == 'e' && a[i + 1] == 'v') newstr = newstr + lettercollection["ev"];

            //        else if (a[i] == 'd' && a[i + 1] == 'z') newstr = newstr + lettercollection["dz"];

            //        else if (a[i] == 'k' && a[i + 1] == 'h') newstr = newstr + lettercollection["kh"];

            //        else if (a[i] == 'c' && a[i + 1] == 'h') newstr = newstr + lettercollection["ch"];
            //    }
            //    newstr = newstr + lettercollection[a[i].ToString()];
            //}
            foreach (var item in lettercollection)
            {
                a = a.Replace(item.Key, item.Value);
            }

            System.IO.File.WriteAllText(@"‪C:\Users\Hovhannes\Desktop\output.txt", a);

            /*   Console.Write("Հայատառ"+"  ");
               Console.WriteLine(a);
               Console.WriteLine(newstr);
               Console.ReadKey();

            */



        }
    }
}
