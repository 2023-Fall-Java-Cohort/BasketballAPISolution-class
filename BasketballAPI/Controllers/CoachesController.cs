using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BasketballAPI.Context;
using BasketballDataModel;
using BasketballAPI.Services;

namespace BasketballAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CoachesController : BaseController<CoachModel>
    {
        
        

        public CoachesController(ICoachesService service, ILogger<CoachesController> logger) : base(service,logger )
        {
            
        }
    }
}
