//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Humanloop is a platform for prompt management, evaluation, and observability.<br/>
    /// It provides tools for versioning prompts, running evaluations, managing datasets,<br/>
    /// and logging LLM interactions.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Production API
        /// </summary>
        public const string DefaultBaseUrl = "https://api.humanloop.com/v5";

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
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.MonitoringEvaluatorResponseStateJsonConverter(),
                    new global::G.JsonConverters.MonitoringEvaluatorResponseStateNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.PromptResponseTypeJsonConverter(),
                    new global::G.JsonConverters.PromptResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetResponseTypeJsonConverter(),
                    new global::G.JsonConverters.DatasetResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EvaluatorResponseTypeJsonConverter(),
                    new global::G.JsonConverters.EvaluatorResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EvaluationResponseStatusJsonConverter(),
                    new global::G.JsonConverters.EvaluationResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ToolResponseTypeJsonConverter(),
                    new global::G.JsonConverters.ToolResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FlowResponseTypeJsonConverter(),
                    new global::G.JsonConverters.FlowResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentResponseTypeJsonConverter(),
                    new global::G.JsonConverters.AgentResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateEvaluationStatusRequestStatusJsonConverter(),
                    new global::G.JsonConverters.UpdateEvaluationStatusRequestStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EvaluationRunResponseStatusJsonConverter(),
                    new global::G.JsonConverters.EvaluationRunResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ListPromptsOrderJsonConverter(),
                    new global::G.JsonConverters.ListPromptsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListDatasetsOrderJsonConverter(),
                    new global::G.JsonConverters.ListDatasetsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListEvaluatorsOrderJsonConverter(),
                    new global::G.JsonConverters.ListEvaluatorsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListToolsOrderJsonConverter(),
                    new global::G.JsonConverters.ListToolsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFlowsOrderJsonConverter(),
                    new global::G.JsonConverters.ListFlowsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesTypeJsonConverter(),
                    new global::G.JsonConverters.ListFilesTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesOrderJsonConverter(),
                    new global::G.JsonConverters.ListFilesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DirectoriesClient Directories => new DirectoriesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluationsClient Evaluations => new EvaluationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluatorsClient Evaluators => new EvaluatorsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FlowsClient Flows => new FlowsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations, options: Options)
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