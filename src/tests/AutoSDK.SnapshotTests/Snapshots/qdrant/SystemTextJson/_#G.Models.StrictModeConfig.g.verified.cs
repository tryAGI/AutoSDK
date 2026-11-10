//HintName: G.Models.StrictModeConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StrictModeConfig
    {
        /// <summary>
        /// Whether strict mode is enabled for a collection or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Max allowed `limit` parameter for all APIs that don't have their own max limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_query_limit")]
        public long? MaxQueryLimit { get; set; }

        /// <summary>
        /// Max allowed `timeout` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_timeout")]
        public long? MaxTimeout { get; set; }

        /// <summary>
        /// Allow usage of unindexed fields in retrieval based (e.g. search) filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unindexed_filtering_retrieve")]
        public bool? UnindexedFilteringRetrieve { get; set; }

        /// <summary>
        /// Allow usage of unindexed fields in filtered updates (e.g. delete by payload).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unindexed_filtering_update")]
        public bool? UnindexedFilteringUpdate { get; set; }

        /// <summary>
        /// Max HNSW ef value allowed in search parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_max_hnsw_ef")]
        public long? SearchMaxHnswEf { get; set; }

        /// <summary>
        /// Whether exact search is allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_allow_exact")]
        public bool? SearchAllowExact { get; set; }

        /// <summary>
        /// Max oversampling value allowed in search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_max_oversampling")]
        public double? SearchMaxOversampling { get; set; }

        /// <summary>
        /// Max batchsize when upserting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upsert_max_batchsize")]
        public long? UpsertMaxBatchsize { get; set; }

        /// <summary>
        /// Max batchsize when searching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_max_batchsize")]
        public long? SearchMaxBatchsize { get; set; }

        /// <summary>
        /// Max size of a collections vector storage in bytes, ignoring replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_collection_vector_size_bytes")]
        public long? MaxCollectionVectorSizeBytes { get; set; }

        /// <summary>
        /// Max number of read operations per minute per replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_rate_limit")]
        public long? ReadRateLimit { get; set; }

        /// <summary>
        /// Max number of write operations per minute per replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_rate_limit")]
        public long? WriteRateLimit { get; set; }

        /// <summary>
        /// Max size of a collections payload storage in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_collection_payload_size_bytes")]
        public long? MaxCollectionPayloadSizeBytes { get; set; }

        /// <summary>
        /// Max number of points estimated in a collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_points_count")]
        public long? MaxPointsCount { get; set; }

        /// <summary>
        /// Max conditions a filter can have.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_max_conditions")]
        public long? FilterMaxConditions { get; set; }

        /// <summary>
        /// Max size of a condition, eg. items in `MatchAny`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_max_size")]
        public long? ConditionMaxSize { get; set; }

        /// <summary>
        /// Multivector strict mode configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivector_config")]
        public global::System.Collections.Generic.Dictionary<string, global::G.StrictModeMultivector>? MultivectorConfig { get; set; }

        /// <summary>
        /// Sparse vector strict mode configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_config")]
        public global::System.Collections.Generic.Dictionary<string, global::G.StrictModeSparse>? SparseConfig { get; set; }

        /// <summary>
        /// Max number of payload indexes in a collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_payload_index_count")]
        public long? MaxPayloadIndexCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether strict mode is enabled for a collection or not.
        /// </param>
        /// <param name="maxQueryLimit">
        /// Max allowed `limit` parameter for all APIs that don't have their own max limit.
        /// </param>
        /// <param name="maxTimeout">
        /// Max allowed `timeout` parameter.
        /// </param>
        /// <param name="unindexedFilteringRetrieve">
        /// Allow usage of unindexed fields in retrieval based (e.g. search) filters.
        /// </param>
        /// <param name="unindexedFilteringUpdate">
        /// Allow usage of unindexed fields in filtered updates (e.g. delete by payload).
        /// </param>
        /// <param name="searchMaxHnswEf">
        /// Max HNSW ef value allowed in search parameters.
        /// </param>
        /// <param name="searchAllowExact">
        /// Whether exact search is allowed.
        /// </param>
        /// <param name="searchMaxOversampling">
        /// Max oversampling value allowed in search.
        /// </param>
        /// <param name="upsertMaxBatchsize">
        /// Max batchsize when upserting
        /// </param>
        /// <param name="searchMaxBatchsize">
        /// Max batchsize when searching
        /// </param>
        /// <param name="maxCollectionVectorSizeBytes">
        /// Max size of a collections vector storage in bytes, ignoring replicas.
        /// </param>
        /// <param name="readRateLimit">
        /// Max number of read operations per minute per replica
        /// </param>
        /// <param name="writeRateLimit">
        /// Max number of write operations per minute per replica
        /// </param>
        /// <param name="maxCollectionPayloadSizeBytes">
        /// Max size of a collections payload storage in bytes
        /// </param>
        /// <param name="maxPointsCount">
        /// Max number of points estimated in a collection
        /// </param>
        /// <param name="filterMaxConditions">
        /// Max conditions a filter can have.
        /// </param>
        /// <param name="conditionMaxSize">
        /// Max size of a condition, eg. items in `MatchAny`.
        /// </param>
        /// <param name="multivectorConfig">
        /// Multivector strict mode configuration
        /// </param>
        /// <param name="sparseConfig">
        /// Sparse vector strict mode configuration
        /// </param>
        /// <param name="maxPayloadIndexCount">
        /// Max number of payload indexes in a collection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrictModeConfig(
            bool? enabled,
            long? maxQueryLimit,
            long? maxTimeout,
            bool? unindexedFilteringRetrieve,
            bool? unindexedFilteringUpdate,
            long? searchMaxHnswEf,
            bool? searchAllowExact,
            double? searchMaxOversampling,
            long? upsertMaxBatchsize,
            long? searchMaxBatchsize,
            long? maxCollectionVectorSizeBytes,
            long? readRateLimit,
            long? writeRateLimit,
            long? maxCollectionPayloadSizeBytes,
            long? maxPointsCount,
            long? filterMaxConditions,
            long? conditionMaxSize,
            global::System.Collections.Generic.Dictionary<string, global::G.StrictModeMultivector>? multivectorConfig,
            global::System.Collections.Generic.Dictionary<string, global::G.StrictModeSparse>? sparseConfig,
            long? maxPayloadIndexCount)
        {
            this.Enabled = enabled;
            this.MaxQueryLimit = maxQueryLimit;
            this.MaxTimeout = maxTimeout;
            this.UnindexedFilteringRetrieve = unindexedFilteringRetrieve;
            this.UnindexedFilteringUpdate = unindexedFilteringUpdate;
            this.SearchMaxHnswEf = searchMaxHnswEf;
            this.SearchAllowExact = searchAllowExact;
            this.SearchMaxOversampling = searchMaxOversampling;
            this.UpsertMaxBatchsize = upsertMaxBatchsize;
            this.SearchMaxBatchsize = searchMaxBatchsize;
            this.MaxCollectionVectorSizeBytes = maxCollectionVectorSizeBytes;
            this.ReadRateLimit = readRateLimit;
            this.WriteRateLimit = writeRateLimit;
            this.MaxCollectionPayloadSizeBytes = maxCollectionPayloadSizeBytes;
            this.MaxPointsCount = maxPointsCount;
            this.FilterMaxConditions = filterMaxConditions;
            this.ConditionMaxSize = conditionMaxSize;
            this.MultivectorConfig = multivectorConfig;
            this.SparseConfig = sparseConfig;
            this.MaxPayloadIndexCount = maxPayloadIndexCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeConfig" /> class.
        /// </summary>
        public StrictModeConfig()
        {
        }

    }
}