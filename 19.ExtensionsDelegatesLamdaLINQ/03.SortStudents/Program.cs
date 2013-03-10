using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method that from a given array of students finds all 
//students whose first name is before its last name alphabetically. 
//Use LINQ query operators.

namespace _03.SortStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> myStudents = new List<Student>    
            {
                new Student("Ivan", "Kirilov",18),
                new Student("Goran", "Valentinov",12),
                new Student("Carlo", "Bancelloti",13),
                new Student("Carlo", "Ancelloti",11),
                new Student("Robert","Di Mateo",24),
                new Student("Guus", "Hiddink",21)
            };

            //03. Write a method that from a given array of students finds 
            //    all students whose first name is before its last name 
            //alphabetically. Use LINQ query operators.

            var sortedStudents =
                from student in myStudents
                where student.FirstName.CompareTo(student.FamilyName) < 1
                select student;

            foreach (var item in sortedStudents)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.FamilyName);
            }

            //04. Write a LINQ query that finds the first name and 
            //last name of all students with age between 18 and 24.

            var sortedStudentsByAge =
                from student in myStudents
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("\nStudents between 18 and 24/including/: ");
            foreach (var item in sortedStudentsByAge)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.FamilyName, item.Age);
            }

            //05. Using the extension methods OrderBy() and ThenBy() with 
            // lambda expressions sort the students by first name and last 
            // name in descending order. Rewrite the same with LINQ

            //sorting DESCENDING
            var sortedLambda = myStudents.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.FamilyName);

            Console.WriteLine("\nSorted by Lambda Expression:");
            foreach (var item in sortedLambda)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.FamilyName);
            }

            var sortedLINQ =
                from student in myStudents
                orderby student.FirstName descending, student.FamilyName descending
                select student;

            Console.WriteLine("\nSorted by LINQ Expression:");
            foreach (var item in sortedLambda)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.FamilyName);
            }
        }
    }
}
