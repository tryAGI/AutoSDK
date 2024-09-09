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
                    new global::AutoSDK.JsonConverters.RerankResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.RerankResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CompletionResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.CompletionResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StreamSentinelDataJsonConverter(),
                    new global::AutoSDK.JsonConverters.StreamSentinelDataNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolChoiceTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolChoiceTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionChunkObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingsResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelInfoTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelInfoTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ImageResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ImageResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FileResponsePurposeJsonConverter(),
                    new global::AutoSDK.JsonConverters.FileResponsePurposeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FileResponseFileTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.FileResponseFileTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneJobStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneJobStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneEventObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneEventObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneEventLevelsJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneEventLevelsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneEventTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneEventTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuneEventObject2JsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuneEventObject2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuneEventLevelJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuneEventLevelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuneEventType2JsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuneEventType2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneDownloadResultObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinetuneDownloadResultObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.CompletionStreamJsonConverter(),
                    new global::AutoSDK.JsonConverters.AllOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.ChatCompletionMessageParamJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionStreamJsonConverter(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory1(),
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