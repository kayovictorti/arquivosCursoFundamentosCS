using System;
using System.Globalization;

namespace ExercicoCotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a contação do dolar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cotacao = ConversorDeMoeda.Conversao(cot, qtd);

            Console.WriteLine();

            Console.WriteLine("Valor a ser pago em reais: " + cotacao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
