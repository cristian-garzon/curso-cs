using System;

namespace Ejercicio1
{
    public class Mister : Person
    {
        private string materia;

        public string Materia
        {
            get => materia;
            set => materia = value;
        }

        public Mister(int edad, string name) : base(edad, name)
        {
            Console.Write("subject: ");
            materia = Console.ReadLine();
        }
    }
}