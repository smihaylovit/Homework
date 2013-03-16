using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Zoo
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, bool isMale)
            : base(age, name, isMale) { }

        public void ProduceSound()
        {
            Console.WriteLine("kwaaa Kwaaaa!");
        }
    }
}
