using System;
using System.Data;

namespace Ejercicio5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("write a number: ");
            int number = Int32.Parse(Console.ReadLine());
            table(number);
        }

        public static void table(int number)
        {
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine($"{number} * {i+1} = {number*(i+1)}"); 
            }
        }
    }
}