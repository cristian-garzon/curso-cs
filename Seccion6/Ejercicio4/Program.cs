using System;
using System.Text;

namespace Ejercicio4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[4];
            StringBuilder concats = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
               Console.WriteLine($"num {i+1}");
               nums[i] = Int32.Parse(Console.ReadLine());
            }

            concats.Append($"el primer numero introducido es el {nums[0]} ");
            concats.Append($"despues han introducido {nums[1]} y {nums[2]} ");
            concats.Append($"y por ultimo el numero {nums[3]}");
            
            Console.WriteLine(concats);
        }
    }
}