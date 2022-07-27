

namespace ExercicoCotacaoDolar
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double Conversao( double cotacao, double quantidade)
        {
            double valor = cotacao * quantidade;
            return valor += valor * Iof;
        }
    }
}
