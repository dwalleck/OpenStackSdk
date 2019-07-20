using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Compute.Models
{
    public class InstanceFault
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("created")]
        public DateTime CreatedAt { get; set; }
    }
}
