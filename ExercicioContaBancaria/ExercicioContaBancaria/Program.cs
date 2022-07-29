using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            Console.WriteLine("Entre com os dados da conta ");
            Console.Write( "Número da conta: " );
            string numConta = Console.ReadLine();
            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();

            Console.WriteLine();


            Console.WriteLine("Deseja fazer um depóstio incial? (s/n)");
            char depositoInicial = char.Parse(Console.ReadLine().ToLower());

            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Qual o valor do depósito?: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numConta, titular, saldoInicial);
            }
            else
            {
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numConta, titular);
            }


            Console.WriteLine("Dados atualizados: " + c.ToString());

            Console.WriteLine();

            Console.Write("Qual o valor do depósito?: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + c.ToString());

            Console.WriteLine();

            Console.Write("Qual o valor de saque?: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valor);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + c.ToString());


        }
    }
    
}
