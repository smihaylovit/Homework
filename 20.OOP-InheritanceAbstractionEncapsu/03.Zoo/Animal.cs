using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Zoo
{
    //we make this class abstract because we can't/don't need
    //to make an instance of it
    abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }

        public Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        
    }


}
