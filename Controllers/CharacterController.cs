using System.Collections.Generic;
using System.Linq;
using Udemy_NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Udemy_NetCore.Services.CharacterService;
using System.Threading.Tasks;

namespace Udemy_NetCore.Controllers
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
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        //        [HttpDelete]
        //        public IActionResult RemoveCharacter(Character character)
        //        {
        //            return characters.Remove(character) ?  Ok() : BadRequest();
        //        }
    }
}