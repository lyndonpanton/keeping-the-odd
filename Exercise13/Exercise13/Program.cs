using System.Collections.Generic;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                integers.Add(i);
            }

            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }
        }
    }
}