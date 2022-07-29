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

            int index;
            string nome;
            string email;

            for( int i = 0; i < n; i++)
            {
                Console.Write("Número do " + (i+1)+ "º quarto: ");
                index = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                quarto[index] = new AluguelQuarto(nome, email);
            }

            for(int i = 0; i < 10; i++)
            {
                if(quarto[i] != null)
                {
                    Console.WriteLine();
                    Console.Write(i + ": ");
                    Console.Write(quarto[i].Nome + ", ");
                    Console.Write(quarto[i].Email);
                }
            }
        }
    }
}
