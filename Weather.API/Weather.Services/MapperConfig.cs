using AutoMapper;
using Weather.API.Weather.Models;
using Weather.API.Weather.Models.DTOS;

namespace Weather.API.Weather.Services
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<RegisterUserDto, User>().ReverseMap();
        }
    }
}
