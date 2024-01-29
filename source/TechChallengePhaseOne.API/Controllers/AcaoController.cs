using Microsoft.AspNetCore.Mvc;
using TechChallengePhaseOne.Application.Dto;
using TechChallengePhaseOne.Application.Interface;

namespace TechChallengePhaseOne.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcaoController : ControllerBase
    {
        private readonly IApplicationServiceAcao _applicationServiceAcao;

        public AcaoController(IApplicationServiceAcao applicationServiceAcao)
        {
            _applicationServiceAcao = applicationServiceAcao;
        }

        [HttpPost]
        public ActionResult Post([FromBody] AcaoDTO acaoDto)
        {            
            if (acaoDto == null)
                return NotFound();

            _applicationServiceAcao.Add(acaoDto);
            return CreatedAtAction("Get", new { id = acaoDto.Id }, acaoDto);            
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] AcaoDTO acaoDto)
        {
            _applicationServiceAcao.Remove(acaoDto);
            return Ok("Removido com sucesso");
        }

        [HttpPut]
        public ActionResult Put([FromBody] AcaoDTO acaoDto)
        {
            _applicationServiceAcao.Update(acaoDto);
            return Ok("Atualizado com sucesso");
        }

        [HttpGet]
        public ActionResult Get()
        {
            var acoes = _applicationServiceAcao.GetAll();
            return Ok(acoes);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var acao = _applicationServiceAcao.GetById(id);
            return Ok(acao);
        }

    }
}