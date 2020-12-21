
using Udemy_NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Udemy_NetCore.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController: ControllerBase
    {
        private static Character knight = new Character();

        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}