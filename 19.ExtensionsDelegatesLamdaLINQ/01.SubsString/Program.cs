using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Implement an extension method Substring(int index, int length) for 
//the class StringBuilder that returns new StringBuilder and has the same 
//    functionality as Substring in the class String.


namespace _01.SubsString
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder test = new StringBuilder("Hello World!");
            
            Console.WriteLine(test.SubString(1,4));
        }
    }
}
