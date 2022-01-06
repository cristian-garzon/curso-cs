using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("nums of array: ");
            int number = Int32.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            for (int i = 0; i < number; i++)
            {
                Console.Write($"num {i + 1}: ");
                nums.Add(Int32.Parse(Console.ReadLine()));
            }
            
            Console.Write("index to insert value: ");
            int index = Int32.Parse(Console.ReadLine());
            
            
            Console.Write("value to insert: ");
            int value = Int32.Parse(Console.ReadLine());
            
            nums.Insert(index,value);

            foreach (var num in nums)
            {
               Console.WriteLine(num); 
            }
        }
    }
}