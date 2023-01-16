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
        }
    }
}