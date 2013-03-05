using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Display
{

    //<fields>
    private double? size;
    private double? colors;
    //</fields>
    //<properties>
    //size of the display in inches
    public double? Size
    {
        get
        {
            return this.size;
        }
        set
        {
            //encapsulate data
            if (CheckData.IsNegative(value))
            {
                throw new ArgumentException("The Size Can't be Negative!");
            }
            this.size = value;
        }
    }

    public double? Colors //colors count in millions
    {
        get
        {
            return this.colors;
        }
        set
        {
            //encapsulate data
            if (CheckData.IsNegative(value))
            {
                throw new ArgumentException("The Colors Can't be Negative!");
            }
            this.colors = value;
        }
    }
    //</properties>

    //<constructors>
    //we have one mandatory field for the model, actually it could be null
    public Display(double? size)
        : this(size, null) { } //recalls GSM with the whole list of items

    public Display(double? size, double? colors)
    {
        this.Size = size;
        this.Colors = colors;
    }
    //</constructors>
    
    
    //<methods>

    //override .ToString()
    public override string ToString()
    {
        string result = String.Format("Size: {0}\n Colors: {1}", Size, Colors);
        return result;
    }

    //print all Display information
    public void Print()
    {
        Console.WriteLine("Display Properties");
        Console.WriteLine("===================");
        Console.WriteLine("Size: {0}''", this.Size);
        Console.WriteLine("Colors: {0} millions", this.Colors);
        Console.WriteLine("===================");
    }

    //</methods>

}