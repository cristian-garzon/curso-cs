using System;
using System.Globalization;
using System.Linq;

namespace Ejercicio4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("choose key");
            Char tecla = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (isVocal(tecla))
            {
                Console.WriteLine("es vocal");
            }

            if (isNumber(tecla))
            {
                Console.WriteLine("es numerico");
            }

            if (isConsonante(tecla))
            {
                Console.WriteLine("es consonante");
            }
        }

        public static bool isVocal(Char tecla)
        {
            Char[] vocales = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            if (vocales.Contains(tecla))
            {
                return true;
            }

            return false;
        }

        public static bool isNumber(Char tecla)
        {
            if ((int) tecla <= 57 && (int) tecla >= 48)
            {
                return true;
            }

            return false;
        }

        public static bool isConsonante(Char tecla)
        {
            int[] vocales = {65, 69, 79, 73, 85, 97, 105,101,111,117};
            if (((int) tecla <= 122 && (int) tecla >= 97) || ((int) tecla <= 65 && (int) tecla >= 90))
            {
                if (!vocales.Contains((int) tecla)) return true;
            }

            return false;
        }
    }
}