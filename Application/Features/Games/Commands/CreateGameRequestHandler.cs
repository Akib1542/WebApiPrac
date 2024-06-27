using Application.Repositories;
using AutoMapper;
using MediatR;
using Domain;

namespace Application.Features.Games.Commands
{
    public class CreateGameRequestHandler : IRequestHandler<CreateGameRequest, bool>
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public CreateGameRequestHandler(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateGameRequest request, CancellationToken cancellationToken)
        {
            Game GameInDb = _mapper.Map<Game>(request.newGame);
            await _repo.AddGameAsync(GameInDb);
            return true;
        }
    }
}
