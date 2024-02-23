using System.Text.Json;

namespace BasketballApp.Repositories
{
    public static class ApiHelper
    {
        public static async Task<T> ReadContentAsync<T>(this HttpResponseMessage response, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (response.IsSuccessStatusCode == false)
                throw new ApplicationException($"Something went wrong calling the API: " + response.ReasonPhrase);

            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            var result = JsonSerializer.Deserialize<T>(
                dataAsString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            if (result is null)
                throw new ApplicationException($"Something went wrong calling the API");

            return result;
        }
    }
}

