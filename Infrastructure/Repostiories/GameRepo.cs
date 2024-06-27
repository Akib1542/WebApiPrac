using Application.Repositories;
using Domain;
using Infrastructure.Contexts;

namespace Infrastructure.Repostiories
{
    public class GameRepo : IRepo
    {
        private readonly ApplicationDbContext _context;

        public GameRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddGameAsync(Game game)
        {
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
           
        }

        public Task DeleteGameAsync(Game game)
        {
            throw new NotImplementedException();
        }

        public Task<List<Game>> GetAllGamesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Game> GetGameById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGameAsync(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
