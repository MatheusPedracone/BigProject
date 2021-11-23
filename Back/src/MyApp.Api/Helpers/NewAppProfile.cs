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
            CreateMap<Lote, LoteDto>().ReverseMap();
            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteDto>().ReverseMap();
        }
    }
}