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
    

    
    public Call() { }
    public Call(DateTime time, string dialedNumber, int duration)
    {
        
        Date = time.Date;
        Time = time.TimeOfDay;
        DialedNumber = dialedNumber;
        Duration = duration;
    }

    
}

