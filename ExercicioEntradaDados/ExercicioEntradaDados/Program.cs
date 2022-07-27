using System;
using System.Globalization;

namespace ExercicioEntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu útimo nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string nome1 = dados[0];
            int idade1 = int.Parse(dados[1]);
            double altura1 = double.Parse(dados[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome1);
            Console.WriteLine(idade1);
            Console.WriteLine(altura1.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
