using System;
using System.Xml;

namespace Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("write price: ");
            int price = Int32.Parse(Console.ReadLine());
            Console.Write("1 dollar to euro \n" +
                          "2. euro to dollar \n " +
                          "choose option:");
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
               case 1:
                   dollarToEuro(price);
                   break;
               case 2:
                   euroToDollar(price);
                   break;
               default:
                   Console.WriteLine("that is not opcion");
                   break;
            }
        }

        public static void dollarToEuro(int price)
        {
            Console.WriteLine($"dollar to euro of {price} is: {price * 0.88}");
        }

        public static void euroToDollar(int price)
        {
            Console.WriteLine($"euro to dollar of {price} is: {price * 1.13}");
        }
    }
}