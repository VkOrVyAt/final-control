using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Programm 
    {
        public static List<string> SortArray(string[] array)
        {
            var result = new List<string>();
            foreach (var item in array)
                if (item.Length <= 3)
                    result.Add(item);
            return result;
        }

        public void Main()
        {
            var test1 = new string[4] {"rere", "ree", "r", "re"};
            var test2 = new string[3] {"", "e", "."};
            var test3 = new string[0];
        }
    }
}