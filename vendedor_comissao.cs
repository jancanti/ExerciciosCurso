using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Ler o salário fixo e o valor das vendas efetuadas pelo
            vendedor de uma empresa. Sabendo-se que ele
            recebe uma comissão de 3% sobre o total das
            vendas até R$1.500,00 mais 5% sobre o que
            ultrapassar este valor, calcular e escrever o seu
            salário total.
            */

            Console.Write("Informe o valor do salário fixo: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor de vendas: ");
            double vendas = Convert.ToDouble(Console.ReadLine());

            if (vendas<=1500)
            {
                salario += vendas * 0.3;
                Console.WriteLine("Seu salário é de: {0}", salario);
            }
            else
            {
                salario = (salario + 1500 * 0.3) + (vendas - 1500) * 0.5;
                Console.WriteLine("Seu salário é de: {0}", salario);
            }

            Console.ReadKey();
        }
    }
}
