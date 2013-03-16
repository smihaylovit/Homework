using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Zoo
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(int age, string name)
            : base(age, name, true) { }

        public void ProduceSound()
        {
            Console.WriteLine("Grau Grau"); //i don't know the tomcat sound :D
        }
    }
}
