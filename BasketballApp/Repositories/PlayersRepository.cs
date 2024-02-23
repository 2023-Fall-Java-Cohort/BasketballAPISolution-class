using BasketballDataModel;

namespace BasketballApp.Repositories
{
    public class PlayersRepository : BaseRepository<PlayerModel>, IPlayersRepository
    {
        public PlayersRepository(IConfiguration configuration, HttpClient client, ILogger logger) 
            : base("Players", configuration, client, logger)
        {
        }
    }
}
