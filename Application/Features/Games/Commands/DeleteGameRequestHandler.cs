using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Games.Commands
{
    public class DeleteGameRequestHandler : IRequestHandler<DeleteGameRequest, bool>
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public DeleteGameRequestHandler(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteGameRequest request, CancellationToken cancellationToken)
        {
            var gameInDb = await _repo.GetGameById(request.GameDeleteId);
            if(gameInDb != null)
            {
                await _repo.DeleteGameAsync(gameInDb);
                return true;
            }
            return false;
        }
    }
}
