using TechChallengePhaseOne.Application.Dto;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Application.Mapper.Interface
{
    public interface IMapperAcao
    {
        Acao MapperDtoToEntity(AcaoDTO acaoDTO);

        IEnumerable<AcaoDTO> MapperListAcaoDto(IEnumerable<Acao> acao);

        AcaoDTO MapperEntityToDto(Acao acao);
    }
}
