using System;

namespace Ejercicio4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("price of product: ");
            int price = Int32.Parse(Console.ReadLine());

            Console.WriteLine("payment method: ");
            string methodPayment = Console.ReadLine().ToLower();

            if (methodPayment == "debit" || methodPayment == "credit")
            {
                Console.WriteLine("count number: ");
                long count = long.Parse(Console.ReadLine());
                Console.WriteLine($"payment success :D  \n count: {count} \n price: {price}");
            }
            else
            {
                Console.WriteLine($"payment success :D \n price: {price}");
            }
        }
    }
}