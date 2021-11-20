using System.Threading.Tasks;
using DotnetCore3.Dto.Character;
using DotnetCore3.Dto.CharacterSkill;
using DotnetCore3.Models;

namespace DotnetCore3.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
         Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}