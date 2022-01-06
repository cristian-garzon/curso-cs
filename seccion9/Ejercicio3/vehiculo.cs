namespace Ejercicio2
{
    public class vehiculo
    {
        private int ruedas;
        private int capacidad;
        private int puertas;


        public vehiculo(int ruedas, int capacidad, int puertas)
        {
            this.ruedas = ruedas;
            this.capacidad = capacidad;
            this.puertas = puertas;
        }

        public vehiculo(int ruedas, int capacidad)
        {
            this.ruedas = ruedas;
            this.capacidad = capacidad;
            this.puertas = 2;
        }

        public vehiculo(int ruedas)
        {
            this.ruedas = ruedas;
            this.capacidad = 4;
            this.puertas = 2;
        }

        public vehiculo()
        {
            this.ruedas = 4;
            this.capacidad = 5;
            this.puertas = 2;
        }

        public int Ruedas
        {
            get => ruedas;
            set => ruedas = value;
        }

        public int Capacidad
        {
            get => capacidad;
            set => capacidad = value;
        }

        public int Puertas
        {
            get => puertas;
            set => puertas = value;
        }
    }
}