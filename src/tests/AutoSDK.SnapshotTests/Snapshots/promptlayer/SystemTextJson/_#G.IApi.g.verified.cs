//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
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
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvaluationsClient Evaluations { get; }

        /// <summary>
        /// 
        /// </summary>
        public FoldersClient Folders { get; }

        /// <summary>
        /// 
        /// </summary>
        public GroupClient Group { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata { get; }

        /// <summary>
        /// 
        /// </summary>
        public OtlpClient Otlp { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplatesClient PromptTemplates { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReportsClient Reports { get; }

        /// <summary>
        /// 
        /// </summary>
        public RequestClient Request { get; }

        /// <summary>
        /// 
        /// </summary>
        public RestClient Rest { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScoreClient Score { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpansClient Spans { get; }

        /// <summary>
        /// 
        /// </summary>
        public TrackingClient Tracking { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowClient Workflow { get; }

    }
}