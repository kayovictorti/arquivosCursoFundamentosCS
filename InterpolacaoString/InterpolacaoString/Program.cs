using System;

namespace InterpolacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            //concatenação
            //var texto = "O preço do produto é: "+ price + " apenas na promoção ";
            //formata uma cadia de caracteres
            //var texto = string.Format("O preço do produto é: {0} apenas na promoção e {1}", price, true);
            var texto = $"O preço do produto é {price} apenas na promoção";
            //OBS: ao utilizar o @ antes das aspas os caracteres especiais são ignorados
            Console.WriteLine(texto);
        }
    }
}
