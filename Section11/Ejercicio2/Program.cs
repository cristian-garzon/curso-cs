using System;

namespace Ejercicio2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            gener<int> nums = new gener<int>();
            gener<string> names = new gener<string>();
            for (int i = 0; i < 3; i++)
            {
               Console.Write($"number {i+1}: "); 
               nums.add(Int32.Parse(Console.ReadLine()));
            }
            
            for (int j = 0; j < 3; j++)
            {
               Console.Write($"name {j+1}: "); 
               names.add(Console.ReadLine());
            }

            nums.print();
            names.print();
        }
    }
}