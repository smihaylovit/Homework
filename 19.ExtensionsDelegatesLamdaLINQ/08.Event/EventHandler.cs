using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public delegate void EventHandler(object sender, CustomEventArgs e);
public class CustomEventArgs : EventArgs
{
    //fields
    private int loopsLeft;
    //</fields>
    public int LoopsLeft
    {
        get
        {
            return this.loopsLeft;
        }
    }

    public CustomEventArgs(int loopsLeft)
    {
        this.loopsLeft = loopsLeft;
    }
}
