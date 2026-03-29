//HintName: G.Models.CreateCollection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operation for creating new collection and (optionally) specify index params
    /// </summary>
    public sealed partial class CreateCollection
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
        /// For auto sharding: Number of shards in collection. - Default is 1 for standalone, otherwise equal to the number of nodes - Minimum is 1<br/>
        /// For custom sharding: Number of shards in collection per shard group. - Default is 1, meaning that each shard key will be mapped to a single shard - Minimum is 1<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_number")]
        public int? ShardNumber { get; set; }

        /// <summary>
        /// Sharding method Default is Auto - points are distributed across all available shards Custom - points are distributed across shards according to shard key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharding_method")]
        public global::G.ShardingMethod? ShardingMethod { get; set; }

        /// <summary>
        /// Number of shards replicas. Default is 1 Minimum is 1<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replication_factor")]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Defines how many replicas should apply the operation for us to consider it successful. Increasing this number will make the collection more resilient to inconsistencies, but will also make it fail if not enough replicas are available. Does not have any performance impact.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_consistency_factor")]
        public int? WriteConsistencyFactor { get; set; }

        /// <summary>
        /// If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.<br/>
        /// Default: true<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk_payload")]
        public bool? OnDiskPayload { get; set; }

        /// <summary>
        /// Custom params for HNSW index. If none - values from service configuration file are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw_config")]
        public global::G.HnswConfigDiff? HnswConfig { get; set; }

        /// <summary>
        /// Custom params for WAL. If none - values from service configuration file are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_config")]
        public global::G.WalConfigDiff? WalConfig { get; set; }

        /// <summary>
        /// Custom params for Optimizers.  If none - values from service configuration file are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizers_config")]
        public global::G.OptimizersConfigDiff? OptimizersConfig { get; set; }

        /// <summary>
        /// Quantization parameters. If none - quantization is disabled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization_config")]
        public global::G.QuantizationConfig? QuantizationConfig { get; set; }

        /// <summary>
        /// Sparse vector data config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_vectors")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? SparseVectors { get; set; }

        /// <summary>
        /// Strict-mode config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_config")]
        public global::G.StrictModeConfig? StrictModeConfig { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata for the collection This can be used to store application-specific information such as creation time, migration data, inference model info, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Payload? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollection" /> class.
        /// </summary>
        /// <param name="vectors">
        /// Vector params separator for single and multiple vector modes Single mode:<br/>
        /// { "size": 128, "distance": "Cosine" }<br/>
        /// or multiple mode:<br/>
        /// { "default": { "size": 128, "distance": "Cosine" } }
        /// </param>
        /// <param name="shardNumber">
        /// For auto sharding: Number of shards in collection. - Default is 1 for standalone, otherwise equal to the number of nodes - Minimum is 1<br/>
        /// For custom sharding: Number of shards in collection per shard group. - Default is 1, meaning that each shard key will be mapped to a single shard - Minimum is 1<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="shardingMethod">
        /// Sharding method Default is Auto - points are distributed across all available shards Custom - points are distributed across shards according to shard key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="replicationFactor">
        /// Number of shards replicas. Default is 1 Minimum is 1<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="writeConsistencyFactor">
        /// Defines how many replicas should apply the operation for us to consider it successful. Increasing this number will make the collection more resilient to inconsistencies, but will also make it fail if not enough replicas are available. Does not have any performance impact.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="onDiskPayload">
        /// If true - point's payload will not be stored in memory. It will be read from the disk every time it is requested. This setting saves RAM by (slightly) increasing the response time. Note: those payload values that are involved in filtering and are indexed - remain in RAM.<br/>
        /// Default: true<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hnswConfig">
        /// Custom params for HNSW index. If none - values from service configuration file are used.
        /// </param>
        /// <param name="walConfig">
        /// Custom params for WAL. If none - values from service configuration file are used.
        /// </param>
        /// <param name="optimizersConfig">
        /// Custom params for Optimizers.  If none - values from service configuration file are used.
        /// </param>
        /// <param name="quantizationConfig">
        /// Quantization parameters. If none - quantization is disabled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sparseVectors">
        /// Sparse vector data config.
        /// </param>
        /// <param name="strictModeConfig">
        /// Strict-mode config.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata for the collection This can be used to store application-specific information such as creation time, migration data, inference model info, etc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollection(
            global::G.VectorsConfig? vectors,
            int? shardNumber,
            global::G.ShardingMethod? shardingMethod,
            int? replicationFactor,
            int? writeConsistencyFactor,
            bool? onDiskPayload,
            global::G.HnswConfigDiff? hnswConfig,
            global::G.WalConfigDiff? walConfig,
            global::G.OptimizersConfigDiff? optimizersConfig,
            global::G.QuantizationConfig? quantizationConfig,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? sparseVectors,
            global::G.StrictModeConfig? strictModeConfig,
            global::G.Payload? metadata)
        {
            this.Vectors = vectors;
            this.ShardNumber = shardNumber;
            this.ShardingMethod = shardingMethod;
            this.ReplicationFactor = replicationFactor;
            this.WriteConsistencyFactor = writeConsistencyFactor;
            this.OnDiskPayload = onDiskPayload;
            this.HnswConfig = hnswConfig;
            this.WalConfig = walConfig;
            this.OptimizersConfig = optimizersConfig;
            this.QuantizationConfig = quantizationConfig;
            this.SparseVectors = sparseVectors;
            this.StrictModeConfig = strictModeConfig;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollection" /> class.
        /// </summary>
        public CreateCollection()
        {
        }
    }
}