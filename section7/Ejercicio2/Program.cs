using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"name: {i + 1}: ");
                names.Add(Console.ReadLine());
            }
            Console.Write("search name: ");
            if (names.Contains(Console.ReadLine()))
            {
                Console.WriteLine("name find succesfully :D");     
            }
            else
            {
                Console.WriteLine("name not find :c");     
            }
        }
    }
}