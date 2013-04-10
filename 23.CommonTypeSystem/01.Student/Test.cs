using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Student
{
    class Test
    {
        public static void Student() 
        {
            Student myStudent = new Student();

            myStudent.FirstName = "Bonasera";
            myStudent.LastName = "Seniorita";
            myStudent.Faculty = Faculty.IT;
            myStudent.University = University.TelerikAcademy;
            myStudent.Specialty = Specialty.Chemistry;

            // testing cloning
            var clonedStudent = myStudent.Clone() as Student;
            Console.WriteLine("clonedStudent is Student: {0}", clonedStudent is Student);
            
            // Testing deep cloning
            myStudent.FirstName = "Mondial";
            Console.WriteLine("myStudent: {0}", myStudent.FirstName);
            Console.WriteLine("clonedStudent: {0}", clonedStudent.FirstName);

            clonedStudent.FirstName = "Mondial";
            Console.WriteLine("myStudent: {0}", myStudent.FirstName);
            Console.WriteLine("clonedStudent: {0}", clonedStudent.FirstName);
            
            // testing Equals
            Console.WriteLine("myStudent.Equals(clonedStudent): {0}", myStudent.Equals(clonedStudent));

            // testing .ToString();
            Console.WriteLine("clonedStudent Information: \n {0}", clonedStudent.ToString());
            // testing .GetHashCode();
            Console.WriteLine("GetHashCode() = {0}", clonedStudent.GetHashCode());

            // testing == and !=
            Console.WriteLine("myStudent==clonedStudent: {0}", myStudent == clonedStudent);
            Console.WriteLine("myStudent!=clonedStudent: {0}", myStudent != clonedStudent);

            // testing CompareTo
            Console.WriteLine("myStudent.CompareTo(clonedStudent): {0}", myStudent.CompareTo(clonedStudent));
            
            myStudent.FirstName = "AAAA";
            Console.WriteLine("myStudent.CompareTo(clonedStudent): {0}", myStudent.CompareTo(clonedStudent));
            myStudent.FirstName = "ZZZZ";
            Console.WriteLine("myStudent.CompareTo(clonedStudent): {0}", myStudent.CompareTo(clonedStudent));
            clonedStudent.FirstName = "ZZZZ";
            Console.WriteLine("myStudent.CompareTo(clonedStudent): {0}", myStudent.CompareTo(clonedStudent));
            clonedStudent.SSN = "123";
            Console.WriteLine("myStudent.CompareTo(clonedStudent): {0}", myStudent.CompareTo(clonedStudent));
            myStudent.SSN = "456";
            Console.WriteLine("myStudent.CompareTo(clonedStudent): {0}", myStudent.CompareTo(clonedStudent));
        }
    }
}
