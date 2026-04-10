//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API description for Qdrant vector search engine.<br/>
    /// This document describes CRUD and search operations on collections of points (vectors with payload).<br/>
    /// Qdrant supports any combinations of `should`, `min_should`, `must` and `must_not` conditions, which makes it possible to use in applications when object could not be described solely by vector. It could be location features, availability flags, and other custom properties businesses should take into account.<br/>
    /// ## Examples<br/>
    /// This examples cover the most basic use-cases - collection creation and basic vector search.<br/>
    /// ### Create collection<br/>
    /// First - let's create a collection with dot-production metric.<br/>
    /// ```<br/>
    /// curl -X PUT 'http://localhost:6333/collections/test_collection' \<br/>
    ///   -H 'Content-Type: application/json' \<br/>
    ///   --data-raw '{<br/>
    ///     "vectors": {<br/>
    ///       "size": 4,<br/>
    ///       "distance": "Dot"<br/>
    ///     }<br/>
    ///   }'<br/>
    /// ```<br/>
    /// Expected response:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "result": true,<br/>
    ///     "status": "ok",<br/>
    ///     "time": 0.031095451<br/>
    /// }<br/>
    /// ```<br/>
    /// We can ensure that collection was created:<br/>
    /// ```<br/>
    /// curl 'http://localhost:6333/collections/test_collection'<br/>
    /// ```<br/>
    /// Expected response:<br/>
    /// ```<br/>
    /// {<br/>
    ///   "result": {<br/>
    ///     "status": "green",<br/>
    ///     "segments_count": 5,<br/>
    ///     "disk_data_size": 0,<br/>
    ///     "ram_data_size": 0,<br/>
    ///     "config": {<br/>
    ///       "params": {<br/>
    ///         "vectors": {<br/>
    ///           "size": 4,<br/>
    ///           "distance": "Dot"<br/>
    ///         }<br/>
    ///       },<br/>
    ///       "hnsw_config": {<br/>
    ///         "m": 16,<br/>
    ///         "ef_construct": 100,<br/>
    ///         "full_scan_threshold": 10000<br/>
    ///       },<br/>
    ///       "optimizer_config": {<br/>
    ///         "deleted_threshold": 0.2,<br/>
    ///         "vacuum_min_vector_number": 1000,<br/>
    ///         "default_segment_number": 2,<br/>
    ///         "max_segment_size": null,<br/>
    ///         "memmap_threshold": null,<br/>
    ///         "indexing_threshold": 20000,<br/>
    ///         "flush_interval_sec": 5,<br/>
    ///         "max_optimization_threads": null<br/>
    ///       },<br/>
    ///       "wal_config": {<br/>
    ///         "wal_capacity_mb": 32,<br/>
    ///         "wal_segments_ahead": 0<br/>
    ///       }<br/>
    ///     }<br/>
    ///   },<br/>
    ///   "status": "ok",<br/>
    ///   "time": 2.1199e-05<br/>
    /// }<br/>
    /// ```<br/>
    /// ### Add points<br/>
    /// Let's now add vectors with some payload:<br/>
    /// ```<br/>
    /// curl -L -X PUT 'http://localhost:6333/collections/test_collection/points?wait=true' \ -H 'Content-Type: application/json' \ --data-raw '{<br/>
    ///   "points": [<br/>
    ///     {"id": 1, "vector": [0.05, 0.61, 0.76, 0.74], "payload": {"city": "Berlin"}},<br/>
    ///     {"id": 2, "vector": [0.19, 0.81, 0.75, 0.11], "payload": {"city": ["Berlin", "London"] }},<br/>
    ///     {"id": 3, "vector": [0.36, 0.55, 0.47, 0.94], "payload": {"city": ["Berlin", "Moscow"] }},<br/>
    ///     {"id": 4, "vector": [0.18, 0.01, 0.85, 0.80], "payload": {"city": ["London", "Moscow"] }},<br/>
    ///     {"id": 5, "vector": [0.24, 0.18, 0.22, 0.44], "payload": {"count": [0]}},<br/>
    ///     {"id": 6, "vector": [0.35, 0.08, 0.11, 0.44]}<br/>
    ///   ]<br/>
    /// }'<br/>
    /// ```<br/>
    /// Expected response:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "result": {<br/>
    ///         "operation_id": 0,<br/>
    ///         "status": "completed"<br/>
    ///     },<br/>
    ///     "status": "ok",<br/>
    ///     "time": 0.000206061<br/>
    /// }<br/>
    /// ```<br/>
    /// ### Search with filtering<br/>
    /// Let's start with a basic request:<br/>
    /// ```<br/>
    /// curl -L -X POST 'http://localhost:6333/collections/test_collection/points/search' \ -H 'Content-Type: application/json' \ --data-raw '{<br/>
    ///     "vector": [0.2,0.1,0.9,0.7],<br/>
    ///     "top": 3<br/>
    /// }'<br/>
    /// ```<br/>
    /// Expected response:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "result": [<br/>
    ///         { "id": 4, "score": 1.362, "payload": null, "version": 0 },<br/>
    ///         { "id": 1, "score": 1.273, "payload": null, "version": 0 },<br/>
    ///         { "id": 3, "score": 1.208, "payload": null, "version": 0 }<br/>
    ///     ],<br/>
    ///     "status": "ok",<br/>
    ///     "time": 0.000055785<br/>
    /// }<br/>
    /// ```<br/>
    /// But result is different if we add a filter:<br/>
    /// ```<br/>
    /// curl -L -X POST 'http://localhost:6333/collections/test_collection/points/search' \ -H 'Content-Type: application/json' \ --data-raw '{<br/>
    ///     "filter": {<br/>
    ///         "should": [<br/>
    ///             {<br/>
    ///                 "key": "city",<br/>
    ///                 "match": {<br/>
    ///                     "value": "London"<br/>
    ///                 }<br/>
    ///             }<br/>
    ///         ]<br/>
    ///     },<br/>
    ///     "vector": [0.2, 0.1, 0.9, 0.7],<br/>
    ///     "top": 3<br/>
    /// }'<br/>
    /// ```<br/>
    /// Expected response:<br/>
    /// ```<br/>
    /// {<br/>
    ///     "result": [<br/>
    ///         { "id": 4, "score": 1.362, "payload": null, "version": 0 },<br/>
    ///         { "id": 2, "score": 0.871, "payload": null, "version": 0 }<br/>
    ///     ],<br/>
    ///     "status": "ok",<br/>
    ///     "time": 0.000093972<br/>
    /// }<br/>
    /// ```<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "http://localhost:6333/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.CollectionStatusJsonConverter(),
                    new global::G.JsonConverters.CollectionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.OptimizersStatusEnumJsonConverter(),
                    new global::G.JsonConverters.OptimizersStatusEnumNullableJsonConverter(),
                    new global::G.JsonConverters.DistanceJsonConverter(),
                    new global::G.JsonConverters.DistanceNullableJsonConverter(),
                    new global::G.JsonConverters.ScalarTypeJsonConverter(),
                    new global::G.JsonConverters.ScalarTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CompressionRatioJsonConverter(),
                    new global::G.JsonConverters.CompressionRatioNullableJsonConverter(),
                    new global::G.JsonConverters.BinaryQuantizationEncodingJsonConverter(),
                    new global::G.JsonConverters.BinaryQuantizationEncodingNullableJsonConverter(),
                    new global::G.JsonConverters.BinaryQuantizationQueryEncodingJsonConverter(),
                    new global::G.JsonConverters.BinaryQuantizationQueryEncodingNullableJsonConverter(),
                    new global::G.JsonConverters.DatatypeJsonConverter(),
                    new global::G.JsonConverters.DatatypeNullableJsonConverter(),
                    new global::G.JsonConverters.MultiVectorComparatorJsonConverter(),
                    new global::G.JsonConverters.MultiVectorComparatorNullableJsonConverter(),
                    new global::G.JsonConverters.ShardingMethodJsonConverter(),
                    new global::G.JsonConverters.ShardingMethodNullableJsonConverter(),
                    new global::G.JsonConverters.ModifierJsonConverter(),
                    new global::G.JsonConverters.ModifierNullableJsonConverter(),
                    new global::G.JsonConverters.PayloadSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.PayloadSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.KeywordIndexTypeJsonConverter(),
                    new global::G.JsonConverters.KeywordIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.IntegerIndexTypeJsonConverter(),
                    new global::G.JsonConverters.IntegerIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FloatIndexTypeJsonConverter(),
                    new global::G.JsonConverters.FloatIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GeoIndexTypeJsonConverter(),
                    new global::G.JsonConverters.GeoIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextIndexTypeJsonConverter(),
                    new global::G.JsonConverters.TextIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TokenizerTypeJsonConverter(),
                    new global::G.JsonConverters.TokenizerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageJsonConverter(),
                    new global::G.JsonConverters.LanguageNullableJsonConverter(),
                    new global::G.JsonConverters.SnowballLanguageJsonConverter(),
                    new global::G.JsonConverters.SnowballLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.BoolIndexTypeJsonConverter(),
                    new global::G.JsonConverters.BoolIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DatetimeIndexTypeJsonConverter(),
                    new global::G.JsonConverters.DatetimeIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UuidIndexTypeJsonConverter(),
                    new global::G.JsonConverters.UuidIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateStatusJsonConverter(),
                    new global::G.JsonConverters.UpdateStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RecommendStrategyJsonConverter(),
                    new global::G.JsonConverters.RecommendStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.DirectionJsonConverter(),
                    new global::G.JsonConverters.DirectionNullableJsonConverter(),
                    new global::G.JsonConverters.MaxOptimizationThreadsSettingJsonConverter(),
                    new global::G.JsonConverters.MaxOptimizationThreadsSettingNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateModeJsonConverter(),
                    new global::G.JsonConverters.UpdateModeNullableJsonConverter(),
                    new global::G.JsonConverters.ClusterStatusVariant1StatusJsonConverter(),
                    new global::G.JsonConverters.ClusterStatusVariant1StatusNullableJsonConverter(),
                    new global::G.JsonConverters.ClusterStatusVariant2StatusJsonConverter(),
                    new global::G.JsonConverters.ClusterStatusVariant2StatusNullableJsonConverter(),
                    new global::G.JsonConverters.StateRoleJsonConverter(),
                    new global::G.JsonConverters.StateRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConsensusThreadStatusVariant1ConsensusThreadStatusJsonConverter(),
                    new global::G.JsonConverters.ConsensusThreadStatusVariant1ConsensusThreadStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ConsensusThreadStatusVariant2ConsensusThreadStatusJsonConverter(),
                    new global::G.JsonConverters.ConsensusThreadStatusVariant2ConsensusThreadStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ConsensusThreadStatusVariant3ConsensusThreadStatusJsonConverter(),
                    new global::G.JsonConverters.ConsensusThreadStatusVariant3ConsensusThreadStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ReplicaStateJsonConverter(),
                    new global::G.JsonConverters.ReplicaStateNullableJsonConverter(),
                    new global::G.JsonConverters.ShardTransferMethodJsonConverter(),
                    new global::G.JsonConverters.ShardTransferMethodNullableJsonConverter(),
                    new global::G.JsonConverters.ReshardingDirectionJsonConverter(),
                    new global::G.JsonConverters.ReshardingDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.CpuEndianJsonConverter(),
                    new global::G.JsonConverters.CpuEndianNullableJsonConverter(),
                    new global::G.JsonConverters.ShardStatusJsonConverter(),
                    new global::G.JsonConverters.ShardStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SegmentTypeJsonConverter(),
                    new global::G.JsonConverters.SegmentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant1JsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant1NullableJsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant2JsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant3JsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant3NullableJsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant4JsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant4NullableJsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant5JsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeVariant5NullableJsonConverter(),
                    new global::G.JsonConverters.IndexesVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.IndexesVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IndexesVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.IndexesVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStorageDatatypeJsonConverter(),
                    new global::G.JsonConverters.VectorStorageDatatypeNullableJsonConverter(),
                    new global::G.JsonConverters.SparseIndexTypeVariant1JsonConverter(),
                    new global::G.JsonConverters.SparseIndexTypeVariant1NullableJsonConverter(),
                    new global::G.JsonConverters.SparseIndexTypeVariant2JsonConverter(),
                    new global::G.JsonConverters.SparseIndexTypeVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.SparseIndexTypeVariant3JsonConverter(),
                    new global::G.JsonConverters.SparseIndexTypeVariant3NullableJsonConverter(),
                    new global::G.JsonConverters.SparseVectorStorageTypeVariant1JsonConverter(),
                    new global::G.JsonConverters.SparseVectorStorageTypeVariant1NullableJsonConverter(),
                    new global::G.JsonConverters.SparseVectorStorageTypeVariant2JsonConverter(),
                    new global::G.JsonConverters.SparseVectorStorageTypeVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TrackerStatusEnumJsonConverter(),
                    new global::G.JsonConverters.TrackerStatusEnumNullableJsonConverter(),
                    new global::G.JsonConverters.ShardCleanStatusTelemetryEnumJsonConverter(),
                    new global::G.JsonConverters.ShardCleanStatusTelemetryEnumNullableJsonConverter(),
                    new global::G.JsonConverters.SnapshotPriorityJsonConverter(),
                    new global::G.JsonConverters.SnapshotPriorityNullableJsonConverter(),
                    new global::G.JsonConverters.WriteOrderingJsonConverter(),
                    new global::G.JsonConverters.WriteOrderingNullableJsonConverter(),
                    new global::G.JsonConverters.ReadConsistencyTypeJsonConverter(),
                    new global::G.JsonConverters.ReadConsistencyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FusionJsonConverter(),
                    new global::G.JsonConverters.FusionNullableJsonConverter(),
                    new global::G.JsonConverters.SampleJsonConverter(),
                    new global::G.JsonConverters.SampleNullableJsonConverter(),
                    new global::G.JsonConverters.DisabledTypeJsonConverter(),
                    new global::G.JsonConverters.DisabledTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SnowballTypeJsonConverter(),
                    new global::G.JsonConverters.SnowballTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OptimizersStatusJsonConverter(),
                    new global::G.JsonConverters.VectorsConfigJsonConverter(),
                    new global::G.JsonConverters.QuantizationConfigJsonConverter(),
                    new global::G.JsonConverters.PayloadSchemaParamsJsonConverter(),
                    new global::G.JsonConverters.StopwordsInterfaceJsonConverter(),
                    new global::G.JsonConverters.StemmingAlgorithmJsonConverter(),
                    new global::G.JsonConverters.ShardKeySelectorJsonConverter(),
                    new global::G.JsonConverters.ShardKeyJsonConverter(),
                    new global::G.JsonConverters.ExtendedPointIdJsonConverter(),
                    new global::G.JsonConverters.WithPayloadInterfaceJsonConverter(),
                    new global::G.JsonConverters.PayloadSelectorJsonConverter(),
                    new global::G.JsonConverters.WithVectorJsonConverter(),
                    new global::G.JsonConverters.VectorStructOutputJsonConverter(),
                    new global::G.JsonConverters.VectorOutputJsonConverter(),
                    new global::G.JsonConverters.OrderValueJsonConverter(),
                    new global::G.JsonConverters.NamedVectorStructJsonConverter(),
                    new global::G.JsonConverters.ConditionJsonConverter(),
                    new global::G.JsonConverters.ValueVariantsJsonConverter(),
                    new global::G.JsonConverters.AnyVariantsJsonConverter(),
                    new global::G.JsonConverters.RangeInterfaceJsonConverter(),
                    new global::G.JsonConverters.RecommendExampleJsonConverter(),
                    new global::G.JsonConverters.UsingVectorJsonConverter(),
                    new global::G.JsonConverters.OrderByInterfaceJsonConverter(),
                    new global::G.JsonConverters.StartFromJsonConverter(),
                    new global::G.JsonConverters.MaxOptimizationThreadsJsonConverter(),
                    new global::G.JsonConverters.QuantizationConfigDiffJsonConverter(),
                    new global::G.JsonConverters.AliasOperationsJsonConverter(),
                    new global::G.JsonConverters.PayloadFieldSchemaJsonConverter(),
                    new global::G.JsonConverters.PointsSelectorJsonConverter(),
                    new global::G.JsonConverters.PointInsertOperationsJsonConverter(),
                    new global::G.JsonConverters.BatchVectorStructJsonConverter(),
                    new global::G.JsonConverters.VectorJsonConverter(),
                    new global::G.JsonConverters.DocumentOptions2JsonConverter(),
                    new global::G.JsonConverters.VectorStructJsonConverter(),
                    new global::G.JsonConverters.ClusterStatusJsonConverter(),
                    new global::G.JsonConverters.ConsensusThreadStatusJsonConverter(),
                    new global::G.JsonConverters.CollectionTelemetryEnumJsonConverter(),
                    new global::G.JsonConverters.VectorStorageTypeJsonConverter(),
                    new global::G.JsonConverters.IndexesJsonConverter(),
                    new global::G.JsonConverters.SparseIndexTypeJsonConverter(),
                    new global::G.JsonConverters.SparseVectorStorageTypeJsonConverter(),
                    new global::G.JsonConverters.PayloadStorageTypeJsonConverter(),
                    new global::G.JsonConverters.TrackerStatusJsonConverter(),
                    new global::G.JsonConverters.ShardCleanStatusTelemetryJsonConverter(),
                    new global::G.JsonConverters.ClusterOperationsJsonConverter(),
                    new global::G.JsonConverters.ReadConsistencyJsonConverter(),
                    new global::G.JsonConverters.GroupIdJsonConverter(),
                    new global::G.JsonConverters.WithLookupInterfaceJsonConverter(),
                    new global::G.JsonConverters.UpdateOperationJsonConverter(),
                    new global::G.JsonConverters.ShardSnapshotLocationJsonConverter(),
                    new global::G.JsonConverters.QueryInterfaceJsonConverter(),
                    new global::G.JsonConverters.VectorInputJsonConverter(),
                    new global::G.JsonConverters.QueryJsonConverter(),
                    new global::G.JsonConverters.ContextInputJsonConverter(),
                    new global::G.JsonConverters.ExpressionJsonConverter(),
                    new global::G.JsonConverters.FeedbackStrategyJsonConverter(),
                    new global::G.JsonConverters.FacetValueJsonConverter(),
                    new global::G.JsonConverters.MatchConditionJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ContextPair, global::System.Collections.Generic.IList<global::G.ContextPair>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Additional names for existing collections.
        /// </summary>
        public AliasesClient Aliases => new AliasesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Beta features, do not depend on these yet.
        /// </summary>
        public BetaClient Beta => new BetaClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Searchable collections of points.
        /// </summary>
        public CollectionsClient Collections => new CollectionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Service distributed setup.
        /// </summary>
        public DistributedClient Distributed => new DistributedClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Indexes for payloads associated with points.
        /// </summary>
        public IndexesClient Indexes => new IndexesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Float-point vectors with payload.
        /// </summary>
        public PointsClient Points => new PointsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Find points in a collection.
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Qdrant service utilities.
        /// </summary>
        public ServiceClient Service => new ServiceClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Storage and collections snapshots.
        /// </summary>
        public SnapshotsClient Snapshots => new SnapshotsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}