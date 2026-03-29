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
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShardSnapshotLocationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShardSnapshotLocation Location { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::G.SnapshotPriority? Priority { get; set; }

        /// <summary>
        /// Optional SHA256 checksum to verify snapshot integrity before recovery.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksum")]
        public string? Checksum { get; set; }

        /// <summary>
        /// Optional API key used when fetching the snapshot from a remote URL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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