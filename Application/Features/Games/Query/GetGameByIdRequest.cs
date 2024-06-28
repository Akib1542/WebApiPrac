using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Games.Query
{
    public class GetGameByIdRequest : IRequest<GameDTO>
    {
        public int GameId { get; set; }

        public GetGameByIdRequest(int gameDto)
        {
            GameId = gameDto;
        }
    }
}
