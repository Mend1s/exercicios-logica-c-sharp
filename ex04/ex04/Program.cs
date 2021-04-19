using System;
using System.Globalization;

//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
//decimais.

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFunc, horasTrabalhadas; 
            double valorQueRecebePorHora, salario;


            Console.WriteLine("Número do funcionário: ");
            numberFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor que recebe por hora: ");
            valorQueRecebePorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorQueRecebePorHora;

            Console.WriteLine("NÚMERO FUNCIONÁRIO: " + numberFunc);
            Console.WriteLine("SALÁRIO FUNCIONÁRIO: U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
