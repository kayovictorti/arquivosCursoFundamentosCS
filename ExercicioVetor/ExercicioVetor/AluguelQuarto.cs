using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    class AluguelQuarto
    {
        public string Nome{ get; set; }
        public string Email { get; set; }

        public AluguelQuarto( string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
