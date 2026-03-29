//HintName: G.Models.CollectionParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionParams
    {
        /// <summary>
        /// Vector params separator for single and multiple vector modes Single mode:<br/>
        /// { "size": 128, "distance": "Cosine" }<br/>
        /// or multiple mode:<br/>
        /// { "default": { "size": 128, "distance": "Cosine" } }
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorsConfigJsonConverter))]
        public global::G.VectorsConfig? Vectors { get; set; }

        /// <summary>
        /// Number of shards the collection has<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_number")]
        public int? ShardNumber { get; set; }

        /// <summary>
        /// Sharding method Default is Auto - points are distributed across all available shards Custom - points are distributed across shards according to shard key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharding_method")]
        public global::G.ShardingMethod? ShardingMethod { get; set; }

        /// <summary>
        /// Number of replicas for each shard<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replication_factor")]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Defines how many replicas should apply the operation for us to consider it successful. Increasing this number will make the collection more resilient to inconsistencies, but will also make it fail if not enough replicas are available. Does not have any performance impact.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_consistency_factor")]
        public int? WriteConsistencyFactor { get; set; }

        /// <summary>
        /// Defines how many additional replicas should be processing read request at the same time. Default value is Auto, which means that fan-out will be determined automatically based on the busyness of the local replica. Having more than 0 might be useful to smooth latency spikes of individual nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_fan_out_factor")]
        public int? ReadFanOutFactor { get; set; }

        /// <summary>
        /// Define number of milliseconds to wait before attempting to read from another replica. This setting can help to reduce latency spikes in case of occasional slow replicas. Default is 0, which means delayed fan out request is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_fan_out_delay_ms")]
        public int? ReadFanOutDelayMs { get; set; }

        /// <summary>
        /// If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.<br/>
        /// Default: true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk_payload")]
        public bool? OnDiskPayload { get; set; }

        /// <summary>
        /// Configuration of the sparse vector storage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_vectors")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? SparseVectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionParams" /> class.
        /// </summary>
        /// <param name="vectors">
        /// Vector params separator for single and multiple vector modes Single mode:<br/>
        /// { "size": 128, "distance": "Cosine" }<br/>
        /// or multiple mode:<br/>
        /// { "default": { "size": 128, "distance": "Cosine" } }
        /// </param>
        /// <param name="shardNumber">
        /// Number of shards the collection has<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="shardingMethod">
        /// Sharding method Default is Auto - points are distributed across all available shards Custom - points are distributed across shards according to shard key
        /// </param>
        /// <param name="replicationFactor">
        /// Number of replicas for each shard<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="writeConsistencyFactor">
        /// Defines how many replicas should apply the operation for us to consider it successful. Increasing this number will make the collection more resilient to inconsistencies, but will also make it fail if not enough replicas are available. Does not have any performance impact.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="readFanOutFactor">
        /// Defines how many additional replicas should be processing read request at the same time. Default value is Auto, which means that fan-out will be determined automatically based on the busyness of the local replica. Having more than 0 might be useful to smooth latency spikes of individual nodes.
        /// </param>
        /// <param name="readFanOutDelayMs">
        /// Define number of milliseconds to wait before attempting to read from another replica. This setting can help to reduce latency spikes in case of occasional slow replicas. Default is 0, which means delayed fan out request is disabled.
        /// </param>
        /// <param name="onDiskPayload">
        /// If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.<br/>
        /// Default: true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sparseVectors">
        /// Configuration of the sparse vector storage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionParams(
            global::G.VectorsConfig? vectors,
            int? shardNumber,
            global::G.ShardingMethod? shardingMethod,
            int? replicationFactor,
            int? writeConsistencyFactor,
            int? readFanOutFactor,
            int? readFanOutDelayMs,
            bool? onDiskPayload,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? sparseVectors)
        {
            this.Vectors = vectors;
            this.ShardNumber = shardNumber;
            this.ShardingMethod = shardingMethod;
            this.ReplicationFactor = replicationFactor;
            this.WriteConsistencyFactor = writeConsistencyFactor;
            this.ReadFanOutFactor = readFanOutFactor;
            this.ReadFanOutDelayMs = readFanOutDelayMs;
            this.OnDiskPayload = onDiskPayload;
            this.SparseVectors = sparseVectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionParams" /> class.
        /// </summary>
        public CollectionParams()
        {
        }
    }
}