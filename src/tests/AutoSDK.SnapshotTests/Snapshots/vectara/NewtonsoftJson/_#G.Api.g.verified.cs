//HintName: G.Api.g.cs

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
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.vectara.io/";

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

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }


        internal global::G.Api.AutoSDKOAuth2Coordinator AutoSDKOAuth2State { get; set; } = new global::G.Api.AutoSDKOAuth2Coordinator();
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.FilterAttributeLevelJsonConverter(),

                    new global::G.JsonConverters.FilterAttributeLevelNullableJsonConverter(),

                    new global::G.JsonConverters.FilterAttributeTypeJsonConverter(),

                    new global::G.JsonConverters.FilterAttributeTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FilterAttributeStatTypeJsonConverter(),

                    new global::G.JsonConverters.FilterAttributeStatTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChunkingStrategyDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.ChunkingStrategyDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateDocumentRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreateDocumentRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeJsonConverter(),

                    new global::G.JsonConverters.BulkDeleteDocumentsResponseDiscriminatorResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.SummarizeDocumentStreamedResponseDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MetadataQueryRequestLevelJsonConverter(),

                    new global::G.JsonConverters.MetadataQueryRequestLevelNullableJsonConverter(),

                    new global::G.JsonConverters.LanguageJsonConverter(),

                    new global::G.JsonConverters.LanguageNullableJsonConverter(),

                    new global::G.JsonConverters.QueryWarningJsonConverter(),

                    new global::G.JsonConverters.QueryWarningNullableJsonConverter(),

                    new global::G.JsonConverters.SearchSemanticsJsonConverter(),

                    new global::G.JsonConverters.SearchSemanticsNullableJsonConverter(),

                    new global::G.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CitationParametersStyleJsonConverter(),

                    new global::G.JsonConverters.CitationParametersStyleNullableJsonConverter(),

                    new global::G.JsonConverters.QueryStreamedResponseDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.QueryStreamedResponseDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RewrittenQueryWarningJsonConverter(),

                    new global::G.JsonConverters.RewrittenQueryWarningNullableJsonConverter(),

                    new global::G.JsonConverters.QueryHistorySpanDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.QueryHistorySpanDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LLMOwnershipJsonConverter(),

                    new global::G.JsonConverters.LLMOwnershipNullableJsonConverter(),

                    new global::G.JsonConverters.RemoteAuthDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.RemoteAuthDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.VertexAiAuthDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.VertexAiAuthDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AnthropicAuthDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AnthropicAuthDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateLLMRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreateLLMRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateLLMRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.UpdateLLMRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.JsonSchemaDefinitionTypeJsonConverter(),

                    new global::G.JsonConverters.JsonSchemaDefinitionTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateEncoderRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreateEncoderRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.JobStateJsonConverter(),

                    new global::G.JsonConverters.JobStateNullableJsonConverter(),

                    new global::G.JsonConverters.JobTypeJsonConverter(),

                    new global::G.JsonConverters.JobTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiRoleJsonConverter(),

                    new global::G.JsonConverters.ApiRoleNullableJsonConverter(),

                    new global::G.JsonConverters.CorpusRoleRoleJsonConverter(),

                    new global::G.JsonConverters.CorpusRoleRoleNullableJsonConverter(),

                    new global::G.JsonConverters.AgentRoleRoleJsonConverter(),

                    new global::G.JsonConverters.AgentRoleRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ApiKeyRoleJsonConverter(),

                    new global::G.JsonConverters.ApiKeyRoleNullableJsonConverter(),

                    new global::G.JsonConverters.CreateAppClientRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreateAppClientRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ToolServerTypeJsonConverter(),

                    new global::G.JsonConverters.ToolServerTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ToolServerTransportJsonConverter(),

                    new global::G.JsonConverters.ToolServerTransportNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionDefinitionLanguageJsonConverter(),

                    new global::G.JsonConverters.FunctionDefinitionLanguageNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionDefinitionValidationStatusJsonConverter(),

                    new global::G.JsonConverters.FunctionDefinitionValidationStatusNullableJsonConverter(),

                    new global::G.JsonConverters.LambdaToolVariant2LanguageJsonConverter(),

                    new global::G.JsonConverters.LambdaToolVariant2LanguageNullableJsonConverter(),

                    new global::G.JsonConverters.ToolDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateLambdaToolRequestLanguageJsonConverter(),

                    new global::G.JsonConverters.CreateLambdaToolRequestLanguageNullableJsonConverter(),

                    new global::G.JsonConverters.CreateToolRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreateToolRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TestLambdaToolRequestLanguageJsonConverter(),

                    new global::G.JsonConverters.TestLambdaToolRequestLanguageNullableJsonConverter(),

                    new global::G.JsonConverters.TestLambdaToolResponseValidationStatusJsonConverter(),

                    new global::G.JsonConverters.TestLambdaToolResponseValidationStatusNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateToolRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.UpdateToolRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TestToolResponseDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.TestToolResponseDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TemplateTypeJsonConverter(),

                    new global::G.JsonConverters.TemplateTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InstructionDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.InstructionDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateInstructionRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreateInstructionRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateInstructionRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.UpdateInstructionRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolParametersProviderJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolParametersProviderNullableJsonConverter(),

                    new global::G.JsonConverters.WebGetToolParametersMethodJsonConverter(),

                    new global::G.JsonConverters.WebGetToolParametersMethodNullableJsonConverter(),

                    new global::G.JsonConverters.SubAgentSessionModeJsonConverter(),

                    new global::G.JsonConverters.SubAgentSessionModeNullableJsonConverter(),

                    new global::G.JsonConverters.ArtifactReadToolParametersEncodingJsonConverter(),

                    new global::G.JsonConverters.ArtifactReadToolParametersEncodingNullableJsonConverter(),

                    new global::G.JsonConverters.ImageReadToolParametersDetailJsonConverter(),

                    new global::G.JsonConverters.ImageReadToolParametersDetailNullableJsonConverter(),

                    new global::G.JsonConverters.DocumentConversionToolParametersOutputFormatJsonConverter(),

                    new global::G.JsonConverters.DocumentConversionToolParametersOutputFormatNullableJsonConverter(),

                    new global::G.JsonConverters.AgentToolConfigurationDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AgentToolConfigurationDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentStepInstructionDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AgentStepInstructionDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentOutputParserDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AgentOutputParserDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TemplatedReminderHookJsonConverter(),

                    new global::G.JsonConverters.TemplatedReminderHookNullableJsonConverter(),

                    new global::G.JsonConverters.AgentStepReminderDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AgentStepReminderDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CompactionConfigToolEventPolicyJsonConverter(),

                    new global::G.JsonConverters.CompactionConfigToolEventPolicyNullableJsonConverter(),

                    new global::G.JsonConverters.AgentInputDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AgentInputDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ImageReadEventVariant2DetailJsonConverter(),

                    new global::G.JsonConverters.ImageReadEventVariant2DetailNullableJsonConverter(),

                    new global::G.JsonConverters.AgentEventDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AgentEventDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputBehaviorJsonConverter(),

                    new global::G.JsonConverters.InputBehaviorNullableJsonConverter(),

                    new global::G.JsonConverters.CreateInputRequestDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreateInputRequestDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentStreamedResponseDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AgentStreamedResponseDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.IntervalScheduleConfigurationTypeJsonConverter(),

                    new global::G.JsonConverters.IntervalScheduleConfigurationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CronScheduleConfigurationTypeJsonConverter(),

                    new global::G.JsonConverters.CronScheduleConfigurationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AgentScheduleExecutionStatusJsonConverter(),

                    new global::G.JsonConverters.AgentScheduleExecutionStatusNullableJsonConverter(),

                    new global::G.JsonConverters.CreateCorpusDocumentWaitForJsonConverter(),

                    new global::G.JsonConverters.CreateCorpusDocumentWaitForNullableJsonConverter(),

                    new global::G.JsonConverters.ListToolServersTypeJsonConverter(),

                    new global::G.JsonConverters.ListToolServersTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListToolsTypeJsonConverter(),

                    new global::G.JsonConverters.ListToolsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListInstructionsTypeJsonConverter(),

                    new global::G.JsonConverters.ListInstructionsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListSessionArtifactsSortByJsonConverter(),

                    new global::G.JsonConverters.ListSessionArtifactsSortByNullableJsonConverter(),

                    new global::G.JsonConverters.ListSessionArtifactsOrderByJsonConverter(),

                    new global::G.JsonConverters.ListSessionArtifactsOrderByNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public AgentArtifactsClient AgentArtifacts => new AgentArtifactsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentEventsClient AgentEvents => new AgentEventsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentSchedulesClient AgentSchedules => new AgentSchedulesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentSessionsClient AgentSessions => new AgentSessionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public AppClientsClient AppClients => new AppClientsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// Authenticate with the API using OAuth 2.0 or API keys.
        /// </summary>
        public AuthenticationClient Authentication => new AuthenticationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public CorporaClient Corpora => new CorporaClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public DocumentsClient Documents => new DocumentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public EncodersClient Encoders => new EncodersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public FactualConsistencyClient FactualConsistency => new FactualConsistencyClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresetsClient GenerationPresets => new GenerationPresetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public HallucinationCorrectorsClient HallucinationCorrectors => new HallucinationCorrectorsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public InstructionsClient Instructions => new InstructionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm => new LlmClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlmsClient Llms => new LlmsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata => new MetadataClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public QueriesClient Queries => new QueriesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public QueryHistoryClient QueryHistory => new QueryHistoryClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankersClient Rerankers => new RerankersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public TableExtractorsClient TableExtractors => new TableExtractorsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolServersClient ToolServers => new ToolServersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public UploadClient Upload => new UploadClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKOAuth2State = AutoSDKOAuth2State,
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
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
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