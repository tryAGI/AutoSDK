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
        public const string DefaultBaseUrl = "https://api.together.xyz/v1";

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
                    new global::G.JsonConverters.ChatCompletionAssistantMessageParamRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionAssistantMessageParamRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceDeltaRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceDeltaRoleNullableJsonConverter(),
                    new global::G.JsonConverters.FinishReasonJsonConverter(),
                    new global::G.JsonConverters.FinishReasonNullableJsonConverter(),
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
                    new global::G.JsonConverters.ChatCompletionMessageParamDiscriminatorRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamDiscriminatorRoleNullableJsonConverter(),
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
                    new global::G.JsonConverters.FinetuneResponseTrainingTypeDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.FinetuneResponseTrainingTypeDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ImageResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ModelInfoTypeJsonConverter(),
                    new global::G.JsonConverters.ModelInfoTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RerankResponseObjectJsonConverter(),
                    new global::G.JsonConverters.RerankResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionStreamJsonConverter(),
                    new global::G.JsonConverters.CompletionStreamJsonConverter(),
                    new global::G.JsonConverters.FinetuneResponseTrainingTypeJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ChatCompletionRequestFunctionCallEnum?, global::G.ChatCompletionRequestFunctionCallEnum2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::G.ToolChoice2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.FullTrainingType, global::G.LoRATrainingType>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
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
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank => new RerankClient(HttpClient, authorizations: Authorizations)
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