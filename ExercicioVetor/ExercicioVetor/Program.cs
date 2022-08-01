using System;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            AluguelQuarto[] quarto = new AluguelQuarto[10];

            Console.Write("Quantos estudantes irão alugar quarto?: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            

            for( int i = 0; i < n; i++)
            {
                Console.Write("Número do " + (i+1)+ "º quarto: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                quarto[index] = new AluguelQuarto(nome, email);
            }


            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if(quarto[i] != null)
                {
                    Console.WriteLine(i + ": " + quarto[i]);
                }
            }
        }
    }
}
