using NuGet.DependencyResolver;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace BasketballApp.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly string baseAddress;
        private readonly HttpClient client;
        private readonly ILogger logger;
        protected readonly string className;
        
        public BaseRepository(string baseAddress, IConfiguration configuration, HttpClient client, ILogger logger)
        {
            IConfigurationSection section = configuration.GetSection("ServerAddress");
            string? ipAddress = section.GetValue<string>("BasketballApi");
            this.baseAddress = $"{ipAddress}{baseAddress}";
            this.client = client;
            this.logger = logger;
            className = typeof(TEntity).FullName ?? "TEntity";
            this.client.BaseAddress = new Uri(this.baseAddress);
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellation = default)
        {
            try
            {
                string json = JsonSerializer.Serialize(entity);
                StringContent requestContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(baseAddress, requestContent, cancellation);
                entity = await response.ReadContentAsync<TEntity>(cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error Adding {className} to API Service {entity}");
                throw;
            }
            return entity;
        }
        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                string json = JsonSerializer.Serialize(entity);
                StringContent requestContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(baseAddress, requestContent, cancellation);
                entity = await response.ReadContentAsync<TEntity>(cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error Updating {className} to API Service {entity}");
                throw;
            }
            return entity;
        }
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellation = default(CancellationToken))
        {
            bool result = false;
            try
            {
                HttpResponseMessage response = await client.DeleteAsync($"{baseAddress}/{id}", cancellation);
                response.EnsureSuccessStatusCode();
                result = true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error deleting {className} from the Service {id}");
                throw;
            }
            return result;
        }

        public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellation = default(CancellationToken))
        {
            List<TEntity> result = new List<TEntity>();
            try
            {
                HttpResponseMessage? response = await client.GetAsync(baseAddress);
                if (response is null)
                {
                    throw new ApplicationException($"Error Getting all {className} from service");
                }
                result = await response.ReadContentAsync<List<TEntity>>(cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error getting all {className} from the Service");
                throw;
            }

            return result;
        }

        public async Task<TEntity?> GetAsync(int id, CancellationToken cancellation = default(CancellationToken))
        {
            TEntity? result;
            try
            {
                HttpResponseMessage? response = await client.GetAsync($"{baseAddress}/{id}", cancellation);
                if (response is null)
                {
                    throw new ApplicationException($"Error Getting By Id {id} {className} from service");
                }
                result = await response.ReadContentAsync<TEntity>(cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error getting By Id {id} from {className} from the Service");
                throw;
            }

            return result;
        }

        private int GetId(TEntity entity)
        {
            int id = 0;
            Type t = entity.GetType();

            PropertyInfo? prop = t.GetProperty("Id");
            if (prop is not null)
            {
                object? value = prop.GetValue(entity);
                if (value is not null)
                {
                    id = (int)value;
                }
            }
            return id;
        }
    }
}


//ValueTask<bool> DeleteAsync(TEntity entity, CancellationToken cancellation = default);
//ValueTask<List<TEntity>> GetAllAsync(CancellationToken cancellation = default);
//ValueTask<TEntity?> GetAsync(int id, CancellationToken cancellation = default);
//ValueTask<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellation = default);
//ValueTask<List<TEntity>> GetPaging(int pageIndex, int pageSize, CancellationToken cancellation = default(CancellationToken));
//ValueTask<List<TEntity>> FindNamePaging(string name, int pageIndex, int pageSize, CancellationToken cancellation = default(CancellationToken));
//ValueTask<int> GetCountAsync(CancellationToken cancellation = default(CancellationToken));