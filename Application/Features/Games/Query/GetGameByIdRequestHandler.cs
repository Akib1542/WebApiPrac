using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Games.Query
{
    public class GetGameByIdRequestHandler : IRequestHandler<GetGameByIdRequest, GameDTO>
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public GetGameByIdRequestHandler(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<GameDTO> Handle(GetGameByIdRequest request, CancellationToken cancellationToken)
        {
            Game gameInDb = await _repo.GetGameById(request.GameId);
            if (gameInDb != null)
            {
                GameDTO gameInDto = _mapper.Map<GameDTO>(gameInDb);
                
                return gameInDto;
            }
            return null;
        }
    }
}
