using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GSM
{
    //<fields>
    private string model;
    private string manafacturer;
    private decimal? price;
    private string owner;
    public static GSM IPhone4s = new GSM("iPhone4s", "Apple", 111.34m, "Mike Seshten");
    
    //</fields>

    //<properties>
    //gsm model
    public string Model
    {
        get { return this.model; }
        set
        {
            if (CheckData.IsNull(value))
            {
                throw new ArgumentException("The Model field is mandatory");
            }
            this.model = value;
        }
    }

    //the manafacturer of the gsm
    public string Manafacturer
    {
        get { return this.manafacturer; }
        set
        {
            if (CheckData.IsNull(value))
            {
                throw new ArgumentException("The Manafacturer field is mandatory");
            }
            this.manafacturer = value;
        }
    }
    //the price in decimal type
    public decimal? Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The Price can't be negative");
            }
            this.price = value;
        }
    }
    public string Owner   //the gsm owner 
    {
        get { return this.owner; }
        set
        {
            //i'm not sure wether to check it for numbers
            //but it can be owner personal ID or Robert 3rd :)
            this.owner = value;
        }
    }

    //</properties>


    //<constructors>

    public GSM(string model, string manafacturer)
        : this(model, manafacturer, null, null) { } //recalls GSM with the whole list of items

    public GSM(string model, string manafacturer, decimal? price)
        : this(model, manafacturer, price, null) { } //recalls GSM with the whole list of items

    public GSM(string model, string manafacturer, decimal? price, string owner)
    {
        this.Model = model;
        this.Manafacturer = manafacturer;
        this.Price = price;
        this.Owner = owner;
    }
    //</constructors>

    //adding battery class for the gsm one so
    //we can access Battery.Idle property etc.
    public Battery Battery = new Battery();

    //adding display class for the gsm one so
    //we can access Display.Size property etc.
    public Display Display = new Display(null);

    //adding display class for the gsm one so
    //we can access Display.Size property etc.
    public Call Call;
    public int Test { get; private set; }
    //<methods>

    //override GSM.ToString() 

    public override string ToString()
    {
        string result = String.Format("Model: {0}\nManafacturer: {1}\nPrice: {2}\nOwner: {3}", Model, Manafacturer, Price, Owner);

        return result;
    }

    //Print all GSM information
    public void Print()
    {
        Console.WriteLine("GSM Properties");
        Console.WriteLine("===================");
        Console.WriteLine("Model: {0}", this.Model ?? "[unknown]");
        Console.WriteLine("Manafacturer: {0}", this.Manafacturer ?? "[unknown]");
        Console.WriteLine("Owner: {0}", this.Owner ?? "[unknown]");
        Console.WriteLine("Price: {0} EUR", this.Price);
        Console.WriteLine("===================");

    }

    //</methods>
}