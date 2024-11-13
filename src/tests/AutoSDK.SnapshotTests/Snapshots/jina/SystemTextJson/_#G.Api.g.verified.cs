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
        public const string DefaultBaseUrl = "";

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
                    new global::G.JsonConverters.EmbeddingInputJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string>>, global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, byte[]>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.TextEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingInputEmbeddingTypeItem>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ApiSchemasEmbeddingImageDoc, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingImageDoc>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, byte[]>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.ImageEmbeddingInputEmbeddingTypeItem>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ApiSchemasEmbeddingImageDoc, global::G.ApiSchemasEmbeddingTextDoc, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MixedEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.MixedEmbeddingInputEmbeddingTypeItem>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, byte[]>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ApiSchemasRankTextDoc>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.ApiSchemasRankTextDoc>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingAPIInputEmbeddingTypeItem>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.TextExampleDoc, global::G.ImageExampleDoc>(),
                }
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
        public BulkEmbeddingsClient BulkEmbeddings => new BulkEmbeddingsClient(HttpClient, authorizations: Authorizations)
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
        /// 
        /// </summary>
        public ClassificationClient Classification => new ClassificationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MultiVectorClient MultiVector => new MultiVectorClient(HttpClient, authorizations: Authorizations)
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