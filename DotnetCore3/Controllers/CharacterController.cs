using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCore3.Dto.Character;
using DotnetCore3.Models;
using DotnetCore3.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetActionResult()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCarachter(AddCharacterDto newCharacter)
        {           
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}