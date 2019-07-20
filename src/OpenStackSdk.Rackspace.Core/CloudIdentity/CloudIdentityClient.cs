using Newtonsoft.Json;
using OpenStackSdk.Rackspace.Core.CloudIdentity.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenStackSdk.Rackspace.Core.CloudIdentity
{
    public class CloudIdentityClient
    {
        public HttpClient Client { get; set; }
        public string BaseUrl { get; set; }

        public CloudIdentityClient(string baseUrl)
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("Accept", "application/json");
            BaseUrl = baseUrl;
        }

        public async Task<Access> Authenticate(string username, string apiKey, string tenantName)
        {
            AuthRequest r = new AuthRequest(username, apiKey, tenantName);
            var content = JsonConvert.SerializeObject(r);
            var req = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Client.PostAsync(BaseUrl + "/v2.0/tokens", req);
            var resp = await response.Content.ReadAsStringAsync();
            RootObject root = JsonConvert.DeserializeObject<RootObject>(resp);
            return root.Access;
        }
    }
}
