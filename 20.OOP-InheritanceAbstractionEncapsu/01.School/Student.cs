using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class Student : Person, IComment
    {
        private int classID;
        private string about;

        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        //we will the base() constructor to access the inherited property of Person -> Name :)
        public Student(string name, int classID)
            : base(name)
        {
            this.ClassID = classID;
        }

        public string About
        {
            get
            {
                return about;
            }
            set
            {
                this.about = value;
            }
        }
    }
}
