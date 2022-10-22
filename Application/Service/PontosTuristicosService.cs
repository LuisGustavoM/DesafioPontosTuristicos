using Application.DTOs;
using Application.Interface;
using AutoMapper;
using Domain.Entities;
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

        public async Task Add(PontosTuristicosDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<PontosTuristicos>(categoryDTO);
            await _repo.Create(categoryEntity);
        }

        public async Task<PontosTuristicosDTO> GetById(Guid id)
        {
            var categoryEntity = await _repo.GetById(id);
            return _mapper.Map<PontosTuristicosDTO>(categoryEntity);
        }

        public async Task Remove(Guid id)
        {
            var categoriesEntity = _repo.GetById(id).Result;
            await _repo.Remove(categoriesEntity);
        }

        public async Task Update(PontosTuristicosDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<PontosTuristicos>(categoryDTO);
            await _repo.Update(categoryEntity);
        }

        public async Task<IEnumerable<PontosTuristicosDTO>> GetPontosTuristicos()
        {
            var categoriesEntity = await _repo.GetPontosTuristicos();
            return _mapper.Map<IEnumerable<PontosTuristicosDTO>>(categoriesEntity);
        }
    }
}
