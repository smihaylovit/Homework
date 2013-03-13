using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class Teacher : Person, IComment
    {
        private string about;
        //one teacher can teach several Discplines that's why we will use a list
        //we can use the list implemented methods as .Add(), .Remove() etc.
        private List<Discipline> subjects = new List<Discipline>();

        public List<Discipline> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
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
        
        //we will the base() constructor to access the inherited property of Person -> Name :)
         public Teacher(string name)
            : base(name)
        { }


    }
}
