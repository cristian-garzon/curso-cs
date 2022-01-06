using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int pares = 0, impares = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"num {i + 1}: ");
                nums.Add(Int32.Parse(Console.ReadLine()));
            }

            foreach (var num in nums)
            {
                if (num % 2 == 0) pares += num;
                else impares += num;
            }
            
            Console.WriteLine($"par: {pares} \n" +
                              $"impar: {impares}");
            
        }
    }
}