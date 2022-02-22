using System;

namespace Generic
{
    public class Program
    {

        public static void Main(string[] args)
        {
            TestMaximum<int> maxint = new TestMaximum<int>();
            TestMaximum<float> maxfloat = new TestMaximum<float>();
            TestMaximum<string> maxstring = new TestMaximum<string>();

            Console.WriteLine("Max:" + maxint.MaximumNumber(1, 5, 3,54));

            Console.WriteLine("Max:" + maxfloat.MaximumNumber(1.4f, 5.5f, 3.5f, 5.4f));

            Console.WriteLine("Max:" + maxstring.MaximumNumber("d", "w", "t", "r"));

            Console.ReadLine();
        }
    }
}
