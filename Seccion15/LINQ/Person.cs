using System.Collections.Generic;

namespace LINQ
{
    public class Person
    {
       public string name { get; set; }
       public int age { get; set; }
       public string rh { get; set; }
       public double height { get; set; }

       public Person(string name, int age, string rh, double height)
       {
           this.name = name;
           this.age = age;
           this.rh = rh;
           this.height = height;
       }

       public  static List<Person> getPersons()
       {
           List<Person> persons = new List<Person>();
           persons.Add(new Person("cristian", 19, "B+", 1.63));
           persons.Add(new Person("camilo", 15, "O+", 1.51));
           persons.Add(new Person("garzon", 28, "A-", 1.83));
           persons.Add(new Person("rodriguez", 52, "O+", 1.42));
           return persons;
       }
    }
}