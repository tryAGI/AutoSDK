//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the UniversalAPI to access all the Jina embedding models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "";

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
                    new global::G.JsonConverters.BulkEmbeddingJobStatusJsonConverter(),
                    new global::G.JsonConverters.BulkEmbeddingJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingInputEmbeddingTypeJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingInputEmbeddingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingInputEmbeddingTypeItemJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingInputEmbeddingTypeItemNullableJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingInputTaskJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingInputTaskNullableJsonConverter(),
                    new global::G.JsonConverters.ImageEmbeddingInputEmbeddingTypeJsonConverter(),
                    new global::G.JsonConverters.ImageEmbeddingInputEmbeddingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageEmbeddingInputEmbeddingTypeItemJsonConverter(),
                    new global::G.JsonConverters.ImageEmbeddingInputEmbeddingTypeItemNullableJsonConverter(),
                    new global::G.JsonConverters.MixedEmbeddingInputEmbeddingTypeJsonConverter(),
                    new global::G.JsonConverters.MixedEmbeddingInputEmbeddingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MixedEmbeddingInputEmbeddingTypeItemJsonConverter(),
                    new global::G.JsonConverters.MixedEmbeddingInputEmbeddingTypeItemNullableJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingAPIInputInputTypeJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingAPIInputInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeItemJsonConverter(),
                    new global::G.JsonConverters.TextEmbeddingAPIInputEmbeddingTypeItemNullableJsonConverter(),
                    new global::G.JsonConverters.TrainingAPIInputVisibilityJsonConverter(),
                    new global::G.JsonConverters.TrainingAPIInputVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory4(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory3(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.EmbeddingInputJsonConverter(),
                }
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
        public BulkEmbeddingsClient BulkEmbeddings => new BulkEmbeddingsClient(_httpClient, authorizations: _authorizations)
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
        /// 
        /// </summary>
        public ClassificationClient Classification => new ClassificationClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MultiVectorClient MultiVector => new MultiVectorClient(_httpClient, authorizations: _authorizations)
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