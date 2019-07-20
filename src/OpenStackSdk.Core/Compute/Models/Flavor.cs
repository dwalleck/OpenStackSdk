using Newtonsoft.Json;
using OpenStackSdk.Core.Common;
using System.Collections.Generic;

namespace OpenStackSdk.Core.Compute.Models
{
    public class Flavor
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("disk")]
        public int Disk { get; set; }

        [JsonProperty("ram")]
        public int Ram { get; set; }

        [JsonProperty("vcpus")]
        public int VCPUs { get; set; }

        [JsonProperty("OS-FLV-EXT-DATA:ephemeral")]
        public int EphemeralDisk { get; set; }
    }
}
