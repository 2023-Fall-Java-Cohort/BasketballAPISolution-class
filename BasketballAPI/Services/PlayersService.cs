using BasketballAPI.Context;
using BasketballDataModel;
using Microsoft.EntityFrameworkCore;

namespace BasketballAPI.Services
{
    public class PlayersService : Service<PlayerModel>, IPlayersService
    {
        private readonly BasketballContext dbContext;
        private readonly ILogger<PlayerModel> logger;

        public PlayersService(BasketballContext dbContext, ILogger<PlayerModel> logger) : base(dbContext, logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }



        public override async ValueTask<PlayerModel?> GetAsync(int id, CancellationToken cancellation = default)
        {

            PlayerModel? entity;
            try
            {
                entity = await dbContext.Set<PlayerModel>()
                    .Where(w => w.Id == id)
                    .Include(p => p.Position)
                    .Include(s=>s.Team)
                    .ThenInclude(t => t.Coaches)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellation);
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
