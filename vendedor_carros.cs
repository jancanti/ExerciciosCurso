using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Uma revendedora de carros usados paga a seus
                funcionários vendedores um salário fixo por mês, mais
                uma comissão também fixa para cada carro vendido e
                mais 5% do valor das vendas por ele efetuadas. Escrever
                um algoritmo que leia o número de carros por ele
                vendidos, o valor total de suas vendas, o salário fixo e o
                valor que ele recebe por carro vendido. Calcule e
                escreva o salário final do vendedor.
             */
            double numCarrosVendidos = 0;
            double valorTotalVendas = 0;
            double salarioFixo = 0;
            double comissaoPorCarro = 0;
            double salarioFinal = 0;

            Console.Write("Digite o no. de carros vendidos: ");
            numCarrosVendidos = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor total de vendas: ");
            valorTotalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o seu salário fixo: ");
            salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a comissão por carro: ");
            comissaoPorCarro = Convert.ToDouble(Console.ReadLine());

            salarioFinal = salarioFixo + (valorTotalVendas * 0.05) + (comissaoPorCarro * numCarrosVendidos);

            Console.WriteLine("O salário final é de R$ {0}", salarioFinal);

            Console.ReadKey();
        }
    }
}
