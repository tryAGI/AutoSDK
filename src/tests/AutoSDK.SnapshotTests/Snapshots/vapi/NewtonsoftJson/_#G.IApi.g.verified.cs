//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice AI for developers.<br/>
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
        public AnalyticsClient Analytics { get; }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsClient Assistants { get; }

        /// <summary>
        /// 
        /// </summary>
        public CallsClient Calls { get; }

        /// <summary>
        /// 
        /// </summary>
        public CampaignsClient Campaigns { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatsClient Chats { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvalClient Eval { get; }

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// 
        /// </summary>
        public InsightClient Insight { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityScorecardClient ObservabilityScorecard { get; }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumbersClient PhoneNumbers { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProviderResourcesClient ProviderResources { get; }

        /// <summary>
        /// 
        /// </summary>
        public SessionsClient Sessions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SquadsClient Squads { get; }

        /// <summary>
        /// 
        /// </summary>
        public StructuredOutputsClient StructuredOutputs { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools { get; }

    }
}