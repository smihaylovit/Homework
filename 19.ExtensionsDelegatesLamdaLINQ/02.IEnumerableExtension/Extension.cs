using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.IEnumerableExtension
{
    public static class Extension
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T[] sum = new T[1]; //creating a default value of paramater T
            foreach (T item in collection)
            {
                sum[0] += (dynamic)item; //it should be dynamic to be able to sum them
            }

            return sum[0];
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic sum = 1; //initializing the element
            foreach (T item in collection)
            {
                sum *= (dynamic)item; //it should be dynamic to be able to sum them
            }

            return sum;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T[] sum = new T[1]; //creating a default value of paramater T
            int count = 0;
            foreach (T item in collection)
            {
                sum[0] += (dynamic)item; //it should be dynamic to be able to sum them
                count++; //increment the counter
            }

            return (dynamic)sum[0]/count;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T minValue = (dynamic)collection.First(); //getting the first element of the collection
            foreach (T item in collection)
            {

                if (minValue>(dynamic)item)
                {
                    minValue = item;
                }
            }

            return minValue;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T maxValue = (dynamic)collection.First(); //getting the first element of the collection
            foreach (T item in collection)
            {

                if (maxValue < (dynamic)item)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }
    }
}
