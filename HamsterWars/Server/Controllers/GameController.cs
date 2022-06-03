using HamsterWars.Shared;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace HamsterWars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameService gameService;

        public GameController(GameService gameService)
        {
            this.gameService = gameService;
        }

        //[HttpGet("GetAll")]
        //public IEnumerable<HamsterDTO> GetAll() =>
        //gameService.CreateHamsterDTOs();

        [HttpGet("CreateGame")]
        public Game CreateGame()
        {
            return gameService.CreateGame();
        }

        [HttpPut("Play/{first}/{second}/{winner}/")]
        public IActionResult Play([FromRoute] int first, [FromRoute] int second, [FromRoute] int winner)
        {
            bool playGame = gameService.Play(first, second, winner);
            if (playGame)
                return Ok();
            return BadRequest();
        }
    }
}
