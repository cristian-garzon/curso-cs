using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List <Person> persons = new List<Person>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"name of person {i+1}: ");
                string name = Console.ReadLine();
                
                Console.Write($"age of person {i+1}: ");
                int edad = Int32.Parse(Console.ReadLine());
                
                
                Console.Write($"type of person {i+1}: ");
                string type = Console.ReadLine().ToLower();
                
                if(type.Equals("estudiante")) persons.Add(new student(edad, name));
                if(type.Equals("profesor")) persons.Add(new Mister(edad, name));
            }

            foreach (var person in persons)
            {
               if(person.Ismayor()) Console.WriteLine($"name: {person.Name} \nedad: {person.Edad}"); 
            }
        }
    }
}