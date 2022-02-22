using System;

namespace Generic
{
    public class Program
    {

        public static void Main(string[] args)
        {
            TestMaximum<int> maxint = new TestMaximum<int>();

            Console.WriteLine("Max:" + maxint.MaximumNumber(1, 5, 3));
            Console.ReadLine();
        }
    }
}
