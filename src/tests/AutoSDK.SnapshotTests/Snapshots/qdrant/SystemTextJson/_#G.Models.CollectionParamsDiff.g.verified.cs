//HintName: G.Models.CollectionParamsDiff.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionParamsDiff
    {
        /// <summary>
        /// Number of replicas for each shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replication_factor")]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Minimal number successful responses from replicas to consider operation successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_consistency_factor")]
        public int? WriteConsistencyFactor { get; set; }

        /// <summary>
        /// Fan-out every read request to these many additional remote nodes (and return first available response)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_fan_out_factor")]
        public int? ReadFanOutFactor { get; set; }

        /// <summary>
        /// Delay in milliseconds before sending read requests to remote nodes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_fan_out_delay_ms")]
        public int? ReadFanOutDelayMs { get; set; }

        /// <summary>
        /// If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk_payload")]
        public bool? OnDiskPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionParamsDiff" /> class.
        /// </summary>
        /// <param name="replicationFactor">
        /// Number of replicas for each shard
        /// </param>
        /// <param name="writeConsistencyFactor">
        /// Minimal number successful responses from replicas to consider operation successful
        /// </param>
        /// <param name="readFanOutFactor">
        /// Fan-out every read request to these many additional remote nodes (and return first available response)
        /// </param>
        /// <param name="readFanOutDelayMs">
        /// Delay in milliseconds before sending read requests to remote nodes
        /// </param>
        /// <param name="onDiskPayload">
        /// If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionParamsDiff(
            int? replicationFactor,
            int? writeConsistencyFactor,
            int? readFanOutFactor,
            int? readFanOutDelayMs,
            bool? onDiskPayload)
        {
            this.ReplicationFactor = replicationFactor;
            this.WriteConsistencyFactor = writeConsistencyFactor;
            this.ReadFanOutFactor = readFanOutFactor;
            this.ReadFanOutDelayMs = readFanOutDelayMs;
            this.OnDiskPayload = onDiskPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionParamsDiff" /> class.
        /// </summary>
        public CollectionParamsDiff()
        {
        }
    }
}