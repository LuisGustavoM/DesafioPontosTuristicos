using Domain.Entities;
using Domain.Filtros;

namespace Domain.Interfaces
{
    public interface IPontosTuristicosRepository
    {
        Task<IEnumerable<PontosTuristicos>> GetPontosTuristicos();
        Task<IEnumerable<PontosTuristicos>> GetPontosTuristicosByFiltro(FiltroPontosTuristicos filtro);
        Task<PontosTuristicos> GetById(Guid id);
        Task<PontosTuristicos> Create(PontosTuristicos model);
        Task<PontosTuristicos> Update(PontosTuristicos model);
        Task<PontosTuristicos> Remove(PontosTuristicos model);
    }
}
