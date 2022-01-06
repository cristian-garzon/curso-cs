using System;

namespace Ejercicio12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long total = 0;
            Console.Write("number of 1 to 1000: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number >= 1 && number <= 1000)
            {
                for (int i = 0; i < number; i++)
                {
                    total += i + 1;
                }
                Console.WriteLine($"total: {total} ");
                Console.WriteLine($"media: {total/number}");
            }
            else
            {
                Console.WriteLine("this is out of limits D: ");
            }
        }
    }
}