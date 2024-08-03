using AutoMapper;
using Net_8_LoginApp.DTOs;
using Net_8_LoginApp.Models;

namespace Net_8_LoginApp.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SuperHero, SuperHeroDto>().ReverseMap();
            CreateMap<SuperHero, CreateSuperHeroDto>().ReverseMap();
        }
    }
}
