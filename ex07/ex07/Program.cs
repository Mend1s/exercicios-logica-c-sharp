﻿using System;

//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
