using BasketballAPI.Services;
using BasketballDataModel;
using Microsoft.AspNetCore.Mvc;

namespace BasketballAPI.Controllers
{
    [ApiController]
    public abstract class BaseController<TEntity> : ControllerBase where TEntity : class
    {
        private IService<TEntity> service;
        private ILogger logger;
        private readonly string className;

        public BaseController(IService<TEntity> service, ILogger logger)
        {
            this.service = service;
            this.logger = logger;
            className = typeof(TEntity).FullName ?? "TEntity";
        }

        [HttpGet]
        public async ValueTask<ActionResult<IEnumerable<TEntity>>> GetAll(CancellationToken cancellation = default(CancellationToken))
        {
            logger.LogInformation($"call GetAll {className}");
            try
            {
                return await service.GetAllAsync(cancellation);
                    
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:GetAll {className}");
            }
        }
        [HttpGet("{id}")]
        public async ValueTask<ActionResult<TEntity?>> GetById(int id, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                logger.LogInformation($"Get by ID {id} { className}");
                TEntity? entity = await service.GetAsync(id, cancellation);
                if(entity is null)
                {
                    return NotFound($"Record not found for Id {id} IN {className}");

                }
                return entity;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:GetById {className}");
            }
        }

        [HttpPost]
        public async ValueTask<ActionResult<TEntity>> PostModel(TEntity entity, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                logger.LogInformation($"Post Model {entity} {className}");
                return await service.AddAsync(entity, cancellation);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:PostModel {className}");
            }

        }

        [HttpPut]
        public async ValueTask<ActionResult<TEntity>> PutModel(TEntity entity, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                logger.LogInformation($"PutModel {entity} {className}");
                return await service.UpdateAsync(entity, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:PutModel {className}");
            }
        }

        /// <summary>
        /// Deletes the model.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cancellation">The cancellation.</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async ValueTask<ActionResult<bool>> DeleteModel(int id, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                logger.LogInformation($"DeleteModel {id} {className}");
                TEntity? entity = await service.GetAsync(id, cancellation);
                if (entity is not null) {
                    return await service.DeleteAsync(entity, cancellation);
                 }
                return Problem($"Can not find {id} to delete");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:DeleteModel {className}");
            }
        }
        [HttpGet("{pageIndex},{pageSize}")]
        public async ValueTask<ActionResult<List<TEntity>>> GetPaging(int pageIndex, int pageSize, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                logger.LogInformation($"GetPaging PageSize {pageSize}, pageIndex {pageIndex}");
                return await service.GetPaging(pageIndex, pageSize, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:GetPaging {className}");
            }
        }
        [HttpGet("{name}/{pageIndex}/{pageSize}")]
       public async  ValueTask<ActionResult<List<TEntity>>> FindNamePaging(string name,int pageIndex,int pageSize, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                return await service.FindNamePaging(name,pageIndex,pageSize, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:FindNamePaging {className}");
            }
            
        }
        [HttpGet("Count")]   
        public async ValueTask<ActionResult<CountModel>> GetCount( CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                CountModel model = new CountModel()
                {
                    Name = typeof(TEntity).Name,
                    Count = await service.GetCountAsync(cancellation)
                };
                return model;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return Problem($"{ex.Message}:Count {className}");
            }
        }
    
    }
}
