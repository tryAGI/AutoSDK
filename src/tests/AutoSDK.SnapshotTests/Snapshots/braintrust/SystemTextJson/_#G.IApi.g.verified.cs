//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API specification for the backend data server. The API is hosted globally at<br/>
    /// https://api.braintrust.dev or in your own environment.<br/>
    /// You can access the OpenAPI spec for this API at https://github.com/braintrustdata/braintrust-openapi.<br/>
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
        public AclsClient Acls { get; }

        /// <summary>
        /// 
        /// </summary>
        public AiSecretsClient AiSecrets { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public CorsClient Cors { get; }

        /// <summary>
        /// 
        /// </summary>
        public CrossObjectClient CrossObject { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnvVarsClient EnvVars { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentsClient Environments { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvalStatusPagesClient EvalStatusPages { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvalsClient Evals { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentsClient Experiments { get; }

        /// <summary>
        /// 
        /// </summary>
        public FunctionsClient Functions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GroupsClient Groups { get; }

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// 
        /// </summary>
        public McpServersClient McpServers { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public OtherClient Other { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectAutomationsClient ProjectAutomations { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectScoresClient ProjectScores { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectTagsClient ProjectTags { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProxyClient Proxy { get; }

        /// <summary>
        /// 
        /// </summary>
        public RolesClient Roles { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServiceTokensClient ServiceTokens { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpanIframesClient SpanIframes { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public ViewsClient Views { get; }

    }
}