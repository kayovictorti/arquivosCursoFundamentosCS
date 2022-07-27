

using System.Globalization;

namespace SalarioFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentoSalario(double percente)
        {
            return SalarioBruto +=  SalarioBruto * (percente / 100);
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + ", "
                + "$ " 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

   
}
