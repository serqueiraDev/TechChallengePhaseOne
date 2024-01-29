using TechChallengePhaseOne.Application.Dto;
using TechChallengePhaseOne.Application.Interface;
using TechChallengePhaseOne.Application.Mapper.Interface;
using TechChallengePhaseOne.Domain.Core.Interface.Service;

namespace TechChallengePhaseOne.Application
{
    public class ApplicationServiceContaInvestimento : IApplicationServiceContaInvestimento
    {
        private readonly IServiceContaInvestimento _serviceContaInvestimento;
        private readonly IMapperContaInvestimento _mapperContaInvestimento;

        public ApplicationServiceContaInvestimento(IServiceContaInvestimento serviceContaInvestimento, IMapperContaInvestimento mapperContaInvestimento)
        {
            _serviceContaInvestimento = serviceContaInvestimento;
            _mapperContaInvestimento = mapperContaInvestimento;
        }

        public void Add(ContaInvestimentoDTO contaInvestimentoDTO)
        {
            var contaInvestimento = _mapperContaInvestimento.MapperDtoToEntity(contaInvestimentoDTO);
            _serviceContaInvestimento.Add(contaInvestimento);
        }

        public void Remove(ContaInvestimentoDTO contaInvestimentoDTO)
        {
            var contaInvestimento = _mapperContaInvestimento.MapperDtoToEntity(contaInvestimentoDTO);
            _serviceContaInvestimento.Delete(contaInvestimento);
        }

        public void Update(ContaInvestimentoDTO contaInvestimentoDTO)
        {
            var contaInvestimento = _mapperContaInvestimento.MapperDtoToEntity(contaInvestimentoDTO);
            _serviceContaInvestimento.Update(contaInvestimento);
        }

        public IEnumerable<ContaInvestimentoDTO> GetAll()
        {
            var contasInvestimentos = _serviceContaInvestimento.GetAll();
            return _mapperContaInvestimento.MapperListContaInvestimentoDto(contasInvestimentos);
        }

        public ContaInvestimentoDTO GetById(int id)
        {
            var contaInvestimento = _serviceContaInvestimento.GetById(id);
            return _mapperContaInvestimento.MapperEntityToDto(contaInvestimento);
        }
    }
}