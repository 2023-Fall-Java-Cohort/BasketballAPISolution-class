using BasketballDataModel;
using Microsoft.EntityFrameworkCore;

namespace BasketballAPI.Context
{
    public partial class BasketballContext
    {
        public DbSet<CoachModel> Coaches { get; set; }
        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<TeamModel> Teams { get; set; }
        public DbSet<PositionModel> Positions { get; set; }
       
    }
}
