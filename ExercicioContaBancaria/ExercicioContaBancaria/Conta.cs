using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Conta
    {
        public string NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(string numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
        }

        public Conta(string numConta, string titular, double depositoInicial) : this(numConta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5);
        }

        public override string ToString()
        {
            return "Número da conta: "
                + NumConta
                + ", "
                + "Titular: "
                + Titular
                + ", "
                + "Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
