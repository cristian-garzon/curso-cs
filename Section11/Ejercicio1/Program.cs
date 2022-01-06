using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 1;
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            do
            {
                Console.Write($"write a number: ");
                number = Int32.Parse(Console.ReadLine());

                Console.Write($"write a string: ");
                string frase = Console.ReadLine();

                dictionary.Add(number, frase);
            } while (number != 0);

            Console.Write($"write a string (2 letters): ");
            string find = Console.ReadLine();
            foreach (var dic in dictionary)
            {
                if(dic.Value.Contains(find)) Console.WriteLine($"key: {dic.Key} \nvalue: {dic.Value}");
            }
        }
    }
}