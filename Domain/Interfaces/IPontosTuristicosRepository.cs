using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPontosTuristicosRepository
    {
        Task<IEnumerable<PontosTuristicos>> GetPontosTuristicos();
        Task<PontosTuristicos> GetById(Guid id);
        Task<PontosTuristicos> Create(PontosTuristicos model);
        Task<PontosTuristicos> Update(PontosTuristicos model);
        Task<PontosTuristicos> Remove(PontosTuristicos model);
    }
}
