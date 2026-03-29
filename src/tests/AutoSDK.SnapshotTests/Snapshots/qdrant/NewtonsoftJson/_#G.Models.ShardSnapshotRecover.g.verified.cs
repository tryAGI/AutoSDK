//HintName: G.Models.ShardSnapshotRecover.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardSnapshotRecover
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardSnapshotLocation Location { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public global::G.SnapshotPriority? Priority { get; set; }

        /// <summary>
        /// Optional SHA256 checksum to verify snapshot integrity before recovery.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checksum")]
        public string? Checksum { get; set; }

        /// <summary>
        /// Optional API key used when fetching the snapshot from a remote URL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardSnapshotRecover" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="priority">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="checksum">
        /// Optional SHA256 checksum to verify snapshot integrity before recovery.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiKey">
        /// Optional API key used when fetching the snapshot from a remote URL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public ShardSnapshotRecover(
            global::G.ShardSnapshotLocation location,
            global::G.SnapshotPriority? priority,
            string? checksum,
            string? apiKey)
        {
            this.Location = location;
            this.Priority = priority;
            this.Checksum = checksum;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardSnapshotRecover" /> class.
        /// </summary>
        public ShardSnapshotRecover()
        {
        }
    }
}