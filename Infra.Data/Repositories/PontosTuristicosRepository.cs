using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class PontosTuristicosRepository : IPontosTuristicosRepository
    {
        readonly ApplicationDbContext _context;
        public PontosTuristicosRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PontosTuristicos> Update(PontosTuristicos model)
        {
            _context.PontosTuristicos.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }
        public async Task<PontosTuristicos> Create(PontosTuristicos model)
        {
            _context.PontosTuristicos.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
        public async Task<PontosTuristicos> Remove(PontosTuristicos model)
        {
            _context.PontosTuristicos.Remove(model);
            await _context.SaveChangesAsync();
            return model;
        }
        public async Task<IEnumerable<PontosTuristicos>> GetPontosTuristicos()
        {
            return await _context.PontosTuristicos.ToListAsync();
        }
        public async Task<PontosTuristicos> GetById(Guid id)
        {
            var retorno = await _context.PontosTuristicos.FindAsync(id);
            if(retorno == null)
            {
                throw new NotImplementedException();
            }
            return retorno;
        }
    }
}
