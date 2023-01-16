using System.Collections.Generic;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getting started
            List<int> integers = new List<int>();

            // problem 1
            for (int i = 1; i <= 10; i++)
            {
                integers.Add(i);
            }

            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            // problem 2
            for (int i = integers.Count - 1; i >= 0; i--)
            {
                // Console.WriteLine(integers[i]);
                if (integers[i] % 2 == 0)
                {
                    integers.RemoveAt(i);
                }
            }

            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            // problem 3
            List<int> moreIntegers = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            for (int i = 0; i < moreIntegers.Count; i++)
            {
                if (moreIntegers[i] >= 1 && moreIntegers[i] <= 3)
                {
                    moreIntegers.RemoveAt(i);
                }
            }

            foreach(int integer in moreIntegers)
            {
                Console.WriteLine(integer);
            }

        }
    }
}