namespace TechChallengePhaseOne.Domain.Entity
{
    public class ContaInvestimento : Base
    {
        public string Nome { get; set; }
        public decimal Saldo { get; private set; }
        public List<Acao> CarteiraAcoes { get; private set; }

        public ContaInvestimento()
        {
        }

        //public void ComprarAcao(Acao acao, int quantidade)
        //{
        //    decimal custoTotal = acao.Preco * quantidade;
        //    if (Saldo >= custoTotal)
        //    {
        //        Saldo -= custoTotal;
        //        for (int i = 0; i < quantidade; i++)
        //        {
        //            CarteiraAcoes.Add(acao);
        //        }
        //        Console.WriteLine($"{quantidade} ação(ões) de {acao.Nome} comprada(s) com sucesso.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Saldo insuficiente para comprar ações.");
        //    }
        //}

        //public void VenderAcao(Acao acao, int quantidade)
        //{
        //    int quantidadeNaCarteira = CarteiraAcoes.Count(ac => ac.Id == acao.Id);
        //    if (quantidadeNaCarteira >= quantidade)
        //    {
        //        decimal lucroTotal = acao.Preco * quantidade;
        //        Saldo += lucroTotal;
        //        CarteiraAcoes.RemoveAll(ac => ac.Id == acao.Id);
        //        Console.WriteLine($"{quantidade} ação(ões) de {acao.Nome} vendida(s) com sucesso.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Quantidade insuficiente de ações para vender.");
        //    }
        //}

        //public void VerificarSaldo()
        //{
        //    Console.WriteLine($"Saldo atual: {Saldo:C}");
        //}
    }
}