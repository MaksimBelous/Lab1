using System;

namespace Lab1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var example = new MyString(new char[] { '$', '%', '&', '*','?' });
            Console.WriteLine("UNSORTED: " + new string(example.Value()));
            example.Sort();
            Console.WriteLine("SORTED: " + new string(example.Value()));
        }
    }
}
