using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HumanBeings
{
    //we can't make instances of abstract class 
    abstract class Human
    {
        //<fields>
        private string firstName;
        private string secondName;
        //</fields>

        //<properties>
        //using properties in case we need to make later
        //some data checks for correct input :)
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        //</properties>

        //<constructor>
        public Human(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
        //</constructor>
    }
}
