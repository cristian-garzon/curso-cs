using System;
using System.Collections.Generic;

namespace Ejercicio9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    numbers.Add(i+1); 
                }
            }

            foreach (var number in numbers)
            {
               Console.WriteLine(number); 
            }
        }
    }
}