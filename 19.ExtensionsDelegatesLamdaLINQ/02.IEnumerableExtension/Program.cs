using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.IEnumerableExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>{ 1, 1, 3, 4 };
            Console.WriteLine( test.Sum<int>());
            Console.WriteLine(test.Product<int>());
            Console.WriteLine(test.Average<int>());
            Console.WriteLine(test.Min<int>());
            Console.WriteLine(test.Max<int>());
        }
    }
}
