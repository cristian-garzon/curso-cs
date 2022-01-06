using System;

namespace Ejercicio3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("write a sentence: ");
            string sentence = Console.ReadLine().Trim();
            string[] words = sentence.Split(' ');
            if (sentence.Length >= 20 && words.Length >= 4)
            {
                print(sentence); 
            }
        }

        public static void print(string sentence)
        {
           Console.WriteLine($"longitud: {lenghString(sentence)} \n" +
                             $"pintar cadena: {replaceString(sentence)} \n" +
                             $"mayusculas: {upperString(sentence)} \n" +
                             $"minusculas: {lowerString(sentence)} \n" +
                             $"removiendo 3 letras: {removeWords(sentence)} \n" +
                             $"cadena de 5 a 10: {substr(sentence)} \n" +
                             $"cadena invertida: {reverse(sentence)} \n" +
                             $"numero de palabras: {numWords(sentence)} \n" +
                             $"tercera palabra: {thirdstr(sentence)} \n"); 
        }
        public static int lenghString(string sentence)
        {
            return sentence.Length;
        }

        public static string replaceString(string sentece)
        {
            sentece = sentece.Replace('A', 'X');
            sentece = sentece.Replace('a', 'x');
            return sentece;
        }

        public static string upperString(string sentece)
        {
            return sentece.ToUpper();
        }

        public static string lowerString(string sentece)
        {
            return sentece.ToLower();
        }

        public static string removeWords(string sentence)
        {
            return sentence.Substring(1, sentence.Length - 1);
        }

        public static string substr(string sentence)
        {
            return sentence.Substring(5,10);
        }
        
        public static string reverse(string sentence)
        {
            char[] reverseWord = sentence.ToCharArray();
            Array.Reverse(reverseWord);
            return new string(reverseWord);
        }

        public static int numWords(string sentence)
        {
            string[] frase = sentence.Split(' ');
            return frase.Length;
        }
        
        
        public static string thirdstr(string sentence)
        {
            string[] frase = sentence.Split(' ');
            return frase[2];
        }
        
        
    }
}