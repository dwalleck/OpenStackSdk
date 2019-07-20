using Newtonsoft.Json;
using OpenStackSdk.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Compute.Models
{
    public class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public List<Link> links { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("OS-DCF:diskConfig")]
        public string DiskConfig { get; set; }

        [JsonProperty("OS-EXT-IMG-SIZE:size")]
        public long Size { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("minDisk")]
        public int MinDisk { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("minRam")]
        public int MinRam { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }
}
