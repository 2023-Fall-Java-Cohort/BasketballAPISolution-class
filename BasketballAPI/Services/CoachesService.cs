using BasketballAPI.Context;
using BasketballDataModel;
using Microsoft.EntityFrameworkCore;

namespace BasketballAPI.Services
{
    public class CoachesService : Service<CoachModel>, ICoachesService
    {
        private readonly BasketballContext dbContext;
        private readonly ILogger<CoachModel> logger;

        public CoachesService(BasketballContext dbContext, ILogger<CoachModel> logger) : base(dbContext, logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }
        public override async ValueTask<CoachModel?> GetAsync(int id, CancellationToken cancellation = default)
        {
            CoachModel? entity;
            try
            {
                entity = await dbContext.Set<CoachModel>()
                    .Where(w => w.Id == id)
                    .Include(t=>t.Team)
                    .ThenInclude(p => p.Players)
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
