using System;

//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            Console.WriteLine("Digite o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor: ");
            D = int.Parse(Console.ReadLine());

            int DIFERANCA = (A * B - C * D);

            Console.WriteLine("DIFERENÇA: " + DIFERANCA);


        }
    }
}
