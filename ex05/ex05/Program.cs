using System;
using System.Globalization;

//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, codigo2, numero1, numero2;
            double preco1, preco2, total;

            Console.WriteLine("ITEM 1 - CÓDIGO PEÇA: ");
            codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ITEM 1 - NÚMERO PEÇA: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ITEM 1 - VALOR UNITÁRIO: ");
            preco1 = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("VALOR EM PROCESSAMENTO, SIGA EM FRENTE!");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("ITEM 2 - CÓDIGO PEÇA: ");
            codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ITEM 2 - NÚMERO PEÇA: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ITEM 2 - VALOR UNITÁRIO: ");
            preco2 = double.Parse(Console.ReadLine());


            total = preco1 * numero1 + preco2 * numero2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
