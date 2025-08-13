// See https://aka.ms/new-console-template for more information
using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Calculadora Colaborativa Web");

        Console.Write("Digite o primeiro valor: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Selecione uma das funções a seguir:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        double resultado;
        switch(opcao)
        {
            case 1:
            Adicao(a, b);
            break;
        }

        // Adição
        public static double Adicao(double a, double b)
        {
            return a + b;
        }

        // Integrante 2
        // public static double Subtracao(double a, double b)
        // {
        //     // Implementar aqui
        // }

        // Integrante 3
        // public static double Multiplicacao(double a, double b)
        // {
        //     
        // }

        // Integrante 4
        public static double Divisao(double a, double b)
        {
            Console.WriteLine(a / b)
        }

        public static double Potencia(double a, double b)
        {
            return Math.Pow(a,b);
        }
    }
}



