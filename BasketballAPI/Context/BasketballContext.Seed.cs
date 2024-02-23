using BasketballDataModel;
using BasketballDataModel.FakeData;
using Microsoft.EntityFrameworkCore;

namespace BasketballAPI.Context
{
    public partial class BasketballContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<TeamModel>()
                .HasData(
                new TeamModel()
                {
                    Id = 1,
                    Name = "ATLANTA HAWKS",
                    NationalRank = 3,
                },
                new TeamModel()
                {
                    Id = 2,
                    Name = "BOSTON CELTICS",
                    NationalRank = 1,
                },
                new TeamModel()
                {
                    Id = 3,
                    Name = "BROOKLYN NETS",
                    NationalRank = 6,
                },
                new TeamModel()
                {
                    Id = 4,
                    Name = "CHARLOTTE HORNETS",
                    NationalRank = 2,
                },
                new TeamModel()
                {
                    Id = 5,
                    Name = "CHICAGO BULLS",
                    NationalRank = 4,
                }
                );
            modelBuilder.Entity<PositionModel>()
                .HasData(
                new PositionModel()
                {
                    Id= 1,
                    Name = "Point Guard",
                },
                new PositionModel()
                {
                    Id = 2,
                    Name = "Shooting Guard",
                },
                new PositionModel()
                {
                    Id = 3,
                    Name = "Small Forward",
                },
                new PositionModel()
                {
                    Id = 4,
                    Name = "Power Forward",
                },
                new PositionModel()
                {
                    Id = 5,
                    Name = "Center",
                }
               );
            GenreatePlayers genreatePlayers = new GenreatePlayers();
            modelBuilder.Entity<PlayerModel>().HasData( genreatePlayers.GetPlayers(500,5,5 ));

            GenerateCoachs coachs = new GenerateCoachs(5);
            modelBuilder.Entity<CoachModel>().HasData(coachs.GetCoachs());
        }
    }
}
