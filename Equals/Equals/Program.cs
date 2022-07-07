using System;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equals também serve para comparação de outros tipos de objetos
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}
