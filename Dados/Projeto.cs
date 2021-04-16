using System;

namespace ModernArt
{
    class Projeto
    {
        public Projeto(int id, Designer designer, Servico servico, Cliente cliente, string nome, DateTime data, double valorFinal, string status)
        {
            Id = id;
            Designer = designer;
            Servico = servico;
            Cliente = cliente;
            Nome = nome;
            Data = data;
            ValorFinal = valorFinal;
            Status = status;
        }

        public int Id { get; set; }
        public Designer Designer { get; set; }
        public Servico Servico { get; set; }
        public Cliente Cliente { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public double ValorFinal { get; set; }
        public string Status { get; set; }
    }
}
