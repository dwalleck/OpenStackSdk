using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Compute.Models
{
    public class ListServersResponse
    {
        [JsonProperty("servers")]
        public List<Server> Servers { get; set; }
    }
}
