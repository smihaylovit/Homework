using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _07.Delegates
{
    public delegate void MyDelegate();
    class Timer
    {
        private int delay; //delay in milliseconds
        private int count; //the count of executions of the method
        private MyDelegate target;
      
        public Timer(int delay, int count)
        {
            this.delay = delay;
            this.count = count;
        }

        public void Repeat(MyDelegate target)
        {
            int i = 0;
            this.target = target;
            while (i<count)
            {
                this.target();
                Thread.Sleep(delay); 
                i++;
            }
        }
    }
}
