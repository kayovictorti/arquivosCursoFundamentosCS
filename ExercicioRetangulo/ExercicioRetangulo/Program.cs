using System;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Qual a largura do retângulo?: ");
            r.L1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a altura do retângulo?: ");
            r.L2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine(r);
        }
    }
}
