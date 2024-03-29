﻿using BasketballDataModel;

namespace BasketballApp.Repositories
{
    public class PositionsRepository : BaseRepository<PositionModel>, IPositionsRepository
    {
        public PositionsRepository(IConfiguration configuration, HttpClient client, ILogger<PositionsRepository> logger) 
            : base("Positions",configuration, client, logger)
        {
        }
    }
}
