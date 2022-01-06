using System;

namespace Ejercicio11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("day of week: ");
            int day = Int32.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                   Console.WriteLine("tuesday");
                    break;
                case 3:
                   Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                   Console.WriteLine("friday");
                    break;
                case 6:
                   Console.WriteLine("saturday");
                    break;
                case 7:
                   Console.WriteLine("sunday");
                    break;
                default:
                   Console.WriteLine("that is not day of week :c");
                    break;
            }
        }
    }
}