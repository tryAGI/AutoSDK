//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// REST APIs provide a traditional integration path for web-based applications.<br/>
    /// You can find all of our APIs at `https://api.vectara.io/v2/&lt;api-endpoint&gt;` The API endpoints are outlined in the various subsections of this API Reference section and are designed to be intuitive and follow a standard RESTful structure.<br/>
    /// - The current version is **v2**.<br/>
    /// - `api-endpoint` follows a hierarchical structure, using lowercase and hyphens.<br/>
    ///   For example, `/corpora/:corpus_key/documents`.<br/>
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
        /// 
        /// </summary>
        public AgentArtifactsClient AgentArtifacts { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentEventsClient AgentEvents { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentSchedulesClient AgentSchedules { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentSessionsClient AgentSessions { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClientsClient AppClients { get; }

        /// <summary>
        /// Authenticate with the API using OAuth 2.0 or API keys.
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// 
        /// </summary>
        public CorporaClient Corpora { get; }

        /// <summary>
        /// 
        /// </summary>
        public DocumentsClient Documents { get; }

        /// <summary>
        /// 
        /// </summary>
        public EncodersClient Encoders { get; }

        /// <summary>
        /// 
        /// </summary>
        public FactualConsistencyClient FactualConsistency { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresetsClient GenerationPresets { get; }

        /// <summary>
        /// 
        /// </summary>
        public HallucinationCorrectorsClient HallucinationCorrectors { get; }

        /// <summary>
        /// 
        /// </summary>
        public InstructionsClient Instructions { get; }

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmsClient Llms { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata { get; }

        /// <summary>
        /// 
        /// </summary>
        public QueriesClient Queries { get; }

        /// <summary>
        /// 
        /// </summary>
        public QueryHistoryClient QueryHistory { get; }

        /// <summary>
        /// 
        /// </summary>
        public RerankersClient Rerankers { get; }

        /// <summary>
        /// 
        /// </summary>
        public TableExtractorsClient TableExtractors { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolServersClient ToolServers { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// 
        /// </summary>
        public UploadClient Upload { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

    }
}