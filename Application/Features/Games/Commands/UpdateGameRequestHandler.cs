using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Games.Commands
{
    public class UpdateGameRequestHandler : IRequestHandler<UpdateGameRequest, bool>
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public UpdateGameRequestHandler(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateGameRequest request, CancellationToken cancellationToken)
        {
            var GameInDb = await _repo.GetGameById(request.UpdateGame.Id);
            if (GameInDb != null)
            {
                GameInDb.Id = request.UpdateGame.Id;
                GameInDb.Name = request.UpdateGame.Name;
                GameInDb.Version = request.UpdateGame.Version;
                await _repo.UpdateGameAsync(GameInDb);
                return true;
            }
            return false;
        }
    }
}
