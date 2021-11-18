using AutoMapper;
using DotnetCore3.Dto.Character;
using DotnetCore3.Dto.Weapon;
using DotnetCore3.Models;

namespace DotnetCore3
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
    }
}