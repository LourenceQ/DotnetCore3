using System.Linq;
using AutoMapper;
using DotnetCore3.Dto.Character;
using DotnetCore3.Dto.Skill;
using DotnetCore3.Dto.Weapon;
using DotnetCore3.Models;

namespace DotnetCore3
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