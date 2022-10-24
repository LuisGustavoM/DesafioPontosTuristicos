using Application.DTOs;
using Application.Interface;
using AutoMapper;
using Domain.Entities;
using Domain.Filtros;
using Domain.Interfaces;

namespace Application.Service
{
    public class PontosTuristicosService : IPontosTuristicosService
    {
        private IPontosTuristicosRepository _repo;
        private readonly IMapper _mapper;

        public PontosTuristicosService(IPontosTuristicosRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Add(PontosTuristicosDTO pontosTuristicosDTO)
        {
            var pontosTuristicosEntity = _mapper.Map<PontosTuristicos>(pontosTuristicosDTO);
            await _repo.Create(pontosTuristicosEntity);
        }

        public async Task<PontosTuristicosDTO> GetById(Guid id)
        {
            var pontosTuristicosEntity = await _repo.GetById(id);
            return _mapper.Map<PontosTuristicosDTO>(pontosTuristicosEntity);
        }

        public async Task Remove(Guid id)
        {
            var pontoTuristico = _repo.GetById(id).Result;
            await _repo.Remove(pontoTuristico);
        }

        public async Task Update(PontosTuristicosDTO pontosTuristicosDTO)
        {
            var pontosTuristicosEntity = _mapper.Map<PontosTuristicos>(pontosTuristicosDTO);
            await _repo.Update(pontosTuristicosEntity);
        }

        public async Task<IEnumerable<PontosTuristicosDTO>> GetPontosTuristicos()
        {
            var pontoTuristico = await _repo.GetPontosTuristicos();
            return _mapper.Map<IEnumerable<PontosTuristicosDTO>>(pontoTuristico);
        }

        public async Task<IEnumerable<PontosTuristicosDTO>> GetPontosTuristicosByFiltro(FiltroPontosTuristicos filtro)
        {
            var pontoTuristico = await _repo.GetPontosTuristicosByFiltro(filtro);
            return _mapper.Map<IEnumerable<PontosTuristicosDTO>>(pontoTuristico);
        }
    }
}
