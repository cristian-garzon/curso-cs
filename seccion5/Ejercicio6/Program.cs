using System;
using System.Diagnostics;

namespace Ejercicio6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = 0, number = 1, more = 0, less = 0;
            while (number != 0)
            {
                Console.Write("chose number: ");
                number = Int32.Parse(Console.ReadLine());
                count++;
                if (number > more) more = number;
                if (less == 0) less = number;
                else
                {
                    if (number < less && number != 0) less = number;
                }
            }
            print(more,less,count);
        }

        public static void print(int more, int less, int count)
        {
            Console.WriteLine($"more: {more} \n" +
                              $"less: {less} \n" +
                              $"diference: {more-less} \n" +
                              $"numbers puts: {count}");
        }
    }
}