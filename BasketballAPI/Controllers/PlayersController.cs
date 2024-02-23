using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BasketballAPI.Context;
using BasketballDataModel;
using BasketballAPI.Services;

namespace BasketballAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PlayersController : BaseController<PlayerModel>
    {
        public PlayersController(IPlayersService service, ILogger<PlayersController> logger) : base(service, logger)
        {

        }
    }
}
