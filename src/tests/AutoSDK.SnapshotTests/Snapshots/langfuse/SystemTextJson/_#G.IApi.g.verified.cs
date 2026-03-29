//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ## Authentication<br/>
    /// Authenticate with the API using [Basic Auth](https://en.wikipedia.org/wiki/Basic_access_authentication), get API keys in the project settings:<br/>
    /// - username: Langfuse Public Key<br/>
    /// - password: Langfuse Secret Key<br/>
    /// ## Exports<br/>
    /// - OpenAPI spec: https://cloud.langfuse.com/generated/api/openapi.yml<br/>
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
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues { get; }

        /// <summary>
        /// 
        /// </summary>
        public BlobStorageIntegrationsClient BlobStorageIntegrations { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetItemsClient DatasetItems { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetRunItemsClient DatasetRunItems { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health { get; }

        /// <summary>
        /// 
        /// </summary>
        public IngestionClient Ingestion { get; }

        /// <summary>
        /// 
        /// </summary>
        public LegacyMetricsV1Client LegacyMetricsV1 { get; }

        /// <summary>
        /// 
        /// </summary>
        public LegacyObservationsV1Client LegacyObservationsV1 { get; }

        /// <summary>
        /// 
        /// </summary>
        public LegacyScoreV1Client LegacyScoreV1 { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmConnectionsClient LlmConnections { get; }

        /// <summary>
        /// 
        /// </summary>
        public MediaClient Media { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObservationsClient Observations { get; }

        /// <summary>
        /// 
        /// </summary>
        public OpentelemetryClient Opentelemetry { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionClient PromptVersion { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScimClient Scim { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScoreConfigsClient ScoreConfigs { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScoresClient Scores { get; }

        /// <summary>
        /// 
        /// </summary>
        public SessionsClient Sessions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TraceClient Trace { get; }

    }
}