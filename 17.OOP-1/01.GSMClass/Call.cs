using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Call
{

    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string DialedNumber { get; set; }
    public int Duration { get; set; }
    private static List<Call> CallHistory = new List<Call>();

    public List<Call> History
    {
        get
        {
            return CallHistory;
        }
    }

    
    public Call() { }
    public Call(DateTime time, string dialedNumber, int duration)
    {
        
        Date = time.Date;
        Time = time.TimeOfDay;
        DialedNumber = dialedNumber;
        Duration = duration;
    }

    public void Add(Call curentCall)
    {
        CallHistory.Add(curentCall);
    }

    public void Clear()
    {
        CallHistory.Clear();
    }

    public void RemoveAt(int index)
    {
        if (index>= CallHistory.Count)
        {
            //check if the index is out of range
            throw new IndexOutOfRangeException("There is no such call!");
        }
        CallHistory.RemoveAt(index);
    }

    public void DisplayHistory()
    {
        int index = 0;
        foreach (Call item in CallHistory)
        {
            Console.WriteLine("ID: {0} Date: {1}, Dialed: {2}, Duration: {3}", index, item.Date, item.DialedNumber, item.Duration);
            index++;
        }
    }
    public void CalculateBill(decimal price)
    {
        int callDuration = 0;
        foreach (Call item in CallHistory)
        {
            callDuration += item.Duration;
        }
        Console.WriteLine("The price is: {0}", (callDuration/60.0m)*price);
    }
}

