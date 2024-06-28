using Application.Features.Games.Commands;
using Application.Features.Games.Query;
using Application.Models;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApiPrac.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly ISender _midatrSender;

        public GameController(ISender midatrSender)
        {
            _midatrSender = midatrSender;
        }

        [HttpPost("AddGame")]
        public async Task<IActionResult> AddNewGame([FromBody] NewGame newGame)
        {
            bool isSuccessful = await _midatrSender.Send(new CreateGameRequest(newGame));
            if (isSuccessful)
            {
                return Ok("Game Added Successfully!");
            }
            return NotFound("Failed to Create New Game!");
        }

        [HttpPut("UpdateGame")]
        public async Task<IActionResult> UpdateGameAsync([FromBody] UpdateGame updateGame)
        {
            var game = await _midatrSender.Send(new UpdateGameRequest(updateGame));
            if (game)
            {
                return Ok(game);
            }
            return BadRequest("No game was found!");
        }


        [HttpGet("GetAllGame")]
        public async Task<IActionResult> GetAllGameAsync()
        {
            var allGames = await _midatrSender.Send(new GetAllGameRequest());
            if(allGames == null )
            {
                return NotFound("You Have no games!");
            }
            return Ok(allGames);    
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetGamebyIdAsync(int id)
        {
            var game = await _midatrSender.Send(new GetGameByIdRequest(id));
            if(game!=null)
            {
                return Ok(game);
            }
            return NotFound("Game not found!");
        }

      
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteGameAsync(int id)
        {
            var game = await _midatrSender.Send(new  DeleteGameRequest(id));    
            if(game)
            {
                return Ok("Game Deleted successfully!");
            }
            return NotFound("Game not Found!");
        }


    }
}
