using System;
using System.Globalization;

namespace MoedasTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;
            //Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));

        }
    }
}
