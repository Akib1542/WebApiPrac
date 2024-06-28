using Application.Models;
using MediatR;


namespace Application.Features.Games.Commands
{
    public class UpdateGameRequest : IRequest<bool>
    {
        public UpdateGame UpdateGame { get; set; }

        public UpdateGameRequest(UpdateGame updateGame)
        {
            UpdateGame = updateGame;
        }
    }
}
