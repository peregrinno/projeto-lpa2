using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernArt
{
    class Servico
    {
        public Servico(int id, string nome, double valorBase)
        {
            Id = id;
            Nome = nome;
            ValorBase = valorBase;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorBase { get; set; }
    }
}
