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
        /// Authentication configuration management.
        /// </summary>
        public AuthConfigsClient AuthConfigs { get; }

        /// <summary>
        /// Authentication related endpoints.
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// CLI integration endpoints.
        /// </summary>
        public CliClient Cli { get; }

        /// <summary>
        /// 
        /// </summary>
        public CliAuthenticationClient CliAuthentication { get; }

        /// <summary>
        /// Connected account management.
        /// </summary>
        public ConnectedAccountsClient ConnectedAccounts { get; }

        /// <summary>
        /// File management.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Logging and monitoring.
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// MCP server management.
        /// </summary>
        public McpClient Mcp { get; }

        /// <summary>
        /// Endpoints to help with migration from v1 to v3.
        /// </summary>
        public MigrationClient Migration { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationManagementClient OrganizationManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// (Labs) Tool router endpoints.
        /// </summary>
        public ToolRouterClient ToolRouter { get; }

        /// <summary>
        /// Toolkit and tool management.
        /// </summary>
        public ToolkitsClient Toolkits { get; }

        /// <summary>
        /// Tool execution endpoints.
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// Trigger management and execution.
        /// </summary>
        public TriggersClient Triggers { get; }

        /// <summary>
        /// Webhook configuration.
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}