using System;

namespace Ejercicio2
{
    internal class Program
    {
        public static int num1 = 0, num2 = 0;

        public static void Main(string[] args)
        {
            int option = 0;
            while (option != 5)
            {
                menu();
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        numbers();
                        Console.WriteLine(suma(num1, num2));
                        break;
                    case 2:
                        numbers();
                        Console.WriteLine(resta(num1, num2));
                        break;
                    case 3:
                        numbers();
                        Console.WriteLine(multiplicacion(num1, num2));
                        break;
                    case 4:
                        numbers();
                        if (num2 == 0)
                        {
                            Console.WriteLine("math error");
                        }
                        else
                        {
                            Console.WriteLine(division(num1, num2));
                        }
                        break;
                }
            }
        }

        public static void menu()
        {
            Console.WriteLine("1. suma \n" +
                              "2. resta \n" +
                              "3. multiplicacion \n" +
                              "4. division \n" +
                              "5. exit \n" +
                              "choose option: ");
        }

        public static int suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int division(int num1, int num2)
        {
            return num1 / num2;
        }

        public static void numbers()
        {
            Console.Write("number 1: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("number 2: ");
            num2 = Int32.Parse(Console.ReadLine());
        }
    }
}