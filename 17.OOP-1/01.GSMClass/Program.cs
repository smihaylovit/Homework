using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.GSMTest
{
    class Program
    {
        static void Main(string[] args)
        {

            GSM myGSM = new GSM("3310", "Nokia"); //model and manafacturers are mandatory
            GSMTest test = new GSMTest();
            //entering type of battery
            myGSM.Battery.Type = BatteryType.LiIon;

            myGSM.Owner = "Kiril Petrov"; //fake name :)
            myGSM.Price = 345.21m;

            
            myGSM.Battery.Idle = 6.5; //hours in idle mode of type double
            myGSM.Battery.Talk = 1.5; //hours in talk mode of type double

            myGSM.Display.Size = 7.4; //size in inches
            myGSM.Display.Colors = 16.5; //colors in millions

            //myGSM.Print(); //print GSM properties
            //myGSM.Battery.Print(); //print Battery properties
            //myGSM.Display.Print(); //print Display properties

            //06. print static field iPhone 4s
            Console.WriteLine(GSM.IPhone4s.ToString());

            //07.GSMTest
            //07.01.Create Array of GSM instances
            
            test.Create();
            
            //07.02. Display the information about the GSMs in the array
            
            test.Print();
            
            //07.03 Display the information about the static property IPhone4S.
            
            test.PrintStatic();

            //08.Call class

            myGSM.Call = new Call(DateTime.Now, "++359 887 231 123", 32);
            
            //09.Call add list
            
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now, "++44 772 123 94", 98);
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now.AddDays(1), "++887 231 123", 32);
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now.AddDays(2), "++359 111 2222", 47);
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now.AddDays(3), "++1 273 1230", 77);
            myGSM.CallHistory.Add(myGSM.Call);
            
            //09 Display the call History

            myGSM.CallHistory.DisplayHistory();
            
            //10.Call remove 
            Console.WriteLine("We will remove the call on position 1");

            myGSM.CallHistory.RemoveAt(1); //we remove calls by index number because in the real world is like that
            myGSM.CallHistory.DisplayHistory();

            //11.Calculate Bill
            myGSM.CallHistory.CalculateBill(0.37m);

            //12.GSM CallHistory Test
            Console.WriteLine("///////////////////");
            GSMCallHistoryTest historyTest = new GSMCallHistoryTest();

            historyTest.Test();

            Console.WriteLine("^^^^^^^^^^^^^^");
            GSM nokia = new GSM("htc", "galaxy");
            
            nokia.Call = new Call(DateTime.Now.AddDays(1), "++887 231 123", 32);
            nokia.CallHistory.Add(myGSM.Call);
            
            nokia.Call = new Call(DateTime.Now, "++359 887 231 123", 32);
            nokia.CallHistory.DisplayHistory();
            myGSM.CallHistory.DisplayHistory();
            
            
            DateTime obj = DateTime.Now;
            
        }
    }
}
