using Application.Repositories;
using Domain;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

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

        public async Task DeleteGameAsync(Game game)
        {
            _context.Remove(game);
            await _context.SaveChangesAsync();   
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> GetGameById(int id)
        {
            return await _context.Games.FindAsync(id);
        }

        public async Task UpdateGameAsync(Game game)
        {
            _context.Games.Update(game);
            await _context.SaveChangesAsync();

        }
    }
}
