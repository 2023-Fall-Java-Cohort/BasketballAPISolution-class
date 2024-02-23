using BasketballAPI.Context;
using BasketballDataModel;
using Microsoft.EntityFrameworkCore;

namespace BasketballAPI.Services
{
    public class TeamsService : Service<TeamModel>, ITeamsService
    {
        private readonly BasketballContext dbContext;
        private readonly ILogger<TeamModel> logger;

        public TeamsService(BasketballContext dbContext, ILogger<TeamModel> logger) : base(dbContext, logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }
        public override async ValueTask<TeamModel?> GetAsync(int id, CancellationToken cancellation = default)
        {
            TeamModel? entity;
            try
            {
                entity = await dbContext.Set<TeamModel>()
                    .Include(t=>t.Coaches)
                    .Include(p=>p.Players)
                    .ThenInclude(p=>p.Position)
                    .Where(w => w.Id == id)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellation);
                if (entity is null)
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error getting {className} from the Database using Id = {id}");
                throw;
            }
            return entity;
        }
    }
}
