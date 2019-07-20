using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Compute.Models
{
    public class Addresses
    {
        [JsonProperty("public")]
        public List<Address> PublicAddresses { get; set; }

        [JsonProperty("private")]
        public List<Address> PrivateAddresses { get; set; }
    }
}
