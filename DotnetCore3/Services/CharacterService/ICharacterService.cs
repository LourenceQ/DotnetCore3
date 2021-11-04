using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetCore3.Dto.Character;
using DotnetCore3.Models;

namespace DotnetCore3.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}