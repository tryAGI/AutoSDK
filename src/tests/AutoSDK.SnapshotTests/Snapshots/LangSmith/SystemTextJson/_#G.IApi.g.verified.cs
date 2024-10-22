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
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public RunClient Run { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback { get; }

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues { get; }

        /// <summary>
        /// 
        /// </summary>
        public AceClient Ace { get; }

        /// <summary>
        /// 
        /// </summary>
        public BulkExportsClient BulkExports { get; }

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant { get; }

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits { get; }

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces { get; }

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos { get; }

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits { get; }

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings { get; }

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments { get; }

    }
}