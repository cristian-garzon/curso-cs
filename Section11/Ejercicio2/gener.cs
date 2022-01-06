using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    public class gener<t>
    {
        private List<t> listGener = new List<t>();
        public void add(t generic)
        {
           listGener.Add(generic); 
        }

        public void print()
        {
            foreach (var list in listGener)
            {
               Console.WriteLine($"{list}"); 
            }
        }
    }
}