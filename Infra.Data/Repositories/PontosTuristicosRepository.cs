using Domain.Entities;
using Domain.Filtros;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

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
        public async Task<IEnumerable<PontosTuristicos>> GetPontosTuristicosByFiltro(FiltroPontosTuristicos filtroPontosTuristicos)
        {
            var query = await _context.PontosTuristicos.ToListAsync();

            if (!string.IsNullOrEmpty(filtroPontosTuristicos.Filtro))
                query = query.Where(
                    c => c.Nome.ToUpper().Contains(filtroPontosTuristicos.Filtro.ToUpper()) ||
                    c.Descricao.ToUpper().Contains(filtroPontosTuristicos.Filtro.ToUpper()) ||
                    c.Cidade.ToUpper().Contains(filtroPontosTuristicos.Filtro.ToUpper()) ||
                    c.Estado.ToUpper().Contains(filtroPontosTuristicos.Filtro.ToUpper())
                    //c.Referencia.ToUpper().Contains(filtro.ToUpper()) não solicitado no desafio
                  ).ToList();

            if(filtroPontosTuristicos.OrdenarCrescente == true)
            {
                switch (filtroPontosTuristicos.OrdenarPor)
                {
                    case "nome":
                        query = query.OrderBy(c => c.Nome).ToList();
                        break;
                    case "descricao":
                        query = query.OrderBy(c => c.Descricao).ToList();
                        break;
                    case "referencia":
                        query = query.OrderBy(c => c.Referencia).ToList();
                        break;
                    case "estado":
                        query = query.OrderBy(c => c.Estado).ToList();
                        break;
                    case "cidade":
                        query = query.OrderBy(c => c.Cidade).ToList();
                        break;
                    case "dataHoraCadastro":
                        query = query.OrderBy(c => c.DataHoraCadastro).ToList();
                        break;
                    default:
                        break;
                }
            } else {
                switch (filtroPontosTuristicos.OrdenarPor)
                {
                    case "nome":
                        query = query.OrderByDescending(c => c.Nome).ToList();
                        break;
                    case "descricao":
                        query = query.OrderByDescending(c => c.Descricao).ToList();
                        break;
                    case "referencia":
                        query = query.OrderByDescending(c => c.Referencia).ToList();
                        break;
                    case "estado":
                        query = query.OrderByDescending(c => c.Estado).ToList();
                        break;
                    case "cidade":
                        query = query.OrderByDescending(c => c.Cidade).ToList();
                        break;
                    case "dataHoraCadastro":
                        query = query.OrderByDescending(c => c.DataHoraCadastro).ToList();
                        break;
                    default:
                        break;
                }
            }

            return query;
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
