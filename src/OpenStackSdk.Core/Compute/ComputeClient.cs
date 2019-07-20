using Newtonsoft.Json;
using OpenStackSdk.Core.Compute.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenStackSdk.Core.Compute
{
    public class ComputeClient
    {
        public HttpClient Client { get; set; }
        public string BaseUrl { get; set; }
        public JsonSerializer Serializer { get; set; }

        public ComputeClient(string baseUrl, string token)
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("Accept", "application/json");
            Client.DefaultRequestHeaders.Add("X-Auth-Token", token);
            BaseUrl = baseUrl;
        }

        public async Task<ListServersResponse> ListServersAsync()
        {
            var response = await Client.GetAsync($"{BaseUrl}/servers");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var serversResponse = JsonConvert.DeserializeObject<ListServersResponse>(responseBody);
            return serversResponse;
        }

        public async Task<ListFlavorsResponse> ListFlavorsAsync()
        {
            var response = await Client.GetAsync($"{BaseUrl}/flavors");
            var responseBody = await response.Content.ReadAsStringAsync();
            var flavorsResponse = JsonConvert.DeserializeObject<ListFlavorsResponse>(responseBody);
            return flavorsResponse;
        }

        public async Task<ListFlavorsResponse> ListFlavorsDetailedAsync()
        {
            var response = await Client.GetAsync($"{BaseUrl}/flavors/detail");
            var responseBody = await response.Content.ReadAsStringAsync();
            var flavorsResponse = JsonConvert.DeserializeObject<ListFlavorsResponse>(responseBody);
            return flavorsResponse;
        }
    }
}
