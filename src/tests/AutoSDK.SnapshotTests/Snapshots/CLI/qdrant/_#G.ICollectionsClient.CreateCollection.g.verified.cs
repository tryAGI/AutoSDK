//HintName: G.ICollectionsClient.CreateCollection.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Create collection<br/>
        /// Create new collection with given parameters
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCollectionResponse> CreateCollectionAsync(
            string collectionName,

            global::G.CreateCollection request,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create collection<br/>
        /// Create new collection with given parameters
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateCollectionResponse> CreateCollectionAsync(
            string collectionName,
            int? timeout = default,
            global::G.VectorsConfig? vectors = default,
            int? shardNumber = default,
            global::G.ShardingMethod? shardingMethod = default,
            int? replicationFactor = default,
            int? writeConsistencyFactor = default,
            bool? onDiskPayload = default,
            global::G.HnswConfigDiff? hnswConfig = default,
            global::G.WalConfigDiff? walConfig = default,
            global::G.OptimizersConfigDiff? optimizersConfig = default,
            global::G.QuantizationConfig? quantizationConfig = default,
            global::System.Collections.Generic.Dictionary<string, global::G.SparseVectorParams>? sparseVectors = default,
            global::G.StrictModeConfig? strictModeConfig = default,
            global::G.Payload? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}