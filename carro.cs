using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   
             O custo de um carro novo ao consumidor é a soma do
             custo de fábrica coma porcentagem do distribuidor e
             dos impostos (aplicados ao custo de fábrica). Supondo
             que o percentual do distribuidor seja de 28% e os impostos
             de 45%, escrever um algoritmo para ler o custo de fábrica
             de um carro, calcular e escrever o custo final ao consumidor.
             */
             
            double distribuidor = 1.28;
            double impostos = 1.45;

            Console.Write("Informe o preço de fábrica do carro: ");
            double carro = Convert.ToDouble(Console.ReadLine());

            carro = (carro * impostos) * distribuidor;

            Console.WriteLine("O valor final do carro é: {0}", carro);

            Console.ReadKey();
        }
    }
}
