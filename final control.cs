using System;
namespace Program;

public class Solution
{
    public static List<string> SortArray(string[] array)
    {
        var result = new list<string>();
        foreach(var item in array)
        {
            if (item.Length <= 3)
                result.Add(item);
        }
        return result;
    } 

    public static void Main()  
    {
        var test = new Array[3] {"dsf","sdsdf"};
        Console.WriteLine(SortArray(test));
    }
}