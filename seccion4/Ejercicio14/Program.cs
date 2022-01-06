using System;

namespace Ejercicio14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.Write("write a number: ");
            int number = Int32.Parse(Console.ReadLine());

            while (number > 9)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine($"cifras: {count}"); 
        }
    }
}