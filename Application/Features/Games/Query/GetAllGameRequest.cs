using Application.Models;
using MediatR;


namespace Application.Features.Games.Query
{
    public class GetAllGameRequest : IRequest<List<GameDTO>>
    {
    }
}
