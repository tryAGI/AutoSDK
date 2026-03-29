//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Upstage AI API provides access to Solar LLM for chat completions and embeddings,<br/>
    /// Document AI for document parsing, OCR, and layout analysis,<br/>
    /// and Groundedness Check for verifying response grounding.<br/>
    /// All endpoints require Bearer token authentication with an Upstage API key.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string DefaultBaseUrl = "https://api.upstage.ai/v1";

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
                    new global::G.JsonConverters.ChatCompletionRequestToolChoiceJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestToolChoiceNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatContentPartTypeJsonConverter(),
                    new global::G.JsonConverters.ChatContentPartTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatContentPartImageUrlDetailJsonConverter(),
                    new global::G.JsonConverters.ChatContentPartImageUrlDetailNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDeltaRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDeltaRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallChunkTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallChunkTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingResponseObjectJsonConverter(),
                    new global::G.JsonConverters.EmbeddingResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingDataObjectJsonConverter(),
                    new global::G.JsonConverters.EmbeddingDataObjectNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentElementTypeJsonConverter(),
                    new global::G.JsonConverters.DocumentElementTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LayoutElementTypeJsonConverter(),
                    new global::G.JsonConverters.LayoutElementTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentParseRequestOcrJsonConverter(),
                    new global::G.JsonConverters.DocumentParseRequestOcrNullableJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ChatCompletionRequestToolChoice?, global::G.ChatCompletionNamedToolChoice>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatContentPart>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
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
        public DocumentAIClient DocumentAI => new DocumentAIClient(HttpClient, authorizations: Authorizations)
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
        public GroundednessCheckClient GroundednessCheck => new GroundednessCheckClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranslationClient Translation => new TranslationClient(HttpClient, authorizations: Authorizations)
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