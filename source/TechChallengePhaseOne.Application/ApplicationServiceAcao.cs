using TechChallengePhaseOne.Application.Dto;
using TechChallengePhaseOne.Application.Interface;
using TechChallengePhaseOne.Application.Mapper.Interface;
using TechChallengePhaseOne.Domain.Core.Interface.Service;

namespace TechChallengePhaseOne.Application
{
    public class ApplicationServiceAcao : IApplicationServiceAcao
    {
        private readonly IServiceAcao _serviceAcao;
        private readonly IMapperAcao _mapperAcao;

        public ApplicationServiceAcao(IServiceAcao serviceAcao, IMapperAcao mapperAcao)
        {
            _serviceAcao = serviceAcao;
            _mapperAcao = mapperAcao;
        }

        public void Add(AcaoDTO acaoDTO)
        {
            var acao = _mapperAcao.MapperDtoToEntity(acaoDTO);
            _serviceAcao.Add(acao);
        }

        public void Update(AcaoDTO acaoDTO)
        {
            var acao = _mapperAcao.MapperDtoToEntity(acaoDTO);
            _serviceAcao.Update(acao);
        }

        public void Remove(AcaoDTO acaoDTO)
        {
            var acao = _mapperAcao.MapperDtoToEntity(acaoDTO);
            _serviceAcao.Delete(acao);
        }

        public IEnumerable<AcaoDTO> GetAll()
        {
            var acoes = _serviceAcao.GetAll();
            return _mapperAcao.MapperListAcaoDto(acoes);
        }

        public AcaoDTO GetById(int id)
        {
            var acao = _serviceAcao.GetById(id);
            return _mapperAcao.MapperEntityToDto(acao);
        }
    }
}