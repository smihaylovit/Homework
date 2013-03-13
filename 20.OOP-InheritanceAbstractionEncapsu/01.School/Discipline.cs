using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class Discipline : IComment
    {
        private string name;
        private int lectures;
        private int exercises;
        private string about;

        //I use this as static properties because the discplines are pre-defined
        //this is my understanding for school :)
        //if new discpline is needed we can use the constructor
        //or we can change the lectures of the current pre-defined

        public static Discipline Math = new Discipline("Mathematic", 10, 5);
        public static Discipline Chemistry = new Discipline("English", 10, 5);
        public static Discipline BritishEnglish = new Discipline("English", 10, 5);
        public static Discipline AmericanEnglish = new Discipline("English", 10, 5);


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

        public int Exercises
        {
            get { return exercises; }
            set { exercises = value; }
        }
        

        public int Lectures
        {
            get { return lectures; }
            set { lectures = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Discipline(string name, int lectures, int exercies)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercies;
        }
    }
}
