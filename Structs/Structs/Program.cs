using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
            var manunencaoEletrica = new Product(2, "Manutencao elétrica residencial", 500, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
            Console.WriteLine("Valor em dolar é: " + mouse.PriceInDolar(5.00).ToString("F2"));

            Console.WriteLine("");

            Console.WriteLine(manunencaoEletrica.Id);
            Console.WriteLine(manunencaoEletrica.Name);
            Console.WriteLine(manunencaoEletrica.Price);
            Console.WriteLine(manunencaoEletrica.Type);
            Console.WriteLine((int)manunencaoEletrica.Type);
            Console.WriteLine("Valor em dolar é: " + manunencaoEletrica.PriceInDolar(5.00).ToString("F2"));

        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
   
}
