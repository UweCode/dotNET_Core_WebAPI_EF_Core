using Microsoft.AspNetCore.Mvc;
using Udemy_NetCore.Services.FightService;

namespace Udemy_NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;

        }
    }
}