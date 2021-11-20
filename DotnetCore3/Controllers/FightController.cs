using DotnetCore3.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore3.Controllers
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