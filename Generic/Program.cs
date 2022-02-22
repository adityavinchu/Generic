using System;

namespace Generic
{
    public class Program
    {

        public static void Main(string[] args)
        {
            TestMaximum<int> maxint = new TestMaximum<int>(1, 5, 3,54);
            TestMaximum<float> maxfloat = new TestMaximum<float>(1.4f, 5.5f, 3.5f, 5.4f);
            TestMaximum<string> maxstring = new TestMaximum<string>("d", "w", "t", "r");

            //int max=maxint.MaximumNumber();
            //    maxfloat.Print(max);

            //float max=maxfloat.MaximumNumber();
            //    maxfloat.Print(max);

            string max= maxstring.MaximumNumber();
            maxstring.Print(max);

            Console.ReadLine();
        }
    }
}
