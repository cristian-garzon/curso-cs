using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"num {i + 1}: ");
                nums.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"mayor: {nums.Max()} \n" +
                              $"menor: {nums.Min()}");
        }
    }
}