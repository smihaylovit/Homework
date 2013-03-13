using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HumanBeings
{
    class Test
    {
        //this should have a wide scope :)
        private static readonly Random randomNumber = new Random();

        public static void Human()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Students");
            Console.WriteLine("==============================");

            //creating a list of 10 Students
            List<Student> myStudents = new List<Student>();
            int length = 10;
            
            for (int i = 0; i < length; i++)
            {
                string firstName = CreateName();
                string secondName = CreateName();
                myStudents.Add(new Student(CreateName(), CreateName(), RandomGrade()));    
            }

            //using LINQ
            
            //var sortedStudent =
            //    from student in myStudents
            //    orderby student.Grade
            //    select student;

            //using .OrderBy()
            var sortedStudent = myStudents.OrderBy(x => x.Grade);

            foreach (Student item in sortedStudent)
            {
                Console.WriteLine("{0} {1} {2} ", item.Grade, item.FirstName, item.SecondName);
            }


            //creating a list of 10 workers
            List<Worker> myWorkers = new List<Worker>();

            for (int i = 0; i < length; i++)
            {
                string firstName = CreateName();
                string secondName = CreateName();
                myWorkers.Add(new Worker(CreateName(), CreateName(), randomNumber.Next(100,1000), randomNumber.Next(20,46)));
            }

            //using LINQ
            var sortedWorkers =
                from worker in myWorkers
                orderby worker.MoneyPerHour()
                select worker;

            Console.WriteLine("\n\n==============================");
            Console.WriteLine("Workers");
            Console.WriteLine("==============================");
            foreach (Worker item in sortedWorkers)
            {
                 Console.WriteLine("{0:F2} {1} {2} ", item.MoneyPerHour(), item.FirstName, item.SecondName);
            }


            //merging the two lists
            List<Human> studentsList = new List<Human>(myStudents);
            List<Human> workerList = new List<Human>(myWorkers);
            studentsList.AddRange(workerList);

            var sortedList = studentsList.OrderBy(x => x.FirstName).ThenBy(x => x.SecondName);

            Console.WriteLine("\n\n==============================");
            Console.WriteLine("Merged Workers & Students");
            Console.WriteLine("==============================");

            foreach (Human item in sortedList)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.SecondName);
            }
            
        }
        
        private static string CreateName()
        {
            //this method will create a random name between 5 and 10 letters
            //Random randomNumber = new Random();
            
            //small letters ASCII is between 97 and 122
            //capital letters ASCII is between 65 and 90
            //the difference between small and capital letters is 32
            //randomChar.Next(97,123) generates random number and after that we get the capital one
            //we declare the first letter 
            string name = String.Empty + ((char)(randomNumber.Next(97,123)-32)); //we can use .ToString() instead
           
            int length = randomNumber.Next(4,10); //we already have one letter - firstLetter
            for (int i = 0; i < length; i++)
            {
                name += (char)(randomNumber.Next(97, 123));
            }

            return name;
        }

        private static int RandomGrade()
        {
            return randomNumber.Next(0, 11); //grade between 0 and 10
        }
    }
}
