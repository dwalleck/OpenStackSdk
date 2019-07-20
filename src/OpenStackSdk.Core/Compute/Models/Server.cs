using Newtonsoft.Json;
using OpenStackSdk.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Compute.Models
{
    public class Server
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("hostId")]
        public string HostId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("accessIPv4")]
        public string AccessIPv4 { get; set; }

        [JsonProperty("accessIPv6")]
        public string AccessIPv6 { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("flavor")]
        public Flavor Flavor { get; set; }

        [JsonProperty("addresses")]
        public Addresses Addresses { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("key_name")]
        public string KeyName { get; set; }

        [JsonProperty("OS-EXT-STS:task_state")]
        public string TaskState { get; set; }

        [JsonProperty("OS-EXT-STS:vm_state")]
        public string VmState { get; set; }

        [JsonProperty("OS-EXT-AZ:availability_zone")]
        public string AvailabilityZone { get; set; }

        [JsonProperty("OS-EXT-STS:power_state")]
        public int PowerState { get; set; }

        [JsonProperty("OS-DCF:diskConfig")]
        public string DiskConfig { get; set; }

        [JsonProperty("config_drive")]
        public string ConfigDrive { get; set; }

        [JsonProperty("OS-SRV-USG:terminated_at")]
        public DateTime? TerminatedAt { get; set; }

        [JsonProperty("OS-SRV-USG:launched_at")]
        public string LaunchedAt { get; set; }

        [JsonProperty("fault")]
        public InstanceFault Fault { get; set; }

    }
}
