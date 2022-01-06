using System;

namespace Ejercicio3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("write day of week: ");
            string week = Console.ReadLine().ToLower();
            if (week == "friday" || week == "saturday" || week == "sunday")
            {
                Console.WriteLine("is weekend :D");
            }
            else
            {
                Console.WriteLine("not is weekend D:");
            }
        }
    }
}