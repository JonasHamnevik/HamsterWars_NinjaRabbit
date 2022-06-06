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

        [HttpGet("CreateGame")]
        public Game CreateGame()
        {
            return gameService.CreateGame();
        }

        [HttpPut("Play{id}")]
        public IActionResult Play(int id, [FromBody] Game game)
        {

            bool playGame = gameService.Play(game.First, game.Second, id);
            if (playGame)
                return Ok();
            return BadRequest();
        }
    }
}
