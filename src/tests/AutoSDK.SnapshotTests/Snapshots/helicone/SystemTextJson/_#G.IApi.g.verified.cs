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
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::G.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AdminAlertBannerClient AdminAlertBanner { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentClient Agent { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey { get; }

        /// <summary>
        /// 
        /// </summary>
        public ComparisonClient Comparison { get; }

        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomerClient Customer { get; }

        /// <summary>
        /// 
        /// </summary>
        public DashboardClient Dashboard { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvalsClient Evals { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvaluatorClient Evaluator { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentClient Experiment { get; }

        /// <summary>
        /// 
        /// </summary>
        public HeliconeSqlClient HeliconeSql { get; }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationClient Integration { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelRegistryClient ModelRegistry { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public PiClient Pi { get; }

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundClient Playground { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt { get; }

        /// <summary>
        /// 
        /// </summary>
        public Prompt2025Client Prompt2025 { get; }

        /// <summary>
        /// 
        /// </summary>
        public Prompt2025V2Client Prompt2025V2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public PropertyClient Property { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProvidersClient Providers { get; }

        /// <summary>
        /// 
        /// </summary>
        public RequestClient Request { get; }

        /// <summary>
        /// 
        /// </summary>
        public SecurityClient Security { get; }

        /// <summary>
        /// 
        /// </summary>
        public SessionClient Session { get; }

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats { get; }

        /// <summary>
        /// 
        /// </summary>
        public StatusClient Status { get; }

        /// <summary>
        /// 
        /// </summary>
        public StripeClient Stripe { get; }

        /// <summary>
        /// 
        /// </summary>
        public TestClient Test { get; }

        /// <summary>
        /// 
        /// </summary>
        public TraceClient Trace { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public VaultClient Vault { get; }

        /// <summary>
        /// 
        /// </summary>
        public WaitlistClient Waitlist { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

        /// <summary>
        /// 
        /// </summary>
        public WrappedClient Wrapped { get; }

    }
}