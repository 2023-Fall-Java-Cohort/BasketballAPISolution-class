using BasketballAPI.Context;
using BasketballDataModel;
using Microsoft.EntityFrameworkCore;

namespace BasketballAPI.Services
{
    public class PositionsService : Service<PositionModel>, IPositionsService
    {
        private readonly BasketballContext dbContext;
        private readonly ILogger<PositionModel> logger;

        public PositionsService(BasketballContext dbContext, ILogger<PositionModel> logger) : base(dbContext, logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }
        public override async ValueTask<PositionModel?> GetAsync(int id, CancellationToken cancellation = default)
        {
            PositionModel? entity;
            try
            {
                entity = await dbContext.Set<PositionModel>()
                    .Where(w => w.Id == id)
                    .Include(p => p.Players)
                    .ThenInclude(p=>p.Team)
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
