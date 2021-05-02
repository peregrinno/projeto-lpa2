namespace ModernArt
{
    class Designer
    {
        public Designer(int id, string nome, string telefone, string email, bool disponivel)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Disponivel = disponivel;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Disponivel { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
