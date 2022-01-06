using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Person> persons = Person.getPersons();
            List<vehicle> vehicles = vehicle.getVehicles();

            var names =
                    from p in persons
                    join v in vehicles on p.name equals v.nameProperty
                    orderby p.height descending
                    select new
                    {
                        age = p.age,
                        height = p.height,
                        ruedas = v.ruedas
                    };
            

            foreach (var name in names.Reverse())
            {
                Console.WriteLine($"age: {name.age} \n" +
                                  $"ruedas: {name.ruedas} \n");
            }
        }
    }
}