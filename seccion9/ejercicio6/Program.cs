using System;

namespace ejercicio6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("volador", "azul", 2, false);
            Console.WriteLine($"tipo: {animal.Tipo} \n" +
                              $"color de pelo: {animal.ColorPelo} \n" +
                              $"numero de patas: {animal.Patas} \n" +
                              $"es domestico: {animal.isDomestico()}");
        }
    }
}