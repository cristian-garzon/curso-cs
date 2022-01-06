using System;

namespace Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("pajaro");
            animal.andar(); 
            animal.saltar();
            if(animal.esPerro()) Console.WriteLine("si es perro");
            else Console.WriteLine("no es un perro"); 
            
            Animal animal2 = new Animal("perro");
            animal2.andar(); 
            animal2.saltar();
            if(animal2.esPerro()) Console.WriteLine("si es perro");
            else Console.WriteLine("no es un perro"); 
        }
    }
}