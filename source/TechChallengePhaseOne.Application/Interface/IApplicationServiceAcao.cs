using TechChallengePhaseOne.Application.Dto;

namespace TechChallengePhaseOne.Application.Interface
{
    public interface IApplicationServiceAcao
    {
        void Add(AcaoDTO acaoDTO);

        void Remove(AcaoDTO acaoDTO);

        void Update(AcaoDTO acaoDTO);

        IEnumerable<AcaoDTO> GetAll();

        AcaoDTO GetById(int id);
    }
}