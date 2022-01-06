using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Char keep = 'N';
            List<Person> persons = new List<Person>();
            do
            {
                Person person = new Person();
                Console.WriteLine($"name: ");
                person.name = Console.ReadLine();

                Console.WriteLine($"edad: ");
                person.age = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine($"country: ");
                person.country = Console.ReadLine();
                
                persons.Add(person);
                
                Console.WriteLine($"wrrite new person?: ");
                keep = char.Parse(Console.ReadLine().ToLower());
            } while (!keep.Equals('n'));

            StringBuilder personString = new StringBuilder();
            foreach (var person in persons)
            {
                personString.Append($"{person.name} | {person.age} | {person.country}");
            }

            FileStream fs = new FileStream("persons.txt", FileMode.OpenOrCreate);
            
            fs.Write(ASCIIEncoding.ASCII.GetBytes(personString.ToString()), 0, personString.ToString().Length );

            Byte[] read = new byte[100];

            fs.Read(read, 0, (int) fs.Length);
            
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(read));
            
            fs.Close();
            
        }
    }
}