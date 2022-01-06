using System;

namespace Ejercicio10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"write the number {i + 1}: ");
                int number = Int32.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    total += number;
                }
                else
                {
                    total -= number;
                }
            }

            Console.Write($"total: {total} ");
        }
    }
}