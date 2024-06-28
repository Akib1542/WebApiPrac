using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Games.Query
{
    public class GetAllGameRequestHandler : IRequestHandler<GetAllGameRequest, List<GameDTO>>
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public GetAllGameRequestHandler(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<GameDTO>> Handle(GetAllGameRequest request, CancellationToken cancellationToken)
        {
            List<Game> gamesInDb = await _repo.GetAllGamesAsync();
            if(gamesInDb != null)
            {
                List<GameDTO> gameInDto = _mapper.Map<List<GameDTO>>(gamesInDb);
                return gameInDto;
            }
            return null;
        }
    }
}
