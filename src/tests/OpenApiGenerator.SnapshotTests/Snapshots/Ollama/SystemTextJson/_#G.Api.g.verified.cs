//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API Spec for Ollama API. Please see https://github.com/jmorganca/ollama/blob/main/docs/api.md for more details.
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
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
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("http://localhost:11434/api");
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::OpenApiGenerator.JsonConverters.GenerateCompletionRequestFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateCompletionRequestFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateChatCompletionRequestFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateChatCompletionRequestFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelResponseStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelResponseStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelStatusVariant1JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelStatusVariant1NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelResponseStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelResponseStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelStatusVariant1JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PullModelStatusVariant1NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelResponseStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelResponseStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelStatusVariant1JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PushModelStatusVariant1NullableJsonConverter(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}