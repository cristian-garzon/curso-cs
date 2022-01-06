namespace Ejercicio2
{
    public class avion : vehiculo
    {
        private string lastCountry;

        public string LastCountry
        {
            get => lastCountry;
            set => lastCountry = value;
        }
    }
}