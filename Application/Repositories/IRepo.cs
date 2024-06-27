using Domain;

namespace Application.Repositories
{
    public interface IRepo
    {
        Task AddGameAsync (Game game);
        Task DeleteGameAsync (Game game);
        Task<List<Game>> GetAllGamesAsync ();
        Task<Game>GetGameById (int id);
        Task UpdateGameAsync (Game game);
    }
}
