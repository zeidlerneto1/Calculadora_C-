using System;
using System.Globalization;
using dotnet.Models;  

namespace dotnet
{
    

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        int opcao;
        float resultado;
        OperacoesCalculadora calculadora = new OperacoesCalculadora();
        

        Console.WriteLine("Digite o primeiro número: ");
        string Snum1 = Console.ReadLine();

        float num1 = float.Parse(Snum1);

        Console.WriteLine("Digite o segundo número: ");
        string Snum2 = Console.ReadLine();

        float num2 = float.Parse(Snum2);

        Console.WriteLine($"Primeiro número: {num1}, Segundo número: {num2}");
        do
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");
            opcao = int.Parse(Console.ReadLine());
        }
        while (opcao  < 1 || opcao  > 5);
        switch (opcao)
        {
            case 1:
            resultado = calculadora.Somar(num1,num2);
            Console.WriteLine(resultado);
            break;
            case 2:
            resultado = calculadora.Subtrair(num1,num2);
            Console.WriteLine(resultado);
            break;
            case 3:
            resultado = calculadora.Multiplicacao(num1,num2);
            Console.WriteLine(resultado);
            break;
            case 4:
            resultado = calculadora.Dividir(num1,num2);
            Console.WriteLine(resultado);
            break;
            case 5:
            break;
            default:
            break;
        }


    }
}
}