//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Together REST API. Please see https://docs.together.ai for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.together.xyz/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::G.EndPointAuthorization> _authorizations;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter(),
                    new global::G.JsonConverters.FinishReason2JsonConverter(),
                    new global::G.JsonConverters.FinishReason2NullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkChoiceDeltaRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkChoiceDeltaRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkObjectJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionFunctionMessageParamRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionFunctionMessageParamRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionSystemMessageParamRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionSystemMessageParamRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionUserMessageParamRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionUserMessageParamRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolMessageParamRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolMessageParamRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestFunctionCallEnumJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestFunctionCallEnumNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.StreamSentinelDataJsonConverter(),
                    new global::G.JsonConverters.StreamSentinelDataNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CompletionResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CompletionResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingsResponseDataItemObjectJsonConverter(),
                    new global::G.JsonConverters.EmbeddingsResponseDataItemObjectNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingsResponseObjectJsonConverter(),
                    new global::G.JsonConverters.EmbeddingsResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FileResponseFileTypeJsonConverter(),
                    new global::G.JsonConverters.FileResponseFileTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileResponsePurposeJsonConverter(),
                    new global::G.JsonConverters.FileResponsePurposeNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuneEventLevelJsonConverter(),
                    new global::G.JsonConverters.FineTuneEventLevelNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuneEventObjectJsonConverter(),
                    new global::G.JsonConverters.FineTuneEventObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuneEventTypeJsonConverter(),
                    new global::G.JsonConverters.FineTuneEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FinetuneDownloadResultObjectJsonConverter(),
                    new global::G.JsonConverters.FinetuneDownloadResultObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FinetuneEventLevelsJsonConverter(),
                    new global::G.JsonConverters.FinetuneEventLevelsNullableJsonConverter(),
                    new global::G.JsonConverters.FinetuneEventObject2JsonConverter(),
                    new global::G.JsonConverters.FinetuneEventObject2NullableJsonConverter(),
                    new global::G.JsonConverters.FinetuneEventType2JsonConverter(),
                    new global::G.JsonConverters.FinetuneEventType2NullableJsonConverter(),
                    new global::G.JsonConverters.FinetuneJobStatusJsonConverter(),
                    new global::G.JsonConverters.FinetuneJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.FullTrainingTypeTypeJsonConverter(),
                    new global::G.JsonConverters.FullTrainingTypeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LoRATrainingTypeTypeJsonConverter(),
                    new global::G.JsonConverters.LoRATrainingTypeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ImageResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ModelInfoTypeJsonConverter(),
                    new global::G.JsonConverters.ModelInfoTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RerankResponseObjectJsonConverter(),
                    new global::G.JsonConverters.RerankResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.AllOfJsonConverterFactory2(),
                    new global::G.JsonConverters.ChatCompletionMessageParamJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::G.JsonConverters.ChatCompletionStreamJsonConverter(),
                    new global::G.JsonConverters.CompletionStreamJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion => new CompletionClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images => new ImagesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank => new RerankClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();

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