using System.ComponentModel;

namespace Ejercicio1
{
    public class Person
    {
        private int edad;
        private string name;

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Person(int edad, string name)
        {
            this.edad = edad;
            this.name = name;
        }
        public bool Ismayor() => edad >= 18;
    }
}