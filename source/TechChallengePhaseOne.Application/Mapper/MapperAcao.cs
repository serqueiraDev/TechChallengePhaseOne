using TechChallengePhaseOne.Application.Dto;
using TechChallengePhaseOne.Application.Mapper.Interface;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.Application.Mapper
{
    public class MapperAcao : IMapperAcao
    {
        public Acao MapperDtoToEntity(AcaoDTO acaoDTO)
        {
            var acao = new Acao()
            {
                Id = acaoDTO.Id,
                Nome = acaoDTO.Nome,
                Preco = acaoDTO.Preco
            };

            return acao;
        }

        public AcaoDTO MapperEntityToDto(Acao acao)
        {
            var acaoDto = new AcaoDTO()
            {
                Id = acao.Id,
                Nome = acao.Nome,
                Preco = acao.Preco
            };

            return acaoDto;
        }

        public IEnumerable<AcaoDTO> MapperListAcaoDto(IEnumerable<Acao> acao)
        {
            var dto = acao.Select(a => new AcaoDTO()
            {
                Id = a.Id,
                Nome = a.Nome,
                Preco = a.Preco
            });

            return dto;
        }
    }
}