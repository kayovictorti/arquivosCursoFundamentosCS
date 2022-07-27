using System;
using System.Globalization;

namespace ExercicioNotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A1 = new Aluno();

            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("Primeira nota: ");
            A1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segunda nota: ");
            A1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Terceira nota: ");
            A1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A1.NotaFinal();
            A1.Resultado();


        }
    }
}
