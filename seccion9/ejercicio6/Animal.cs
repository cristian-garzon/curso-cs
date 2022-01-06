using System.Runtime.CompilerServices;

namespace ejercicio6
{
    public class Animal
    {
        private string tipo;
        private string colorPelo;
        private int patas;
        private bool domestico;

        public Animal(string tipo, string colorPelo, int patas, bool domestico)
        {
            this.tipo = tipo;
            this.colorPelo = colorPelo;
            this.patas = patas;
            this.domestico = domestico;
        }

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public string ColorPelo
        {
            get => colorPelo;
            set => colorPelo = value;
        }

        public int Patas
        {
            get => patas;
            set => patas = value;
        }

        public bool Domestico
        {
            get => domestico;
            set => domestico = value;
        }

        public string isDomestico()
        {
            return domestico ? "si" : "no";
        }
    }
}