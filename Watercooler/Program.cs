using System;
using System.Collections.Generic;

namespace Rosi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            List<string[]> input = new List<string[]>();

            for (int i = 0; i < testCases; i++)
            {
                input.Add(Console.ReadLine().Split(' '));

            }
            foreach (var testCase in input)
            {
                int rent = int.Parse(testCase[0]);
                int buy = int.Parse(testCase[1]);
                int months = int.Parse(testCase[2]);


                if (rent * months < buy)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }


            }


        }
    }
}