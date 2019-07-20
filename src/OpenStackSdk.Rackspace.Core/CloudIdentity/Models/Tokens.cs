using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStackSdk.Rackspace.Core.CloudIdentity.Models
{
    public class AuthRequest
    {
        [JsonProperty("auth")]
        public Auth Auth { get; set; }

        public AuthRequest(string username, string apiKey, string tenantId)
        {
            Auth = new Auth(username, apiKey, tenantId);
        }
    }

    public class Auth
    {
        [JsonProperty("RAX-KSKEY:apiKeyCredentials")]
        public ApiKeyCredentials ApiKeyCredentials { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        public Auth(string username, string apiKey, string tenantId)
        {
            this.ApiKeyCredentials = new ApiKeyCredentials(username, apiKey);
            this.TenantId = tenantId;
        }
    }

    public class ApiKeyCredentials
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        public ApiKeyCredentials(string username, string apiKey)
        {
            this.Username = username;
            this.ApiKey = apiKey;
        }
    }

    public class Tenant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Token
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("tenant")]
        public Tenant Tenant { get; set; }
    }

    public class Role
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantName")]
        public string TenantId { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }

        [JsonProperty("roles_links")]
        public List<object> RolesLinks { get; set; }
    }

    public class Endpoint
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("publicURL")]
        public string PublicUrl { get; set; }

        [JsonProperty("internalURL")]
        public string InternalUrl { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("versionId")]
        public string versionId { get; set; }

        [JsonProperty("versionInfo")]
        public string VersionInfo { get; set; }

        [JsonProperty("versionList")]
        public string VersionList { get; set; }
    }

    public class ServiceCatalog
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("endpoints")]
        public List<Endpoint> Endpoints { get; set; }

        [JsonProperty("endpoints_links")]
        public List<object> EndpointLinks { get; set; }
    }

    public class Access
    {
        [JsonProperty("token")]
        public Token Token { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("serviceCatalog")]
        public List<ServiceCatalog> ServiceCatalog { get; set; }

        public Endpoint GetEndpoint(string name, string region)
        {
            var service = ServiceCatalog.Where(c => c.Name == name).FirstOrDefault();
            var endpoint = service.Endpoints.Where(s => s.Region == region).FirstOrDefault();
            return endpoint;
        }
    }

    public class RootObject
    {
        [JsonProperty("access")]
        public Access Access { get; set; }
    }
}
