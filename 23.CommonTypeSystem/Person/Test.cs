using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    class Test
    {
        public static void Person()
        {
            Person myPerson = new Person();
            myPerson.Name = "Kaliningradskaya Carskaya";
            Console.WriteLine(myPerson.ToString());
            myPerson.Age = 10;
            Console.WriteLine(myPerson.ToString());
        }
    }
}
