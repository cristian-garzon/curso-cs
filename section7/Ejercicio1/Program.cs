using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int value = 0;
            for (int i = 0; i < 1000; i++)
            {
                nums.Add(i+1);
            }

            foreach (var num in nums)
            {
                value += num;
                Console.WriteLine(value);
            }
        }
    }
}