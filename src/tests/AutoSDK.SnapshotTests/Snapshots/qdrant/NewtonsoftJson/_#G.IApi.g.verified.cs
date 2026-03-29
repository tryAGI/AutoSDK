//HintName: G.IApi.g.cs

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
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// Additional names for existing collections.
        /// </summary>
        public AliasesClient Aliases { get; }

        /// <summary>
        /// Beta features, do not depend on these yet.
        /// </summary>
        public BetaClient Beta { get; }

        /// <summary>
        /// Searchable collections of points.
        /// </summary>
        public CollectionsClient Collections { get; }

        /// <summary>
        /// Service distributed setup.
        /// </summary>
        public DistributedClient Distributed { get; }

        /// <summary>
        /// Indexes for payloads associated with points.
        /// </summary>
        public IndexesClient Indexes { get; }

        /// <summary>
        /// Float-point vectors with payload.
        /// </summary>
        public PointsClient Points { get; }

        /// <summary>
        /// Find points in a collection.
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// Qdrant service utilities.
        /// </summary>
        public ServiceClient Service { get; }

        /// <summary>
        /// Storage and collections snapshots.
        /// </summary>
        public SnapshotsClient Snapshots { get; }

    }
}