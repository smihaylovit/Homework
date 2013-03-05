using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class GSMCallHistoryTest
    {
        GSM myGSM = new GSM("3310", "Nokia", 345.23m, "Kircho"); //model and manafacturers are mandatory
        public void Test()
        {
            //Add few calls
            myGSM.Call = new Call(DateTime.Now, "++359 887 231 123", 32);
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now, "++44 772 123 94", 98);
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now.AddDays(1), "++887 231 123", 32);
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now.AddDays(2), "++359 111 2222", 47);
            myGSM.CallHistory.Add(myGSM.Call);
            myGSM.Call = new Call(DateTime.Now.AddDays(3), "++1 273 1230", 77);
            myGSM.CallHistory.Add(myGSM.Call);

            //Display CallHistory
            myGSM.CallHistory.DisplayHistory();

            //Calculate Price
            myGSM.CallHistory.CalculateBill(0.37m);

            //remove Longest Call
            RemoveLongestCall(myGSM);
            myGSM.CallHistory.DisplayHistory();

            //clear the history
            myGSM.CallHistory.Clear();
            myGSM.CallHistory.DisplayHistory();

        }

        public void RemoveLongestCall(GSM currentGSM)
        {
            int longestCall = 0;
            int currentIndex = 0;
            int index=0;

            foreach (Call item in currentGSM.CallHistory.History)
            {
                
                if (item.Duration>longestCall)
                {
                    longestCall = item.Duration;
                    index = currentIndex;
                }
                    currentIndex++;
            }

            currentGSM.CallHistory.RemoveAt(index);
        }
    }

