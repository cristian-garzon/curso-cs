using System;

namespace Ejercicio13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool primo = true;
            Console.Write("write a number: ");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 && i != number)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                Console.WriteLine("es primo");
            }
            else
            {
                Console.WriteLine("no es primo");
            }
        }
    }
}