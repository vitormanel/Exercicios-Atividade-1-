//• A imobiliária Imóbilis vende apenas terrenos retangulares. 
//Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

using System;

namespace Exercicios_Atividade_2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao das variaveis, entrada com os valores;
            float comprimento, largura;
            float area = 0;
            Console.WriteLine("Entre com o comprimento (em metros) e a largura (em metros): \n");
            Console.Write("Comprimento: ");
            comprimento = Convert.ToSingle(Console.ReadLine());
            Console.Write("largura: ");
            largura = Convert.ToSingle(Console.ReadLine());
            //Soma dos valores comprimento x altura e impressao na tela
            area = comprimento*largura;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Seu terreno possui: "+ area + " metros quadrados de area");
            Console.ReadLine();
        }
    }
}
