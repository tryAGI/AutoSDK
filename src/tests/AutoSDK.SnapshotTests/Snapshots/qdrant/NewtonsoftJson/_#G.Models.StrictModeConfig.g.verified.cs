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
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Max allowed `limit` parameter for all APIs that don't have their own max limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_query_limit")]
        public int? MaxQueryLimit { get; set; }

        /// <summary>
        /// Max allowed `timeout` parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_timeout")]
        public int? MaxTimeout { get; set; }

        /// <summary>
        /// Allow usage of unindexed fields in retrieval based (e.g. search) filters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unindexed_filtering_retrieve")]
        public bool? UnindexedFilteringRetrieve { get; set; }

        /// <summary>
        /// Allow usage of unindexed fields in filtered updates (e.g. delete by payload).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unindexed_filtering_update")]
        public bool? UnindexedFilteringUpdate { get; set; }

        /// <summary>
        /// Max HNSW ef value allowed in search parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_max_hnsw_ef")]
        public int? SearchMaxHnswEf { get; set; }

        /// <summary>
        /// Whether exact search is allowed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_allow_exact")]
        public bool? SearchAllowExact { get; set; }

        /// <summary>
        /// Max oversampling value allowed in search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_max_oversampling")]
        public double? SearchMaxOversampling { get; set; }

        /// <summary>
        /// Max batchsize when upserting
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upsert_max_batchsize")]
        public int? UpsertMaxBatchsize { get; set; }

        /// <summary>
        /// Max batchsize when searching
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_max_batchsize")]
        public int? SearchMaxBatchsize { get; set; }

        /// <summary>
        /// Max size of a collections vector storage in bytes, ignoring replicas.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_collection_vector_size_bytes")]
        public int? MaxCollectionVectorSizeBytes { get; set; }

        /// <summary>
        /// Max number of read operations per minute per replica
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_rate_limit")]
        public int? ReadRateLimit { get; set; }

        /// <summary>
        /// Max number of write operations per minute per replica
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("write_rate_limit")]
        public int? WriteRateLimit { get; set; }

        /// <summary>
        /// Max size of a collections payload storage in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_collection_payload_size_bytes")]
        public int? MaxCollectionPayloadSizeBytes { get; set; }

        /// <summary>
        /// Max number of points estimated in a collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_points_count")]
        public int? MaxPointsCount { get; set; }

        /// <summary>
        /// Max conditions a filter can have.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_max_conditions")]
        public int? FilterMaxConditions { get; set; }

        /// <summary>
        /// Max size of a condition, eg. items in `MatchAny`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition_max_size")]
        public int? ConditionMaxSize { get; set; }

        /// <summary>
        /// Multivector strict mode configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multivector_config")]
        public global::System.Collections.Generic.Dictionary<string, global::G.StrictModeMultivector>? MultivectorConfig { get; set; }

        /// <summary>
        /// Sparse vector strict mode configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sparse_config")]
        public global::System.Collections.Generic.Dictionary<string, global::G.StrictModeSparse>? SparseConfig { get; set; }

        /// <summary>
        /// Max number of payload indexes in a collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_payload_index_count")]
        public int? MaxPayloadIndexCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public StrictModeConfig(
            bool? enabled,
            int? maxQueryLimit,
            int? maxTimeout,
            bool? unindexedFilteringRetrieve,
            bool? unindexedFilteringUpdate,
            int? searchMaxHnswEf,
            bool? searchAllowExact,
            double? searchMaxOversampling,
            int? upsertMaxBatchsize,
            int? searchMaxBatchsize,
            int? maxCollectionVectorSizeBytes,
            int? readRateLimit,
            int? writeRateLimit,
            int? maxCollectionPayloadSizeBytes,
            int? maxPointsCount,
            int? filterMaxConditions,
            int? conditionMaxSize,
            global::System.Collections.Generic.Dictionary<string, global::G.StrictModeMultivector>? multivectorConfig,
            global::System.Collections.Generic.Dictionary<string, global::G.StrictModeSparse>? sparseConfig,
            int? maxPayloadIndexCount)
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