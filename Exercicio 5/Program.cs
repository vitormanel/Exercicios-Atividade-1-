//• Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos.
//Imprima o salário inicial, o salário com o aumento e o salário final.

using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaraçao das variavei, entrada com salario inicial, aplicaçao dos aumentos e decontos por impostos.
            double aumento, imposto, salario, salarioAumento, salarioFinal;
            aumento = 0.15;
            imposto = 0.08;
                Console.WriteLine("Digite o salario do funcionario: ");
              salario = Convert.ToSingle(Console.ReadLine());
            salarioAumento = (salario + (salario * aumento));
            salarioFinal = (salarioAumento - (salarioAumento * imposto));
            Console.WriteLine("O salario inicia era de: "+salario);
            Console.WriteLine("Com aumento de 15% ficou: " + salarioAumento);
            Console.WriteLine("Com desconto de 8% de impostos ficou: "+salarioFinal);
            Console.WriteLine("\n");
            //impressao do salario final.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Salario Final ficou de: "+salarioFinal);
            Console.ReadLine();
        }
    }
}
