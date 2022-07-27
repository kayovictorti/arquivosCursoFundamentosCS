

using System;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Retangulo
    {
        public double L1, L2;

        public double Area()
        {
            return L1 * L2;
        }

        public double Perimetro()
        {
            return 2 * L1 + 2 * L2;
        }

        public double Diagonal()
        {

            return Math.Sqrt(L1*L1 + L2*L2);
        }

        public override string ToString()
        {
            return "AREA: " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + "PERÍMETRO: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + "DIAGONAL: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
