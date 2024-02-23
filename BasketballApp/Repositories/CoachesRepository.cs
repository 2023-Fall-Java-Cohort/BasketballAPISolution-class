using BasketballDataModel;

namespace BasketballApp.Repositories
{
    public class CoachesRepository : BaseRepository<CoachModel>, ICoachesRepository
    {
        public CoachesRepository(IConfiguration configuration, HttpClient client, ILogger logger)
            : base("Coaches", configuration, client, logger)
        {
        }
    }
}
