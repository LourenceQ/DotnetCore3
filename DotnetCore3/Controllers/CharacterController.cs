using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCore3.Dto.Character;
using DotnetCore3.Models;
using DotnetCore3.Services.CharacterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore3.Controllers
{
    [Authorize]
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

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {      
            ServiceResponse<GetCharacterDto> response = await _characterService.UpdateCharacter(updateCharacter); 
            if (response.Data == null)
            {
                return NotFound(response);
            }     
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ServiceResponse<List<GetCharacterDto>> response = await _characterService.DeleteCharacter(id); 
            if (response.Data == null)
            {
                return NotFound(response);
            }     
            return Ok(response);
        }
    }
}