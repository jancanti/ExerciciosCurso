using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um algoritmo que leia a idade de uma pessoa
            expressa em anos, meses e dias e escreva a idade dessa
            pessoa expressa apenas em dias. Considerar ano com
            365 dias e mês com 30 dias.
            */
            
            Console.Write("Digite sua idade em anos: ");
            int anos = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Digite quantos meses você tem esse ano: ");
            int meses = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Digite quantos dias você tem esse ano: ");
            int dias = Convert.ToUInt16(Console.ReadLine());

            int idade = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("Você já viveu {0} anos!", idade);
            Console.ReadKey();
        }
    }
}
