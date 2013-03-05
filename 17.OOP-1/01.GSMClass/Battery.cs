using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//this is our enumerations with type of batteries
public enum BatteryType
{
    LiIon, NiMh, NiCd
}

class Battery
{

    //<fields>
    private string model;
    private double? idle;
    private double? talk;
    //</fields>

    //<properties>
    //battery model
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            //encapsulate data
            if (CheckData.IsNull(value))
            {
                throw new ArgumentException("The battery model is mandatory field!");
            }

            this.model = value;
        }
    }

    //battery consumptions - hours in idle mode
    public double? Idle
    {
        get
        {
            return this.idle;
        }
        set
        {
            //encapsulate data
            if (CheckData.IsNegative(value))
            {
                throw new ArgumentException("The Idle Time Can't be Negative!");
            }
            this.idle = value;
        }
    }

    //battery consumptions - hours in talk mode
    public double? Talk
    {
        get
        {
            return this.talk;
        }
        set
        {
            //encapsulate data
            if (CheckData.IsNegative(value))
            {
                throw new ArgumentException("The Talk Time Can't be Negative!");
            }
            this.talk = value;
        }
    }
    public BatteryType? Type { get; set; } //batterry type of enumeration BatteryType
    //</properties>

    //<constructors>
    public Battery() { }
    //we have one mandatory field for the model, actually it could be null
    public Battery(string model)
        : this(model, null, null) { } //recalls GSM with the whole list of items

    public Battery(string model, double? idle)
        : this(model, idle, null) { } //recalls GSM with the whole list of items

    public Battery(string model, double? idle, double? talk)
    {
        this.talk = talk;
        this.idle = idle;
        this.model = model;
    }
    //</constructors>

    //<methods>
    //OverRide .ToString()

    public override string ToString()
    {
        string result = String.Format("Model: {0}\nIdle: {1}\nTalk: {2}", Model, Idle, Talk);

        return result;
    }
    //Print all Battery information
    public void Print()
    {
        Console.WriteLine("Battery Properties");
        Console.WriteLine("===================");
        Console.WriteLine("Model: {0}", this.Model ?? "[uknown]");

        //(int)this.Idle, (this.Idle - (int)this.Idle)*60
        //calculate the hours and the minutes because it is in double format
        if (this.Idle != null)
        {
            Console.WriteLine("Idle hours: {0}:{1,2} hours", (int)this.Idle, (this.Idle - (int)this.Idle) * 60);
        }
        else
        {
            Console.WriteLine("Idle hours: [unknown]");
        }
        if (this.Talk != null)
        {
            Console.WriteLine("Talk hours: {0}:{1,2} hours", (int)this.Talk, (this.Talk - (int)this.Talk) * 60);
        }
        else
        {
            Console.WriteLine("Talk hours: [unknown]");
        }

        Console.WriteLine("===================");
    }
    //</methods>
}
