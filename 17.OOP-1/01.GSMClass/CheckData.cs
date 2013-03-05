using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CheckData
{
    //check for negative values
    public static bool IsNegative(double? Idle)
    {
        return Idle < 0;
    }

    //check for null or String.Empty
    public static bool IsNull(string model)
    {
        return (model == null || model.Length < 1);

    }
}
