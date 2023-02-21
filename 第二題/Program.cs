using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串");
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            var playNum = Convert.ToString(Console.ReadLine()).Split(',');
            foreach (var play in playNum)
            {
                list.Add(Convert.ToInt32(play));
            }
            foreach (int play in list)
            {
                if ( play % 2 ==0)
                {
                    list1.Add(play);
                }
                else
                {
                    list2.Add(play);
                }
            }
            Console.Write("偶數為: ");
            idea(list1);
            Console.Write("奇數為: ");
            idea(list2);
        }
        static void idea(List<int> soaus)
        {
            foreach (var item in soaus)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
        }
    }
}
