using System;
using System.Globalization;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Insira õs dados do funcionário: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.SalarioLiquido();

            Console.WriteLine("Dados do funcionário: " + f);

            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem para uamentar o salário: ");
            double percente = double.Parse(Console.ReadLine());
            f.AumentoSalario(percente);

            Console.WriteLine();


            Console.WriteLine("Dados atualizados do funcionário: " + f);

        }
    }
}
