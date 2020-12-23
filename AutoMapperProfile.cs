using AutoMapper;
using Udemy_NetCore.Dtos.Character;
using Udemy_NetCore.Models;

namespace Udemy_NetCore
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