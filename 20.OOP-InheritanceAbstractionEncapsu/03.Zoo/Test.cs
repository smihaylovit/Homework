using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Zoo
{
    abstract class Test
    {
        public static void CreateAnimals()
        {
            //   List<Dog> myDogs = new List<Dog>();

            Dog[] myDogs = new Dog[]
            {

               new Dog(10, "Combo", true),
               new Dog(20, "Trombo", true),
               new Dog(30, "Kokana", false),
               new Dog(40, "Sombana", false),
           };

            Kitty[] myKitties = new Kitty[] {
                new Kitty(10, "Combo"),
               new Kitty(20, "Trombo"),
               new Kitty(30, "Kokana"),
               new Kitty(40, "Sombana"),
            };

            Console.WriteLine("The average age of Dogs is: {0}", GetAverageAge(myDogs));
            Console.WriteLine("The average age of Kitties is: {0}", GetAverageAge(myKitties));
        }

        private static decimal GetAverageAge(Animal[] myAnimals)
        {
            int count = myAnimals.Length;
            decimal sum = 0;
            foreach (var item in myAnimals)
            {
                sum += item.Age;

            }

            return sum / count;
        }

    }
}
