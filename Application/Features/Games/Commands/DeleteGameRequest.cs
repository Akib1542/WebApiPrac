using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Games.Commands
{
    public class DeleteGameRequest : IRequest<bool>
    {
        public int GameDeleteId { get; set; }

        public DeleteGameRequest(int gameDeleteId)
        {
            GameDeleteId = gameDeleteId;
        }
    }
}
