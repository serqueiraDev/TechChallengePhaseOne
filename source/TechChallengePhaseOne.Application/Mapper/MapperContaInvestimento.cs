using TechChallengePhaseOne.Application.Dto;
using TechChallengePhaseOne.Application.Mapper.Interface;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Application.Mapper
{
    public class MapperContaInvestimento : IMapperContaInvestimento
    {
        public ContaInvestimento MapperDtoToEntity(ContaInvestimentoDTO ContaInvestimentoDTO)
        {
            var ContaInvestimento = new ContaInvestimento()
            {
                Nome = ContaInvestimentoDTO.Nome
            };

            return ContaInvestimento;
        }

        public ContaInvestimentoDTO MapperEntityToDto(ContaInvestimento ContaInvestimento)
        {
            var ContaInvestimentoDto = new ContaInvestimentoDTO()
            {
                Nome = ContaInvestimento.Nome
            };

            return ContaInvestimentoDto;
        }

        public IEnumerable<ContaInvestimentoDTO> MapperListContaInvestimentoDto(IEnumerable<ContaInvestimento> ContaInvestimento)
        {
            var dto = ContaInvestimento.Select(a => new ContaInvestimentoDTO()
            {
                Nome = a.Nome
            });

            return dto;
        }
    }
}