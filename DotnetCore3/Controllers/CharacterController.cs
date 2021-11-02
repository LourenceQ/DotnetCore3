using System.Collections.Generic;
using System.Linq;
using DotnetCore3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore3.Controllers
{
        [ApiController]
        [Route("[controller]")]    
        public class CharacterController : ControllerBase
        {
        
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character {Id = 1, Name = "Radagast"}
        };
        
        [HttpGet("GetAll")]
        public IActionResult GetActionResult()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

    }
}