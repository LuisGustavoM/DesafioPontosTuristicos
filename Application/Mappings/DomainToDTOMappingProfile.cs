using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Filtros;

namespace Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<PontosTuristicos, PontosTuristicosDTO>().ReverseMap();
        }
    }
}
