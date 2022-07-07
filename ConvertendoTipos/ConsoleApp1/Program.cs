using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.8f;

            //real = inteiro;
            //inteiro = (int)real;
            //inteiro = int.Parse(real.ToString());
            inteiro = Convert.ToInt32(real);
            string teste = "156";
            int passarInteiro = int.Parse(teste);

            Console.WriteLine(inteiro);
            Console.WriteLine(passarInteiro);

        }
    }
}
