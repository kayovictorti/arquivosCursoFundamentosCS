using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double  AumentarSalario (double percent)
        {
            return Salario += Salario * (percent / 100);
        }

        public double DiminuirSalario(double percent)
        {
            return Salario -= Salario * (percent/100);
        }

        public override string ToString()
        {
            return Id + ": " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    
}
