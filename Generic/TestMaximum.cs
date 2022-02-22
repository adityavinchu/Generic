using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class TestMaximum
    {
        public static double MaximumNumber(double firstnumber, double secondnumber, double thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0)
            {
                return firstnumber;
            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0) 
            { 
                return secondnumber;
            }
            else
                return thirdnumber;

        }
    }
}
