using System;
using System.Runtime.CompilerServices;

namespace Ejercicio3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.Write($"choose number of animal: ");
            animal.tipo = Int32.Parse(Console.ReadLine());
            switch (animal.tipo)
            {
                case (int) Animals.bird:
                    Console.WriteLine($"is a bird");
                    break;
                case (int) Animals.cat:
                    Console.WriteLine($"is a cat");
                    break;
                case (int) Animals.dog:
                    Console.WriteLine($"is a dog");
                    break;
                case (int) Animals.horse:
                    Console.WriteLine($"is a horse");
                    break;
                
                default:
                    Console.WriteLine($"there is not animals with this num");
                    break;
            }
        }
    }
}