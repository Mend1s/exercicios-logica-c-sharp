using System;

//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//mensagem explicativa, conforme exemplos.

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, soma;

            Console.WriteLine("Digite o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
            Console.ReadLine();
        }
    }
}
