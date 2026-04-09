//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Opik REST API is currently in beta and subject to change. If you have any questions or feedback about the APIs, please reach out on GitHub: https://github.com/comet-ml/opik.<br/>
    /// All of the methods listed in this documentation are used by either the SDK or the UI to interact with the Opik server. As a result,<br/>
    /// the methods have been optimized for these use-cases in mind. If you are looking for a method that is not listed above, please create<br/>
    /// and issue on GitHub or raise a PR!<br/>
    /// Opik includes two main deployment options that results in slightly different API usage:<br/>
    /// - **Self-hosted Opik instance:** You will simply need to specify the URL as `http://localhost:5173/api/&lt;endpoint_path&gt;` or similar. This is the default option for the docs.<br/>
    /// - **Opik Cloud:** You will need to specify the Opik API Key and Opik Workspace in the header. The format of the header should be:<br/>
    ///   ```<br/>
    ///   {<br/>
    ///     "Comet-Workspace": "your-workspace-name",<br/>
    ///     "authorization": "your-api-key"<br/>
    ///   }<br/>
    ///   ```<br/>
    ///   The full payload would therefore look like:<br/>
    ///   <br/>
    ///   ```<br/>
    ///   curl -X GET 'https://www.comet.com/opik/api/v1/private/projects' \<br/>
    ///   -H 'Accept: application/json' \<br/>
    ///   -H 'Comet-Workspace: &lt;your-workspace-name&gt;' \<br/>
    ///   -H 'authorization: &lt;your-api-key&gt;'<br/>
    ///   ```<br/>
    ///   Do take note here that the authorization header value does not include the `Bearer ` prefix. To switch to using the Opik Cloud in the documentation, you can<br/>
    ///   click on the edit button displayed when hovering over the `Base URL` displayed on the right hand side of the docs.<br/>
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
        /// Agent configuration management.
        /// </summary>
        public AgentConfigsClient AgentConfigs { get; }

        /// <summary>
        /// Alert resources.
        /// </summary>
        public AlertsClient Alerts { get; }

        /// <summary>
        /// Private annotation queue operations.
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues { get; }

        /// <summary>
        /// Assistant Sidebar configuration.
        /// </summary>
        public AssistantSidebarsClient AssistantSidebars { get; }

        /// <summary>
        /// Attachments related resources.
        /// </summary>
        public AttachmentsClient Attachments { get; }

        /// <summary>
        /// Automation rule evaluators resource.
        /// </summary>
        public AutomationRuleEvaluatorsClient AutomationRuleEvaluators { get; }

        /// <summary>
        /// Chat Completions related resources.
        /// </summary>
        public ChatCompletionsClient ChatCompletions { get; }

        /// <summary>
        /// Access check resources.
        /// </summary>
        public CheckClient Check { get; }

        /// <summary>
        /// Workspace Dashboard resources.
        /// </summary>
        public DashboardsClient Dashboards { get; }

        /// <summary>
        /// Dataset resources.
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Experiment resources.
        /// </summary>
        public ExperimentsClient Experiments { get; }

        /// <summary>
        /// Feedback definitions related resources.
        /// </summary>
        public FeedbackDefinitionsClient FeedbackDefinitions { get; }

        /// <summary>
        /// Guardrails related resources.
        /// </summary>
        public GuardrailsClient Guardrails { get; }

        /// <summary>
        /// Insights View resources.
        /// </summary>
        public InsightsViewsClient InsightsViews { get; }

        /// <summary>
        /// LLM model registry resources.
        /// </summary>
        public LlmModelsClient LlmModels { get; }

        /// <summary>
        /// LLM Provider Key.
        /// </summary>
        public LlmProviderKeyClient LlmProviderKey { get; }

        /// <summary>
        /// Manual evaluation resources for traces, threads, and spans.
        /// </summary>
        public ManualEvaluationClient ManualEvaluation { get; }

        /// <summary>
        /// Ollama provider configuration endpoints with OpenAI-compatible API support.
        /// </summary>
        public OllamaClient Ollama { get; }

        /// <summary>
        /// Ollie pod state persistence.
        /// </summary>
        public OllieStateClient OllieState { get; }

        /// <summary>
        /// Resource to ingest Traces and Spans via OpenTelemetry.
        /// </summary>
        public OpenTelemetryIngestionClient OpenTelemetryIngestion { get; }

        /// <summary>
        /// Optimization resources.
        /// </summary>
        public OptimizationsClient Optimizations { get; }

        /// <summary>
        /// Project related resources.
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// Prompt resources.
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// Redirects for SDK generated links.
        /// </summary>
        public RedirectClient Redirect { get; }

        /// <summary>
        /// Data retention rule management.
        /// </summary>
        public RetentionRulesClient RetentionRules { get; }

        /// <summary>
        /// Local runner management endpoints.
        /// </summary>
        public RunnersClient Runners { get; }

        /// <summary>
        /// Service Toggles resources.
        /// </summary>
        public ServiceTogglesClient ServiceToggles { get; }

        /// <summary>
        /// Span related resources.
        /// </summary>
        public SpansClient Spans { get; }

        /// <summary>
        /// System usage related resource.
        /// </summary>
        public SystemUsageClient SystemUsage { get; }

        /// <summary>
        /// Trace related resources.
        /// </summary>
        public TracesClient Traces { get; }

        /// <summary>
        /// Welcome wizard tracking resources.
        /// </summary>
        public WelcomeWizardClient WelcomeWizard { get; }

        /// <summary>
        /// Workspace permissions related resources.
        /// </summary>
        public WorkspacePermissionsClient WorkspacePermissions { get; }

        /// <summary>
        /// Workspace related resources.
        /// </summary>
        public WorkspacesClient Workspaces { get; }

    }
}