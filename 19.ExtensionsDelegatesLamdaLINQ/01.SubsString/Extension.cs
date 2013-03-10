using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SubsString
{
    public static class Extension
    {
        //this StringBuilder sb is for specifing the class StringBuilder will be extended
        //with new functionallity SubString
        public static StringBuilder SubString(this StringBuilder source, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            //string source = sb.ToString();

            if (startIndex + length > source.Length )
            {
                throw new IndexOutOfRangeException("The boundaries are out of range!");
            }
            //algorithm
            for (int i = startIndex; i <= length; i++)
            {
                result.Append(source[i]);
            }

            return result;
        }
    }
}
