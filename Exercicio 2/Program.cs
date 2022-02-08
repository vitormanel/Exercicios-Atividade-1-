//• A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. 
//    Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas 
//    (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). 
//    Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as 
//    quantidades de pães e de broas, e depois calcular os dados solicitados.

using System;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaraçao das variaveis e digitaçao das quatidades
            double paes, broas;
            double soma = 0;

            Console.WriteLine("Digite a quantidade de Paes e Broas que foram vendidos: \n");
            Console.Write("Paes: ");
            paes = Convert.ToSingle(Console.ReadLine());
            Console.Write("Broas: ");
            broas = Convert.ToSingle(Console.ReadLine());

            //Calculo de vendas
            soma = paes * 0.12 + broas * 1.5;
            Console.WriteLine("Total das vendas: "+soma+ "R$");
            
            //Calculo de 10% do valor a ser depositado
            Console.WriteLine("Total a ser depositado na poupança: "+ 0.10 * soma+ "R$");
            Console.ReadLine();
        }
    }
}
