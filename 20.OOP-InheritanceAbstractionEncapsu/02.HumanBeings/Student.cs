using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HumanBeings
{
    class Student : Human
    {
        //<fields>
        private int? grade;
        //</fields>

        //<properties>
        
        //using properties in case we need to make later
        //some data checks for correct input :)
        public int? Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        //</properties>

        //<constructors>

        //we have a constructor with names only
        //if no grade is presented
        public Student(string firstName, string secondName)
            :this(firstName, secondName, null) {}

        //we call the base() constructor to access the inherited properties 
        public Student(string firstName, string secondName, int? grade)
            : base(firstName, secondName)
        {
            this.Grade = grade;
        }
        //</constructors>
        
    }
}
