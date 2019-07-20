using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Compute.Models
{
    public class ListFlavorsResponse
    {
        [JsonProperty("flavors")]
        public List<Flavor> Flavors { get; set; }
    }
}
