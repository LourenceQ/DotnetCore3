using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCore3.Models;

namespace DotnetCore3.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        {            
            new Character(),
            new Character {Id = 1, Name = "Radagast"}
        };
<<<<<<< HEAD
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
=======
        public async Task<List<Character>> AddCharacter(Character newCharacter)
>>>>>>> 721f471e681aa1533deb5857ad6a9c5b56e4db60
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

<<<<<<< HEAD
        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
=======
        public async Task<List<Character>> GetAllCharacters()
>>>>>>> 721f471e681aa1533deb5857ad6a9c5b56e4db60
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

<<<<<<< HEAD
        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
=======
        public async Task<Character> GetCharacterById(int id)
>>>>>>> 721f471e681aa1533deb5857ad6a9c5b56e4db60
        {
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
            return serviceResponse;
        }
    }
}