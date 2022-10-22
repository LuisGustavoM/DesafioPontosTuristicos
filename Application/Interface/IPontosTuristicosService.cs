using Application.DTOs;

namespace Application.Interface
{
    public interface IPontosTuristicosService
    {
        Task<IEnumerable<PontosTuristicosDTO>> GetPontosTuristicos();
        Task<PontosTuristicosDTO> GetById(Guid id);
        Task Add(PontosTuristicosDTO categoryDTO);
        Task Update(PontosTuristicosDTO categoryDTO);
        Task Remove(Guid id);

    }
}
