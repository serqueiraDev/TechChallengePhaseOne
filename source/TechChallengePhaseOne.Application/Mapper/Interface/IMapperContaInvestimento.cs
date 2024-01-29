using TechChallengePhaseOne.Application.Dto;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Application.Mapper.Interface
{
    public interface IMapperContaInvestimento
    {
        ContaInvestimento MapperDtoToEntity(ContaInvestimentoDTO contaInvestimentoDTO);

        IEnumerable<ContaInvestimentoDTO> MapperListContaInvestimentoDto(IEnumerable<ContaInvestimento> contaInvestimento);

        ContaInvestimentoDTO MapperEntityToDto(ContaInvestimento contaInvestimento);
    }
}
