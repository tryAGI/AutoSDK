//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Reka API provides access to Reka's AI models for chat completions, model management, and speech transcription/translation.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Reka API
        /// </summary>
        public const string DefaultBaseUrl = "https://api.reka.ai";

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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestToolChoiceNullableJsonConverter(),
                    new global::G.JsonConverters.ParallelThinkingConfigModeJsonConverter(),
                    new global::G.JsonConverters.ParallelThinkingConfigModeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageInputRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageInputRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ContentPartTypeJsonConverter(),
                    new global::G.JsonConverters.ContentPartTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageOutputRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageOutputRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ReasoningStepRoleJsonConverter(),
                    new global::G.JsonConverters.ReasoningStepRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AnnotationTypeJsonConverter(),
                    new global::G.JsonConverters.AnnotationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TranscribeOrTranslateRequestTargetLanguageJsonConverter(),
                    new global::G.JsonConverters.TranscribeOrTranslateRequestTargetLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentPart>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, object>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Chat completion operations
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Model management operations
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Speech transcription and translation operations
        /// </summary>
        public SpeechClient Speech => new SpeechClient(HttpClient, authorizations: Authorizations)
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