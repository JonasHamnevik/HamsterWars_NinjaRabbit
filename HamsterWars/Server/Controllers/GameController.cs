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

        //[HttpPut("Play{first}/{second}/{winner}/")]
        //public IActionResult Play([FromRoute] int first, [FromRoute] int second, [FromRoute] int winner)
        //{
        //    bool playGame = gameService.Play(first, second, winner);
        //    if (playGame)
        //        return Ok();
        //    return BadRequest();
        //}

        [HttpPut("Play{id}")]
        public IActionResult Play(int id, [FromBody] Game game)
        {

            bool playGame = gameService.Play(game.First, game.Second, id);
            if (playGame)
                return Ok();
            return BadRequest();
        }

        //[HttpPut("Win")]
        //public async Task Winner([FromRoute] Hamster hamster)
        //{
        //    await gameService.Win(hamster);
        //}

        //[HttpPut("Loss")]
        //public async Task Loser([FromRoute] Hamster hamster)
        //{
        //    await gameService.Loss(hamster);
        //}

    }
}
