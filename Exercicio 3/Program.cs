//• Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
//    Considere sempre anos completos, e que um ano possui 365 dias. 
//    Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

using System;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int dias;
            int idade;
            
            Console.WriteLine("Digite seu nome e sua idade: \n");
            Console.Write("Nome: ");
            nome = Convert.ToString(Console.ReadLine());
            Console.Write("idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            dias = idade * 365;
            Console.WriteLine(nome+ " Voce ja viveu " + dias + " Dias!");
            Console.ReadLine();
            
        }
    }
}
