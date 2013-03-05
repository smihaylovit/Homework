using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class CallHistory
    {
        private static List<Call> history = new List<Call>();

        public List<Call> History
        {
            get
            {
                return history;
            }
        }

        public void Add(Call curentCall)
        {
            history.Add(curentCall);
        }

        public void Clear()
        {
           history.Clear();
        }

        public void RemoveAt(int index)
        {
            if (index >= history.Count)
            {
                //check if the index is out of range
                throw new IndexOutOfRangeException("There is no such call!");
            }
           history.RemoveAt(index);
        }

        public void DisplayHistory()
        {
            int index = 0;
            foreach (Call item in history)
            {
                Console.WriteLine("ID: {0} Date: {1}, Dialed: {2}, Duration: {3}", index, item.Date, item.DialedNumber, item.Duration);
                index++;
            }
        }
        public void CalculateBill(decimal price)
        {
            int callDuration = 0;
            foreach (Call item in history)
            {
                callDuration += item.Duration;
            }
            Console.WriteLine("The price is: {0}", (callDuration / 60.0m) * price);
        }
    }

