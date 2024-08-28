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
                    new global::OpenApiGenerator.JsonConverters.AnswerLengthJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AnswerLengthNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolCallTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolCallTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamingFirstDeltaRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamingFirstDeltaRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RoleTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RoleTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ConversationalRagFlowPublicFieldsRetrievalStrategyJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ConversationalRagFlowPublicFieldsRetrievalStrategyNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CorrectionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CorrectionTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomModelTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomModelTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DocumentTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DocumentTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FileStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FileStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolParametersTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolParametersTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RetrievalStrategy3JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RetrievalStrategy3NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelNameJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelNameNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StyleTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StyleTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummaryMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummaryMethodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SystemMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SystemMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolDefinitionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolDefinitionTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory4(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

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