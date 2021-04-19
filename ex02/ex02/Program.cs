using System;
using System.Globalization;

//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.
//Fórmula da área: area = π.raio2
//Considere o valor de π = 3.14159


namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14159;

            Console.WriteLine("Digite um valor: ");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("Valor do Raio= " + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
