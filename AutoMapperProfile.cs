using System.Linq;
using AutoMapper;
using Udemy_NetCore.Dtos.Character;
using Udemy_NetCore.Dtos.CharacterSkill;
using Udemy_NetCore.Dtos.Skill;
using Udemy_NetCore.Dtos.Weapon;
using Udemy_NetCore.Models;

namespace Udemy_NetCore
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill))); 
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}