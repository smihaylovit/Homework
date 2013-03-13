using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class School
    {
        private string name;
        private int id;
        //we can have several SchoolClasses that's why we use a list
        //we can use the list implemented methods as .Add(), .Remove() etc.
        private List<SchoolClass> classes = new List<SchoolClass>();

        public List<SchoolClass> Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public School(int id, string name)
        {
            this.Name = name;
            this.ID = id;
        }
    }
}
