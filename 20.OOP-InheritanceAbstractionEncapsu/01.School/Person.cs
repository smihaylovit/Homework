using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    //we are creating an abstract class because
    //we don't need just a Person in school - 
    //we have students or teachers which will inherit this class

    abstract class Person
    {
        //maybe it's better with firstName and secondName but
        //just a name is enough to get several names "Ivan Georgiev"
        private string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
