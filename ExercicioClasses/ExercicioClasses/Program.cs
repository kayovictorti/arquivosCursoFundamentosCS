using System;

namespace ExercicioClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Insira seus dados:");
            Console.WriteLine("Nome:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seus dados:");
            Console.WriteLine("Nome:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
    
}
