using BasketballAPI.Context;
using BasketballAPI.Services;

namespace BasketballAPI
{
    public static class Startup
    {
        public static IServiceCollection AddDbService(this IServiceCollection services)
        {
            services.AddDbContext<BasketballContext>();
            services.AddScoped<IPlayersService, PlayersService>();
            services.AddScoped<ICoachesService, CoachesService>();
            services.AddScoped<ITeamsService, TeamsService>();
            services.AddScoped<IPositionsService, PositionsService>();  

            return services;
        }
    }
}
