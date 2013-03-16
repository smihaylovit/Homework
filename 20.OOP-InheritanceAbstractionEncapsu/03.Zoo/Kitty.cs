using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Zoo
{
    class Kitty : Cat, ISound
    {
        public Kitty(int age, string name)
            : base(age, name, false) { }

        public void ProduceSound()
        {
            Console.WriteLine("myauu myaauuu"); //i don't know the kitty  sound :D
        }
    }
}
