
using Application.DTOs;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontosTuristicosController : ControllerBase
    {
        private readonly IPontosTuristicosService _repo;

        public PontosTuristicosController(IPontosTuristicosService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PontosTuristicosDTO>>> GetPontosTuristicos()
        {
            var pontosTuristicos = await _repo.GetPontosTuristicos();

            if(pontosTuristicos == null)
            {
                return NotFound("Nenhum ponto turistico encontrado!");
            }
            return Ok(pontosTuristicos);
        }


        [HttpGet("{id:Guid}", Name = "GetPontoTuristico")]
        public async Task<ActionResult<PontosTuristicosDTO>> Get(Guid id)
        {
            var pontoTuristico = await _repo.GetById(id);
            if (pontoTuristico == null)
            {
                return NotFound("Ponto turistico não encontrado");
            }
            return Ok(pontoTuristico);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PontosTuristicosDTO pontoTuristicoDTO)
        {
            if (pontoTuristicoDTO == null)
                return BadRequest();

            await _repo.Add(pontoTuristicoDTO);

            return new CreatedAtRouteResult("GetPontoTuristico", new { id = pontoTuristicoDTO.Id },
                pontoTuristicoDTO);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Guid id, [FromBody] PontosTuristicosDTO pontoTuristicoDTO)
        {
            if (id != pontoTuristicoDTO.Id)
                return BadRequest();

            if (pontoTuristicoDTO == null)
                return BadRequest();

            await _repo.Update(pontoTuristicoDTO);

            return Ok(pontoTuristicoDTO);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<PontosTuristicosDTO>> Delete(Guid id)
        {
            var pontoTuristico = await _repo.GetById(id);
            if (pontoTuristico == null)
            {
                return NotFound("Ponto turistico não encontrado");
            }

            await _repo.Remove(id);

            return Ok(pontoTuristico);

        }
    }
}
