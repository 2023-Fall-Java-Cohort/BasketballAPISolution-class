using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BasketballAPI.Context
{
    public  partial class BasketballContext : DbContext
    {
        private readonly IConfiguration configuration;

        public BasketballContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            if (connectionString != null)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            else
            {
                throw new InvalidOperationException("can not find Connection string DefaultConnection");
            }
        }
    }
}
