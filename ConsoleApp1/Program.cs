using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            singleton c = singleton.getInstance(); // det här bästa sätt att anväda 
            Console.ReadKey();
        }
    }
}
