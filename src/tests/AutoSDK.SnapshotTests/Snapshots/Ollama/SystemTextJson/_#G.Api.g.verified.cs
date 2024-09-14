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

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ResponseFormatJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.MessageRoleJsonConverter(),
                    new global::G.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.DoneReasonEnumJsonConverter(),
                    new global::G.JsonConverters.DoneReasonEnumNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelStatusEnumJsonConverter(),
                    new global::G.JsonConverters.CreateModelStatusEnumNullableJsonConverter(),
                    new global::G.JsonConverters.PullModelStatusEnumJsonConverter(),
                    new global::G.JsonConverters.PullModelStatusEnumNullableJsonConverter(),
                    new global::G.JsonConverters.PushModelStatusEnumJsonConverter(),
                    new global::G.JsonConverters.PushModelStatusEnumNullableJsonConverter(),
                    new global::G.JsonConverters.DoneReasonJsonConverter(),
                    new global::G.JsonConverters.CreateModelStatusJsonConverter(),
                    new global::G.JsonConverters.PullModelStatusJsonConverter(),
                    new global::G.JsonConverters.PushModelStatusJsonConverter(),
                }
            };


        /// <summary>
        /// Given a prompt, the model will generate a completion.
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get a vector representation of a given input.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and describe the various models available.
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient)
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
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

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