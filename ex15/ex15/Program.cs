using System;

//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
//incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
//impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A SENHA PARA ACESSAR: ");
            int x = int.Parse(Console.ReadLine());
            
            int senha = 2002;
            while (x != senha)
            {
                Console.WriteLine("SENHA INCORRETA, DIGITE NOVAMENTE!");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("SENHA CORRETA, ACESSO LIBERADO!");
        }
    }
}
