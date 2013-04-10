namespace _02.Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MainClass
    {
        public enum Sex 
        { 
            Male, Female 
        }

        public static void Main()
        {
            // Test the Human Class
            Human randomHuman = Create(10);
            Console.WriteLine("Name: {0} Age: {1} Sex: {2}", randomHuman.FullName, randomHuman.Age, randomHuman.Sex);
            
            randomHuman = Create(11);
            Console.WriteLine("Name: {0} Age: {1} Sex: {2}", randomHuman.FullName, randomHuman.Age, randomHuman.Sex);
        }

        public static Human Create(int magicNumber)
        {
            Human newHuman = new Human();
            newHuman.Age = magicNumber;
            if (magicNumber % 2 == 0)
            {
                newHuman.FullName = "TheBadGuy";
                newHuman.Sex = Sex.Male;
            }
            else
            {
                newHuman.FullName = "The Hot Chick";
                newHuman.Sex = Sex.Female;
            }

            return newHuman;
        }

        public class Human
        {
            public Sex Sex { get; set; }
            
            public string FullName { get; set; }
            
            public int Age { get; set; }
        }
    }
}
