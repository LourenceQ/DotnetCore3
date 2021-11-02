using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetCore3.Models;

namespace DotnetCore3.Services.CharacterService
{
    public interface ICharacterService
    {
<<<<<<< HEAD
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
=======
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
>>>>>>> 721f471e681aa1533deb5857ad6a9c5b56e4db60
    }
}