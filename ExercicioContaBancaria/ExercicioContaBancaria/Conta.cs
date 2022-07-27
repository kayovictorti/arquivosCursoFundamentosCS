using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta()
        {

        }

        public Conta(int numConta, string nome, double saldo)
        {
            NumConta = numConta;
            Nome = nome;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
        }

        public override string ToString()
        {
            return "Número da conta: "
                + NumConta
                + ", "
                + "Nome: "
                + ", "
                + "Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
