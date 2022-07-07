using System;

namespace MetodosAdicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            //converter o texto inteiro para minúsculo
            Console.WriteLine(texto.ToLower());
            //converter o texto inteiro para maiusculo
            Console.WriteLine(texto.ToUpper());
            //inserir cacateres no texto
            Console.WriteLine(texto.Insert(5, "AQUI "));
            //remover cacateres no texto
            Console.WriteLine(texto.Remove(5, 5));
            //retorna a quantidade de caracteres
            Console.WriteLine(texto.Length);
        }
    }
}
