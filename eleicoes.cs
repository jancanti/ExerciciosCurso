using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escreva um algoritmo para ler o número total de eleitores
            de um município, o número de votos brancos, nulos e
            válidos. Calcular e escrever o percentual que cada um
            representa em relação ao total de eleitores.
            */

            Console.Write("Digite o total de eleitores do seu município: ");
            int total = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Digite o no. votos brancos do seu município: ");
            int brancos = Convert.ToUInt16(Console.ReadLine());
            int brancosp = brancos / total * 100;

            Console.Write("Digite o no. votos nulos do seu município: ");
            int nulos = Convert.ToUInt16(Console.ReadLine());
            int nulosp = nulos / total * 100;

            Console.Write("Digite o no. votos válidos do seu município: ");
            int validos = Convert.ToUInt16(Console.ReadLine());
            int validosp = validos / total * 100;

            Console.WriteLine("Total de Votos:  {0}", total);
            Console.WriteLine("Votos Brancos:   {0}     {1}% dos votos.", brancos, brancosp);
            Console.WriteLine("Votos Nulos:     {0}     {1}% dos votos.", nulos, nulosp);
            Console.WriteLine("Votos Nulos:     {0}     {1}% dos válidos.", validos, validosp);
            
            Console.ReadKey();
        }
    }
}
