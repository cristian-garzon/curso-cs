using System;

namespace Ejercicio1
{
    public class student : Person
    {
        private int numStudent;

        public int NumStudent
        {
            get => numStudent;
            set => numStudent = value;
        }

        public student(int edad, string name) : base(edad, name)
        {
            Console.Write("num student: ");
            numStudent = Int32.Parse(Console.ReadLine());
        }
    }
}