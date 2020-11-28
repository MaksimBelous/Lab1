using System;
using Lab1._1;
namespace Lab1._1
{
    public class MyString
    {
        private char[] symbols;

        public MyString(char[] symbols)
        {
            this.symbols = symbols;
        }

        public char[] Value()
        {
            return symbols;
        }
        public int Lenght()
        {
            return symbols.Length;
        }

        ~MyString()
        {
            Console.WriteLine($"The {ToString()} destructor is executing.");
            this.symbols = null;
        }

        public void Sort()
        {
            Array.Sort<char>(symbols, (a, b) => b.CompareTo(a));
        }

    }
}
