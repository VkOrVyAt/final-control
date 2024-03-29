using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Programm 
    {
        public static void PrintList(List<string> list)
        {
            foreach (string item in list)
                Console.Write(item + " ");
            Console.Write("\n");
        }

        public static List<string> SortArray(string[] array)
        {
            var result = new List<string>();
            foreach (var item in array)
                if (item.Length <= 3)
                    result.Add(item);
            return result;
        }

        public static void Main()
        {
            var test1 = new string[4] {"rere", "ree", "r", "re"};
            var test2 = new string[3] {"", "e", "."};
            var test3 = new string[0];
            PrintList(SortArray(test1));
            PrintList(SortArray(test2));
            PrintList(SortArray(test3));
        }
    }
}