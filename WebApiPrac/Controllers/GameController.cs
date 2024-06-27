using Application.Features.Games.Commands;
using Application.Models;
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


    }
}
