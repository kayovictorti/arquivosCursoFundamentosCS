using System;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Também se aplica para outros tipos de objetos
            var texto = "Este texto é um teste";
            //posição da variável
            Console.WriteLine(texto.IndexOf("é"));
            //ultima posição da encontrada da variável
            Console.WriteLine(texto.LastIndexOf("s"));
        }
    }
}
