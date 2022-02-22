using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class TestMaximum
    {
        public static string Maximumstring(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            {
                return firststring;
            }
            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0) 
            { 
                return secondstring;
            }
            else
                return thirdstring;

        }
    }
}
