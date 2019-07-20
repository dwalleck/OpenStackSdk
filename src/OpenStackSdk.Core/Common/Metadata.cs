using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStackSdk.Core.Common
{
    public class Metadata : Dictionary<string, string> { }

    public class MetadataTransaction
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        public MetadataTransaction() { }

        public MetadataTransaction(Metadata metadata)
        {
            Metadata = metadata;
        }
    }

    public class MetadataItemTransaction
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        public MetadataItemTransaction() { }

        public MetadataItemTransaction(Metadata metadata)
        {
            Meta = metadata;
        }
    }
}
