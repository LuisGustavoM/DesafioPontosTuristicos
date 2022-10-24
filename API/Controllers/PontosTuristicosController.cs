
using Application.DTOs;
using Application.Interface;
using Domain.Filtros;
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
        public async Task<ActionResult<IEnumerable<PontosTuristicosDTO>>> BuscarTodos()
        {
            var pontosTuristicos = await _repo.GetPontosTuristicos();

            if(pontosTuristicos == null)
            {
                return NotFound("Nenhum ponto turistico encontrado!");
            }
            return Ok(pontosTuristicos);
        }

        [HttpPost("BuscarTodosPorFiltro")]
        public async Task<ActionResult<IEnumerable<PontosTuristicosDTO>>> BuscarTodosPorFiltro([FromBody] FiltroPontosTuristicos filtroPontosTuristicos)
        {
            var pontosTuristicos = await _repo.GetPontosTuristicosByFiltro(filtroPontosTuristicos);

            if (pontosTuristicos == null)
            {
                return NotFound("Nenhum ponto turistico encontrado!");
            }
            return Ok(pontosTuristicos);
        }


        [HttpGet("{id:Guid}", Name = "BuscarPorId")]
        public async Task<ActionResult<PontosTuristicosDTO>> BuscarPorId(Guid id)
        {
            var pontoTuristico = await _repo.GetById(id);
            if (pontoTuristico == null)
            {
                return NotFound("Ponto turistico não encontrado");
            }
            return Ok(pontoTuristico);
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar([FromBody] PontosTuristicosDTO pontoTuristicoDTO)
        {
            if (pontoTuristicoDTO == null)
                return BadRequest();

            pontoTuristicoDTO.DataHoraCadastro = DateTime.Now;
            await _repo.Add(pontoTuristicoDTO);

            return Ok(pontoTuristicoDTO);
        }
        [HttpPut("{id:Guid}")]
        public async Task<ActionResult> Editar(Guid id, [FromBody] PontosTuristicosDTO pontoTuristicoDTO)
        {
            if (id != pontoTuristicoDTO.Id)
                return BadRequest();

            if (pontoTuristicoDTO == null)
                return BadRequest();

            pontoTuristicoDTO.DataHoraCadastro = pontoTuristicoDTO.DataHoraCadastro;
            await _repo.Update(pontoTuristicoDTO);

            return Ok(pontoTuristicoDTO);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<PontosTuristicosDTO>> Excluir(Guid id)
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
