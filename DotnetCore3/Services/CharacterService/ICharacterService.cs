using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetCore3.Models;

namespace DotnetCore3.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}