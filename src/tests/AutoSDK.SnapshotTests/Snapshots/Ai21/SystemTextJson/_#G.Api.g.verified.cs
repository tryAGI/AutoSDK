//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access our powerful language models using an API that makes you smile<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.ai21.com/";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// 
        /// </summary>
        public JambaCompleteClient JambaComplete => new JambaCompleteClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion => new CompletionClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public CustomModelsClient CustomModels => new CustomModelsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ParaphraseClient Paraphrase => new ParaphraseClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public SummarizeClient Summarize => new SummarizeClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public SegmentationClient Segmentation => new SegmentationClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public GrammaticalErrorCorrectionsClient GrammaticalErrorCorrections => new GrammaticalErrorCorrectionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public LibraryManagementClient LibraryManagement => new LibraryManagementClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public RAGEngineClient RAGEngine => new RAGEngineClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public TokenizeClient Tokenize => new TokenizeClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::AutoSDK.JsonConverters.AnswerLengthJsonConverter(),
                    new global::AutoSDK.JsonConverters.AnswerLengthNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolCallTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolCallTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RoleTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RoleTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ConversationalRagFlowPublicFieldsRetrievalStrategyJsonConverter(),
                    new global::AutoSDK.JsonConverters.ConversationalRagFlowPublicFieldsRetrievalStrategyNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CorrectionTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CorrectionTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomModelTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomModelTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DocumentTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.DocumentTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FileStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.FileStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolParametersTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolParametersTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RetrievalStrategy3JsonConverter(),
                    new global::AutoSDK.JsonConverters.RetrievalStrategy3NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelNameJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelNameNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StyleTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.StyleTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummaryMethodJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummaryMethodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SystemMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.SystemMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolDefinitionTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolDefinitionTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.AllOfJsonConverterFactory1(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory4(),
                }
            };

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
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