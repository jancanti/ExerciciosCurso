using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Tendo como dados de entrada o nome, a altura e o sexo (M ou F)
                de uma pessoa, calcule e mostre seu peso ideal, utilizando as
                seguintes fórmulas:
                - para sexo masculino: peso ideal = (72.7 * altura) - 58
                - para sexo feminino: peso ideal = (62.1 * altura) - 44.7
            */
            double altura = 0, pesoIdeal = 0;
            char sexo = 'f';
            
            Console.WriteLine("##### IMG #####\n\n");

            Console.Write("Digite sua altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu sexo [M|F]: ");
            sexo = Convert.ToChar(Console.ReadLine().ToLower());

            switch(sexo)
            {
                case 'm':
                    pesoIdeal = (72.9 * altura) - 58;
                    Console.WriteLine("Seu peso ideal é: {0}", pesoIdeal);
                    break;
                case 'f':
                    pesoIdeal = (62.1 * altura) - 44.7;
                    Console.WriteLine("Seu peso ideal é {0}", pesoIdeal);
                    break;
                default:
                    Console.WriteLine("Sexo não informado!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
