using System;
using System.Globalization;

namespace ExercicioNotaAluno
{
    class Aluno
    {
        public double N1, N2, N3, NF;

        public double NotaFinal()
        {
            return NF = N1 + N2 + N3;
        }

        public void Resultado()
        {

            Console.WriteLine();

            double faltam = 60 - NF;

            if(NF < 60)
            {
                Console.WriteLine("NOTA FINAL: " + NF.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM " + faltam.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
            else
            {
                Console.WriteLine("NOTA FINAL: " + NF.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO!");
            }
        }
    }
}
