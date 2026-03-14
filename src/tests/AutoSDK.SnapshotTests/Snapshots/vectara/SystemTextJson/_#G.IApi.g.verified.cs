//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// REST APIs provide a traditional integration path for web-based applications.<br/>
    /// You can find all of our APIs at `https://api.vectara.io/v2/&lt;api-endpoint&gt;` The API endpoints are outlined in the various subsections of this API Reference section and are designed to be intuitive and follow a standard RESTful structure.<br/>
    /// - The current version is **v2**.<br/>
    /// - `api-endpoint` follows a hierarchical structure, using lowercase and hyphens.<br/>
    ///   For example, `/corpora/:corpus_key/documents`.<br/>
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
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Create and interact with AI agents that can use tools and corpora to perform complex queries.
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// Manage agent sessions and interact with agents through conversational events.
        /// </summary>
        public AgentSessionsClient AgentSessions { get; }

        /// <summary>
        /// Create and manage scheduled automated execution of agents at specified intervals.
        /// </summary>
        public AgentSchedulesClient AgentSchedules { get; }

        /// <summary>
        /// List predefined guardrails for validating tool calls, agent outputs, and agent actions.
        /// </summary>
        public GuardrailsClient Guardrails { get; }

        /// <summary>
        /// Create and manage instructions that guide agent behavior.
        /// </summary>
        public InstructionsClient Instructions { get; }

        /// <summary>
        /// Manage and discover tools available for AI agents to use in their workflows.
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// Manage tool servers that provide access to external tools for AI agents.
        /// </summary>
        public ToolServersClient ToolServers { get; }

        /// <summary>
        /// Create and manage connectors that allow agents to receive events from external platforms like Slack.
        /// </summary>
        public AgentConnectorsClient AgentConnectors { get; }

        /// <summary>
        /// Create and manage automated data pipelines. A pipeline is a one-directional flow that sends all data from a source system to an agent, creating a new session per source record for the agent to act on. This is distinct from agent schedules (recurring single executions) and connectors (bidirectional chat integrations like Slack).
        /// </summary>
        public PipelinesClient Pipelines { get; }

        /// <summary>
        /// Monitor pipeline execution runs and their processing outcomes.
        /// </summary>
        public PipelineRunsClient PipelineRuns { get; }

        /// <summary>
        /// The Query APIs are the primary interface for searching your data and generating AI-powered summaries. After indexing documents into corpora, you use these endpoints to retrieve relevant information and optionally generate grounded summaries using Retrieval Augmented Generation (RAG).
        /// </summary>
        public QueriesClient Queries { get; }

        /// <summary>
        /// Query across arbitrary metadata fields in a corpus.
        /// </summary>
        public MetadataQueryClient MetadataQuery { get; }

        /// <summary>
        /// Upload files to a corpus for automatic parsing, text extraction, chunking, and indexing.
        /// </summary>
        public UploadClient Upload { get; }

        /// <summary>
        /// Index and manage both core and structured documents to enable efficient search and retrieval.
        /// </summary>
        public IndexClient Index { get; }

        /// <summary>
        /// Create, manage, and update corpora and their associated settings.
        /// </summary>
        public CorporaClient Corpora { get; }

        /// <summary>
        /// Retrieve and manage documents stored in a corpus for administrative tasks.
        /// </summary>
        public DocumentsClient Documents { get; }

        /// <summary>
        /// Manage generation presets for controlling the behavior of generative AI responses.
        /// </summary>
        public GenerationPresetsClient GenerationPresets { get; }

        /// <summary>
        /// Retrieve and manage the history of previous queries for analytics and auditing.
        /// </summary>
        public QueryHistoryClient QueryHistory { get; }

        /// <summary>
        /// Authenticate with the API using OAuth 2.0 or API keys.
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// Create, manage, and revoke API keys for secure access to the platform.
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// Configure and manage application clients for OAuth authentication.
        /// </summary>
        public ApplicationClientsClient ApplicationClients { get; }

        /// <summary>
        /// List LLMs for text summarization, chat, and other generation tasks.
        /// </summary>
        public LargeLanguageModelsClient LargeLanguageModels { get; }

        /// <summary>
        /// List available encoders (such as Boomerang) that turn text into vectors.
        /// </summary>
        public EncodersClient Encoders { get; }

        /// <summary>
        /// List rerankers for reranking search results.
        /// </summary>
        public RerankersClient Rerankers { get; }

        /// <summary>
        /// Monitor background jobs such as rebuilding indexes or updating corpus settings.
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// Create, manage, and authenticate users within the platform for user administration.
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// List available extractors for tabular data from documents.
        /// </summary>
        public TableExtractorsClient TableExtractors { get; }

        /// <summary>
        /// API for managing hallucination correction, including listing available models and correcting hallucinated content in generated text.
        /// </summary>
        public HallucinationCorrectorsClient HallucinationCorrectors { get; }

        /// <summary>
        /// Create model responses for chat conversations using OpenAI-compatible endpoints.
        /// </summary>
        public LlmChatCompletionsClient LlmChatCompletions { get; }

        /// <summary>
        /// Evaluate text quality metrics like factual consistency and hallucination detection.
        /// </summary>
        public FactualConsistencyEvaluationClient FactualConsistencyEvaluation { get; }

        /// <summary>
        /// Retrieve customer configuration and authentication details.
        /// </summary>
        public CustomerConfigurationClient CustomerConfiguration { get; }

        /// <summary>
        /// Deprecated: use Agents instead. Chat endpoints are no longer supported.
        /// </summary>
        public ChatsClient Chats { get; }

    }
}