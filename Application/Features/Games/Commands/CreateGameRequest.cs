using Application.Models;
using MediatR;

namespace Application.Features.Games.Commands
{
    public class CreateGameRequest : IRequest<bool>
    {
        public NewGame newGame { get; set; }

        public CreateGameRequest(NewGame newGame) 
        {
            this.newGame = newGame;
        }
    }
}
