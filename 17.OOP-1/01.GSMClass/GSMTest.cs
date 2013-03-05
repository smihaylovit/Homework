using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.GSMTest
{
    class GSMTest
    {
        private const int instances = 3; //count of instances
        GSM[] arr = new GSM[instances];

        public void Create()
        {
            try
            {


                for (int i = 0; i < instances; i++)
                {
                    arr[i] = new GSM("3310", "nokia");
                    arr[i].Battery = new Battery("Belkin", null);
                }

            }
            catch (Exception)
            {

                throw new Exception("We have a problem in intilizing");
            }
        }

        public void Print()
        {
            try
            {
                foreach (GSM item in arr)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine(item.Battery.ToString());
                    Console.WriteLine(item.Display.ToString());
                }
            }
            catch (Exception)
            {
                
                throw new Exception("We have a problem in intilizing");
            }
        }

        public void PrintStatic()
        {
            try
            {
                Console.WriteLine(GSM.IPhone4s.ToString());
            }
            catch (Exception)
            {
                
                throw new Exception("We have a problem in intilizing");
            }
        }
    }
}
