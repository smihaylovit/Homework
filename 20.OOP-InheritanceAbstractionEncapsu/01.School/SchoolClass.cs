using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class SchoolClass : IComment
    {
        private string textID;
        //we can have a set of teachers
        //we can use the list implemented methods as .Add(), .Remove() etc.
        private List<Teacher> teachers = new List<Teacher>();
        
        //we can have a set of students
        //we can use the list implemented methods as .Add(), .Remove() etc.
        private List<Student> students = new List<Student>();
        private string about;


        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        
        public string TextID
        {
            get { return textID; }
            set { textID = value; }
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

        public SchoolClass(string textID)
        {
            this.TextID = textID;
        }
    }
}
