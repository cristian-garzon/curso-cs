using System.Collections.Generic;

namespace LINQ
{
    public class vehicle
    {
        public string nameProperty { get; set; }
        public int ruedas { get; set; }
        public int puertas { get; set; }

        public vehicle(string nameProperty, int ruedas, int puertas)
        {
            this.nameProperty = nameProperty;
            this.ruedas = ruedas;
            this.puertas = puertas;
        }

        public static List<vehicle> getVehicles()
        {
            List<vehicle> vehicles = new List<vehicle>();
            vehicles.Add(new vehicle("cristian", 4,2));
            vehicles.Add(new vehicle("camilo", 8,4));
            vehicles.Add(new vehicle("garzon", 2,0));
            vehicles.Add(new vehicle("rodriguez", 4,2));
            return vehicles;
        }
    }
}