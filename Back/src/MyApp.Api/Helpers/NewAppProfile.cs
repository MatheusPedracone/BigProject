using AutoMapper;
using MyApp.Api.Dtos;
using MyApp.Api.Models;

namespace MyApp.Api.Helpers
{
    public class NewAppProfile : Profile
    {
        public NewAppProfile()
        {
            CreateMap<Evento, EventoDto>().ReverseMap();
        }
    }
}