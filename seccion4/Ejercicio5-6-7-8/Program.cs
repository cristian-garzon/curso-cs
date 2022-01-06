using System;

namespace Ejercicio5_6_7_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("for");
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i + 1}");
            }

            Console.WriteLine("while");
            int j = 0;
            while (j < 100)
            {
                Console.WriteLine($"{j + 1}");
                j++;
            }

            Console.WriteLine("par");
            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    Console.WriteLine($"{i + 1}");
                }
            }

            Console.WriteLine("par divisible en 3");
            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 2 == 0 || (i+1) % 3 == 0)
                {
                    Console.WriteLine($"{i + 1}");
                }
            }
        }
    }
}