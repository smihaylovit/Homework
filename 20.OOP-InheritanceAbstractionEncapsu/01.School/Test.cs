using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class Test
    {
        public static void School() 
        {
            //creating instances of Student class
            Student angel = new Student("Angel Dragomirov", 1);
            Student ivan = new Student("Ivan Dragomirov", 11);
            Student georgi = new Student("Georgi Haralampiev", 7);

            //creating instances of Teacher class
            Teacher petrov = new Teacher("Kiril Petrov");
            Teacher ivanov = new Teacher("Marian Ivanov");

            //Adding techers knowledge disciplines
            petrov.Subjects.Add(Discipline.Math);
            petrov.Subjects.Add(Discipline.Chemistry);

            ivanov.Subjects.Add(Discipline.AmericanEnglish);
            ivanov.Subjects.Add(Discipline.BritishEnglish);

            //creating instance of SchoolClass class
            SchoolClass AClass = new SchoolClass("AClass");

            //adding Students to the SchoolClass
            AClass.Students.Add(angel);
            AClass.Students.Add(ivan);
            AClass.Students.Add(georgi);

            //adding Teacher to the SchoolClass
            AClass.Teachers.Add(petrov);
            AClass.Teachers.Add(ivanov);

            //creating instance of School
            School mySchool = new School(51, "Elisaveta Bagryana");

            //adding SchoolClass to the School
            mySchool.Classes.Add(AClass);

            //adding optional comment
            AClass.About = "Geeks";

        }
    }
}
