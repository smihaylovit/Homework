using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.SortStudents
{
    class Student
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string familyName, int age)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
            this.Age = age;
        }
    }
}
