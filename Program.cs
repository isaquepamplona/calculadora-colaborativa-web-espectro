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
            Console.WriteLine("5 - Potenciação");

            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Resultado: " + Adicao(a, b));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + Subtracao(a, b));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + Multiplicacao(a, b));
                    break;
                case 4:
                    if (b == 0)
                        Console.WriteLine("Erro: divisão por zero!");
                    else
                        Console.WriteLine("Resultado: " + Divisao(a, b));
                    break;
                case 5:
                    Console.WriteLine("Resultado: " + Potencia(a, b));
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        // Adição
        public static double Adicao(double a, double b)
        {
            return a + b;
        }

        // Subtração
        public static double Subtracao(double a, double b)
        {
            return a - b;
        }

        // Multiplicação
        public static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        // Divisão
        public static double Divisao(double a, double b)
        {
            return a / b;
        }

        // Potenciação
        public static double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
