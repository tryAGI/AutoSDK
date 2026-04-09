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
        public const string DefaultBaseUrl = "http://localhost:6333";

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
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// Additional names for existing collections.
        /// </summary>
        public AliasesClient Aliases => new AliasesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Beta features, do not depend on these yet.
        /// </summary>
        public BetaClient Beta => new BetaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Searchable collections of points.
        /// </summary>
        public CollectionsClient Collections => new CollectionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Service distributed setup.
        /// </summary>
        public DistributedClient Distributed => new DistributedClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Indexes for payloads associated with points.
        /// </summary>
        public IndexesClient Indexes => new IndexesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Float-point vectors with payload.
        /// </summary>
        public PointsClient Points => new PointsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Find points in a collection.
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Qdrant service utilities.
        /// </summary>
        public ServiceClient Service => new ServiceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Storage and collections snapshots.
        /// </summary>
        public SnapshotsClient Snapshots => new SnapshotsClient(HttpClient, authorizations: Authorizations)
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
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
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