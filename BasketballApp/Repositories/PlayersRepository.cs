using BasketballDataModel;

namespace BasketballApp.Repositories
{
    public class PlayersRepository : BaseRepository<PlayerModel>, IPlayersRepository
    {
        public PlayersRepository(IConfiguration configuration, HttpClient client, ILogger<PlayersRepository> logger) 
            : base("Players",configuration, client, logger)
        {
        }
    }
}
