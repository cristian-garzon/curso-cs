using System;

namespace Ejercicio2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("write first number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("write second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                if (num1 > num2)
                {
                    Console.Write($"{num1}");
                }
                else
                {
                    Console.Write("they are equals");
                }
            }
            else
            {
                Console.Write($"{num2}");
            }
        }
    }
}