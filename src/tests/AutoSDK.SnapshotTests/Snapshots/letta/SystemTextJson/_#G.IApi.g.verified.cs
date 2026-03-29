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
        public AgentsClient Agents { get; }

        /// <summary>
        /// 
        /// </summary>
        public ArchivesClient Archives { get; }

        /// <summary>
        /// 
        /// </summary>
        public BlocksClient Blocks { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClientSideAccessTokensClient ClientSideAccessTokens { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConversationsClient Conversations { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentsClient Environments { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeedsClient Feeds { get; }

        /// <summary>
        /// 
        /// </summary>
        public FoldersClient Folders { get; }

        /// <summary>
        /// 
        /// </summary>
        public GroupsClient Groups { get; }

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health { get; }

        /// <summary>
        /// 
        /// </summary>
        public IdentitiesClient Identities { get; }

        /// <summary>
        /// 
        /// </summary>
        public InternalAgentsClient InternalAgents { get; }

        /// <summary>
        /// 
        /// </summary>
        public InternalBlocksClient InternalBlocks { get; }

        /// <summary>
        /// 
        /// </summary>
        public InternalRunsClient InternalRuns { get; }

        /// <summary>
        /// 
        /// </summary>
        public InternalTemplatesClient InternalTemplates { get; }

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// 
        /// </summary>
        public McpServersClient McpServers { get; }

        /// <summary>
        /// 
        /// </summary>
        public MemoryFilesClient MemoryFiles { get; }

        /// <summary>
        /// 
        /// </summary>
        public MessagesClient Messages { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public PassagesClient Passages { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProvidersClient Providers { get; }

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScheduledMessagesClient ScheduledMessages { get; }

        /// <summary>
        /// 
        /// </summary>
        public SourcesClient Sources { get; }

        /// <summary>
        /// 
        /// </summary>
        public StepsClient Steps { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagClient Tag { get; }

        /// <summary>
        /// 
        /// </summary>
        public TelemetryClient Telemetry { get; }

        /// <summary>
        /// 
        /// </summary>
        public TemplatesClient Templates { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoiceClient Voice { get; }

    }
}