//HintName: G.Api.g.cs

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
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Local server
        /// </summary>
        public const string DefaultBaseUrl = "http://localhost:5173/api";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// Agent configuration management
        /// </summary>
        public AgentConfigsClient AgentConfigs => new AgentConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Alert resources
        /// </summary>
        public AlertsClient Alerts => new AlertsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private annotation queue operations
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Assistant Sidebar configuration
        /// </summary>
        public AssistantSidebarsClient AssistantSidebars => new AssistantSidebarsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Attachments related resources
        /// </summary>
        public AttachmentsClient Attachments => new AttachmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Automation rule evaluators resource
        /// </summary>
        public AutomationRuleEvaluatorsClient AutomationRuleEvaluators => new AutomationRuleEvaluatorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Chat Completions related resources
        /// </summary>
        public ChatCompletionsClient ChatCompletions => new ChatCompletionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access check resources
        /// </summary>
        public CheckClient Check => new CheckClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workspace Dashboard resources
        /// </summary>
        public DashboardsClient Dashboards => new DashboardsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Dataset resources
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Experiment resources
        /// </summary>
        public ExperimentsClient Experiments => new ExperimentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Feedback definitions related resources
        /// </summary>
        public FeedbackDefinitionsClient FeedbackDefinitions => new FeedbackDefinitionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Guardrails related resources
        /// </summary>
        public GuardrailsClient Guardrails => new GuardrailsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Insights View resources
        /// </summary>
        public InsightsViewsClient InsightsViews => new InsightsViewsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// LLM model registry resources
        /// </summary>
        public LlmModelsClient LlmModels => new LlmModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// LLM Provider Key
        /// </summary>
        public LlmProviderKeyClient LlmProviderKey => new LlmProviderKeyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manual evaluation resources for traces, threads, and spans
        /// </summary>
        public ManualEvaluationClient ManualEvaluation => new ManualEvaluationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Ollama provider configuration endpoints with OpenAI-compatible API support.
        /// </summary>
        public OllamaClient Ollama => new OllamaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Ollie pod state persistence
        /// </summary>
        public OllieStateClient OllieState => new OllieStateClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Resource to ingest Traces and Spans via OpenTelemetry
        /// </summary>
        public OpenTelemetryIngestionClient OpenTelemetryIngestion => new OpenTelemetryIngestionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Optimization resources
        /// </summary>
        public OptimizationsClient Optimizations => new OptimizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Project related resources
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Prompt resources
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Redirects for SDK generated links
        /// </summary>
        public RedirectClient Redirect => new RedirectClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Data retention rule management
        /// </summary>
        public RetentionRulesClient RetentionRules => new RetentionRulesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Local runner management endpoints
        /// </summary>
        public RunnersClient Runners => new RunnersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Service Toggles resources
        /// </summary>
        public ServiceTogglesClient ServiceToggles => new ServiceTogglesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Span related resources
        /// </summary>
        public SpansClient Spans => new SpansClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// System usage related resource
        /// </summary>
        public SystemUsageClient SystemUsage => new SystemUsageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Trace related resources
        /// </summary>
        public TracesClient Traces => new TracesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Welcome wizard tracking resources
        /// </summary>
        public WelcomeWizardClient WelcomeWizard => new WelcomeWizardClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workspace permissions related resources
        /// </summary>
        public WorkspacePermissionsClient WorkspacePermissions => new WorkspacePermissionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workspace related resources
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}