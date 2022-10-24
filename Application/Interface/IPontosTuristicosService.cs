using Application.DTOs;
using Domain.Filtros;

namespace Application.Interface
{
    public interface IPontosTuristicosService
    {
        Task<IEnumerable<PontosTuristicosDTO>> GetPontosTuristicos(); 
        Task<IEnumerable<PontosTuristicosDTO>> GetPontosTuristicosByFiltro(FiltroPontosTuristicos filtro);
        Task<PontosTuristicosDTO> GetById(Guid id);
        Task Add(PontosTuristicosDTO categoryDTO);
        Task Update(PontosTuristicosDTO categoryDTO);
        Task Remove(Guid id);

    }
}
