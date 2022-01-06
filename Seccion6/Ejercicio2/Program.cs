using System;
using System.Text;

namespace Ejercicio2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("write your name: ");
            string name = Console.ReadLine();
            StringBuilder eman = new StringBuilder();
            for (int i = name.Length - 1; i >= 0 ; i--)
            {
                eman.Append(name[i]);
            }
            Console.WriteLine(eman);
        }
    }
}