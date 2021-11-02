using System.Collections.Generic;
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
            new Character {name = "Radagast"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        } 

        public IActionResult GetSingle()
        {
            return Ok(characters[0]);
        }       
    }
}