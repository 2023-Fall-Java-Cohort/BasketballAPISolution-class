using BasketballDataModel;

namespace BasketballApp.Repositories
{
    public class TeamsRepository : BaseRepository<TeamModel>, ITeamsRepository
    {
        public TeamsRepository(IConfiguration configuration, HttpClient client, ILogger<TeamsRepository> logger) 
            : base("Teams",configuration, client, logger)
        {
        }
    }
}
