using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._21練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串");
            List<int> list = new List<int>();
            var playNum =  Convert.ToString(Console.ReadLine()).Split(','); 
            foreach ( var play in playNum )
            {
                list.Add(Convert.ToInt32(play));
            }
            var list1 = list.OrderBy(x => x);
            Console.WriteLine("數字由小到大排列為: ");
            foreach (var play in list1)
            {
                Console.Write($"{play},");
            }
            
        }
    }
}
