using System;

namespace Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("write your name: ");
            string name = Console.ReadLine().ToLower().Trim();
            if(name.Equals("alejandro")) Console.WriteLine("hello");
            else Console.WriteLine("who are you?");
            
        }
    }
}