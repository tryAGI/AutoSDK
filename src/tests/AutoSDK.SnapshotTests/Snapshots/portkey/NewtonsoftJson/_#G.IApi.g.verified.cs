//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Portkey REST API. Please see https://portkey.ai/docs/api-reference for more details.<br/>
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
        /// Get data points for graphical representation.
        /// </summary>
        public AnalyticsGraphsClient AnalyticsGraphs { get; }

        /// <summary>
        /// Get grouped metrics for the selected time bucket.
        /// </summary>
        public AnalyticsGroupsClient AnalyticsGroups { get; }

        /// <summary>
        /// Get overall summary for the selected time bucket.
        /// </summary>
        public AnalyticsSummaryClient AnalyticsSummary { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey API keys.
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// Build Assistants that can call models and use tools.
        /// </summary>
        public AssistantsClient Assistants { get; }

        /// <summary>
        /// Turn audio into text or text into audio.
        /// </summary>
        public AudioClient Audio { get; }

        /// <summary>
        /// Get audit logs for your Portkey account.
        /// </summary>
        public AuditLogsClient AuditLogs { get; }

        /// <summary>
        /// Create large batches of API requests to run asynchronously.
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete collections of prompts.
        /// </summary>
        public CollectionsClient Collections { get; }

        /// <summary>
        /// Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.
        /// </summary>
        public CompletionsClient Completions { get; }

        /// <summary>
        /// Create, List, Retrieve, and Update your Portkey Configs.
        /// </summary>
        public ConfigsClient Configs { get; }

        /// <summary>
        /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// Send and Update any feedback.
        /// </summary>
        public FeedbackClient Feedback { get; }

        /// <summary>
        /// Files are used to upload documents that can be used with features like Assistants and Fine-tuning.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Manage fine-tuning jobs to tailor a model to your specific training data.
        /// </summary>
        public FineTuningClient FineTuning { get; }

        /// <summary>
        /// 
        /// </summary>
        public FinetuneClient Finetune { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete prompt Guardrails.
        /// </summary>
        public GuardrailsClient Guardrails { get; }

        /// <summary>
        /// Given a prompt and/or an input image, the model will generate a new image.
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Integrations.
        /// </summary>
        public IntegrationsClient Integrations { get; }

        /// <summary>
        /// Manage model access for your Portkey Integrations.
        /// </summary>
        public IntegrationsModelsClient IntegrationsModels { get; }

        /// <summary>
        /// Manage workspace access for your Portkey Integrations.
        /// </summary>
        public IntegrationsWorkspacesClient IntegrationsWorkspaces { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete labels.
        /// </summary>
        public LabelsClient Labels { get; }

        /// <summary>
        /// Custom Logger to add external logs to Portkey.
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// Exports logs service.
        /// </summary>
        public LogsExportClient LogsExport { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete MCP Integrations.
        /// </summary>
        public McpIntegrationsClient McpIntegrations { get; }

        /// <summary>
        /// List and manage capabilities for MCP Integrations.
        /// </summary>
        public McpIntegrationsCapabilitiesClient McpIntegrationsCapabilities { get; }

        /// <summary>
        /// Get MCP Integration metadata and sync info.
        /// </summary>
        public McpIntegrationsMetadataClient McpIntegrationsMetadata { get; }

        /// <summary>
        /// Manage workspace access for MCP Integrations.
        /// </summary>
        public McpIntegrationsWorkspacesClient McpIntegrationsWorkspaces { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete MCP Servers (workspace instances of MCP Integrations).
        /// </summary>
        public McpServersClient McpServers { get; }

        /// <summary>
        /// List and manage capabilities for MCP Servers.
        /// </summary>
        public McpServersCapabilitiesClient McpServersCapabilities { get; }

        /// <summary>
        /// List and manage user access for MCP Servers.
        /// </summary>
        public McpServersUserAccessClient McpServersUserAccess { get; }

        /// <summary>
        /// Model pricing configurations for 2300+ LLMs across 40+ providers.
        /// </summary>
        public ModelPricingClient ModelPricing { get; }

        /// <summary>
        /// List and describe the various models available in the API.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Given a input text, outputs if the model classifies it as potentially harmful.
        /// </summary>
        public ModerationsClient Moderations { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete prompt partials.
        /// </summary>
        public PromptPartialsClient PromptPartials { get; }

        /// <summary>
        /// Given a prompt template ID and variables, will run the saved prompt template and return a response.
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Providers.
        /// </summary>
        public ProvidersClient Providers { get; }

        /// <summary>
        /// Manage rate limits policies to control request or token rates.
        /// </summary>
        public RateLimitsPoliciesClient RateLimitsPolicies { get; }

        /// <summary>
        /// WebSocket proxy for provider Realtime APIs.
        /// </summary>
        public RealtimeClient Realtime { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClient Responses { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete secret references to external secret managers.
        /// </summary>
        public SecretReferencesClient SecretReferences { get; }

        /// <summary>
        /// Manage usage limits policies to control total usage over time.
        /// </summary>
        public UsageLimitsPoliciesClient UsageLimitsPolicies { get; }

        /// <summary>
        /// Create and manage user invites.
        /// </summary>
        public UserInvitesClient UserInvites { get; }

        /// <summary>
        /// Create and manage users.
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public VectorStoresClient VectorStores { get; }

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Virtual keys.
        /// </summary>
        public VirtualKeysClient VirtualKeys { get; }

        /// <summary>
        /// Create and manage workspaces.
        /// </summary>
        public WorkspacesClient Workspaces { get; }

        /// <summary>
        /// Create and manage workspace members.
        /// </summary>
        public WorkspacesMembersClient WorkspacesMembers { get; }

    }
}