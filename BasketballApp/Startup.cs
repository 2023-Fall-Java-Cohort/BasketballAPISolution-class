using BasketballApp.Controllers;
using BasketballApp.Repositories;
using BasketballDataModel;

namespace BasketballApp
{
    public static class Startup
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddScoped<ICoachesRepository, CoachesRepository>();
            services.AddScoped<IPlayersRepository,PlayersRepository>();
            services.AddScoped<ITeamsRepository, TeamsRepository>();
            services.AddScoped<IPositionsRepository, PositionsRepository>();
            services.AddSingleton<IErrorHandler, ErrorHandler>();
            return services;
        }
    }
}
