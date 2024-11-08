//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access our powerful language models using an API that makes you smile<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "";

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
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.AnswerLengthJsonConverter(),
                    new global::G.JsonConverters.AnswerLengthNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageRoleJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter(),
                    new global::G.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter(),
                    new global::G.JsonConverters.RoleTypeJsonConverter(),
                    new global::G.JsonConverters.RoleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConnectorsWorkflowStatusJsonConverter(),
                    new global::G.JsonConverters.ConnectorsWorkflowStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MessageRoleJsonConverter(),
                    new global::G.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationalRagConfigRetrievalStrategyJsonConverter(),
                    new global::G.JsonConverters.ConversationalRagConfigRetrievalStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.CustomModelTypeJsonConverter(),
                    new global::G.JsonConverters.CustomModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentTypeJsonConverter(),
                    new global::G.JsonConverters.DocumentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileStatusJsonConverter(),
                    new global::G.JsonConverters.FileStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ToolParametersTypeJsonConverter(),
                    new global::G.JsonConverters.ToolParametersTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LibraryAnswerRequestLabelsFilterModeJsonConverter(),
                    new global::G.JsonConverters.LibraryAnswerRequestLabelsFilterModeNullableJsonConverter(),
                    new global::G.JsonConverters.ModeJsonConverter(),
                    new global::G.JsonConverters.ModeNullableJsonConverter(),
                    new global::G.JsonConverters.RetrievalStrategyJsonConverter(),
                    new global::G.JsonConverters.RetrievalStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.LibrarySearchRequestLabelsFilterModeJsonConverter(),
                    new global::G.JsonConverters.LibrarySearchRequestLabelsFilterModeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelNameJsonConverter(),
                    new global::G.JsonConverters.ModelNameNullableJsonConverter(),
                    new global::G.JsonConverters.StyleTypeJsonConverter(),
                    new global::G.JsonConverters.StyleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SummaryMethodJsonConverter(),
                    new global::G.JsonConverters.SummaryMethodNullableJsonConverter(),
                    new global::G.JsonConverters.SystemMessageRoleJsonConverter(),
                    new global::G.JsonConverters.SystemMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ToolDefinitionTypeJsonConverter(),
                    new global::G.JsonConverters.ToolDefinitionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ToolMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.UserMessageRoleJsonConverter(),
                    new global::G.JsonConverters.UserMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleJsonConverter(),
                    new global::G.JsonConverters.LanguageStudioApiServerDataTypesChatChatRequestMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.QueryFilterJsonConverter(),
                    new global::G.JsonConverters.MessagesItemJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public JambaCompleteClient JambaComplete => new JambaCompleteClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion => new CompletionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomModelsClient CustomModels => new CustomModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ParaphraseClient Paraphrase => new ParaphraseClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SummarizeClient Summarize => new SummarizeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SegmentationClient Segmentation => new SegmentationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LibraryManagementClient LibraryManagement => new LibraryManagementClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RAGEngineClient RAGEngine => new RAGEngineClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
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