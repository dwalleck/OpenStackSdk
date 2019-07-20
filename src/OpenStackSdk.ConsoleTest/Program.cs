using OpenStackSdk.Rackspace.Core.CloudIdentity;
using OpenStackSdk.Core.Compute;
using System;

namespace OpenStackSdk.ConsoleTest
{
    static class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var identityClient = new CloudIdentityClient("https://identity.api.rackspacecloud.com");
            var tokenResponse = await identityClient.Authenticate();
            var computeEndpoint = tokenResponse.GetEndpoint("cloudServersOpenStack", "IAD");
            var computeClient = new ComputeClient(computeEndpoint.PublicUrl, tokenResponse.Token.Id);
            var servers = await computeClient.ListServersAsync();
            var flavors = await computeClient.ListFlavorsDetailedAsync();
            Console.WriteLine("Hello World!");
        }
    }
}
