using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o número de funcionários que deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> lista = new List<Funcionario>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os dados do Funcionário " + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

            }

            Console.Write("Digite o ID do funcionário: ");
            int buscaId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Funcionario fun = lista.Find(x => x.Id == buscaId);
            if ( fun != null)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.AumentarSalario(percent);
            }
            else
            {
                Console.WriteLine("O ID digitado não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada: ");
            foreach(Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
