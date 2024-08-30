//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Together REST API. Please see https://docs.together.ai for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.together.xyz/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion => new CompletionClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images => new ImagesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank => new RerankClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

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
                    new global::OpenApiGenerator.JsonConverters.RerankResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RerankResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CompletionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CompletionResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StreamSentinelDataJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StreamSentinelDataNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolChoiceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolChoiceTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionChunkObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelInfoTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelInfoTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImageResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImageResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FileResponsePurposeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FileResponsePurposeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FileResponseFileTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FileResponseFileTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneJobStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneJobStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneEventObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneEventObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneEventLevelsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneEventLevelsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneEventTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneEventTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuneEventObject2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuneEventObject2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuneEventLevelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuneEventLevelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuneEventType2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuneEventType2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneDownloadResultObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinetuneDownloadResultObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.CompletionStreamJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageParamJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionStreamJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory1(),
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