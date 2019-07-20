using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Compute.Models
{
    public class Address
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("addr")]
        public string IpAddress { get; set; }

        [JsonProperty("OS-EXT-IPS-MAC:mac_addr")]
        public string MacAddress { get; set; }

        [JsonProperty("OS-EXT-IPS:type")]
        public string AddressType { get; set; }
    }
}
