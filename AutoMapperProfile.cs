using AutoMapper;
using WebAPIService.Dtos.Character;
using WebAPIService.Models;

namespace WebAPIService
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}