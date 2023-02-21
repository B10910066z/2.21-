using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 第三題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串");
            List<string> list = new List<string>();
//            List<string> list1 = new List<string>();
            var playNum = Convert.ToString(Console.ReadLine()).Split(',');
            foreach (var play in playNum)
            {
                list.Add(play);
            }
            //            var list1 = list.ToArray();
            Console.WriteLine("倒過來為:");
            for (int i = list.Count - 1;i >= 0; i--)
            {
                Console.Write($"{list[i]},");
            }
        }
    }
}
