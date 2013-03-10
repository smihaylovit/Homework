using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//Using delegates write a class Timer that has 
//    can execute certain method at each t seconds.


namespace _07.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Timer myTimer = new Timer(2000, 10); // 10 times per 2s delay(2000ms)
            myTimer.Repeat(PrintMe);
            
            Console.WriteLine("test");
        }

        public static void PrintMe()
        {

            Console.WriteLine("Wooooowwww :)))))");

        }
    }
}
