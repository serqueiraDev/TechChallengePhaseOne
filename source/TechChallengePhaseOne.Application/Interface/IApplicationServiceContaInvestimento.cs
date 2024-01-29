using TechChallengePhaseOne.Application.Dto;

namespace TechChallengePhaseOne.Application.Interface
{
    public interface IApplicationServiceContaInvestimento
    {
        void Add(ContaInvestimentoDTO contaInvestimentoDTO);

        void Remove(ContaInvestimentoDTO contaInvestimentoDTO);

        void Update(ContaInvestimentoDTO contaInvestimentoDTO);

        IEnumerable<ContaInvestimentoDTO> GetAll();

        ContaInvestimentoDTO GetById(int id);
    }
}