using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ler 3 valores (considere que não serão informados
            valores iguais)e escrever o maior deles.
            */

            int maior = 0;

            Console.WriteLine("Digite 3 valores:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b) {
                maior = a;
            } else if ( b > c) {
                maior = b;
            }
            else {
                maior = c;
            }

            Console.WriteLine("O maior número é: {0}", maior);

            Console.ReadKey();
        }
    }
}
