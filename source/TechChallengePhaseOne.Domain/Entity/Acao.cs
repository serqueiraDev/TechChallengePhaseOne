namespace TechChallengePhaseOne.Domain.Entity
{
    public class Acao : Base
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Acao(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}