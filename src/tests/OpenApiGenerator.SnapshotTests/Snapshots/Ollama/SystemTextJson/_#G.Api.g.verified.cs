//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API Spec for Ollama API. Please see https://github.com/jmorganca/ollama/blob/main/docs/api.md for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// Ollama server URL
        /// </summary>
        public const string BaseUrl = "http://localhost:11434/api";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Given a prompt, the model will generate a completion.
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Get a vector representation of a given input.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// List and describe the various models available.
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

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
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneReasonEnumJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneReasonEnumNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelStatusEnumJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelStatusEnumNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelStatusEnumJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelStatusEnumNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelStatusEnumJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelStatusEnumNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelStatusJsonConverter(),
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