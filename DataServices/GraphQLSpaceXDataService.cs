using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class GraphQLSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpclient;

        public GraphQLSpaceXDataService(HttpClient client)
        {
            _httpclient = client;
        }

        public async Task<LaunchDto[]> GetAllLaunches()
        {
            var queryObject = new
            {
                query = "@{launches { id is_tentative mission_name launch_date_local}}",
                variables = new { }
            };

            StringContent launchQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = await _httpclient.PostAsync("graphql", launchQuery);

            if(response.IsSuccessStatusCode)
            {
                var gqlData = await JsonSerializer.Deserialize<GqlData>
                    (await response.Content.ReadAsStreamAsync());
            }
            return null;
        }
    }
}