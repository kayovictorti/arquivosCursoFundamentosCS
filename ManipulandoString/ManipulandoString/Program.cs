using System;

namespace ManipulandoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = " Este texto é um teste" ;
            //trocar os caracteres por outros
            Console.WriteLine(texto.Replace("Este", "isto"));
            Console.WriteLine(texto.Replace("e", "X"));

            Console.WriteLine("");

            //converte o texto em uma lista de strings a partir do caracter escolhido
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            Console.WriteLine("");

            //retorna os caracter das posições desejadas
            //var resultado = texto.Substring(5, 5);
            var resultado = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);

            Console.WriteLine("");

            //remover espaçõs do início e do fim
            Console.WriteLine(texto.Trim());

        }
    }
}
