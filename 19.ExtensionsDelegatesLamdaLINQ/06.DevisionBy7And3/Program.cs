using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.DevisionBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 21, 7, 3, 42, 12, 20, 11, 10};


            //using LINQ
            var devidedBy7And3 =
                from integer in myArray
                where integer%7 == 0 && integer % 3 == 0 // we can use and this one as well integer%21 == 0
                select integer;

            foreach (int item in devidedBy7And3)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
            
            //using  LAMBDA expressions
            foreach (int item in myArray.Where(x => x % 7 == 0 && x % 3 == 0)) //we can use and x%21== 0 as well 
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
