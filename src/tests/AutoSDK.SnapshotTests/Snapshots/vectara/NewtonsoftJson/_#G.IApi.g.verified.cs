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
        /// Authenticate with the API using OAuth 2.0 or API keys.
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// 
        /// </summary>
        public Corpora2Client Corpora2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Upload2Client Upload2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Documents2Client Documents2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata { get; }

        /// <summary>
        /// 
        /// </summary>
        public Queries2Client Queries2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public QueryHistory2Client QueryHistory2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmsClient Llms { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresets2Client GenerationPresets2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public FactualConsistencyClient FactualConsistency { get; }

        /// <summary>
        /// 
        /// </summary>
        public Encoders2Client Encoders2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Rerankers2Client Rerankers2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public TableExtractors2Client TableExtractors2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public HallucinationCorrectors2Client HallucinationCorrectors2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Jobs2Client Jobs2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Users2Client Users2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeys2Client ApiKeys2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppClientsClient AppClients { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolServers2Client ToolServers2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Tools2Client Tools2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Instructions2Client Instructions2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Agents2Client Agents2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentSessions2Client AgentSessions2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentEventsClient AgentEvents { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentArtifactsClient AgentArtifacts { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentSchedules2Client AgentSchedules2 { get; }

    }
}