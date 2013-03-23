using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.BitArray64
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 test = new BitArray64(1719);

            foreach (int item in test)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine(test[1]);
        }
    }
}
