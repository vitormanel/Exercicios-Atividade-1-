//Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit.
//Faça um algoritmo para ler uma temperatura Celsius e imprimi-Ia em Fahrenheit
//(pesquise como fazer este tipo de conversão).

using System;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float c;
            Console.WriteLine("Digite quantos C°: ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A temperatura inserida em F°: " + (9 * c + 160)/5);
            Console.ReadLine();
        }
    }
}
