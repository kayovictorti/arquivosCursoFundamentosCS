using System;

namespace ComparacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            //var texto = "Testando";
            //retorna um inteiro
            //Console.WriteLine(texto.CompareTo("Testando"));
            //Console.WriteLine(texto.CompareTo("testando"));


            //verifica se tem o texto em outro texto e retorna um boolean 
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            //Comparando texto isgnorando letras minusculas e maiusculas
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));

        }
    }
}
