//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.EmbeddingFunctionConfigurationVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingFunctionConfigurationVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingFunctionConfigurationVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingFunctionConfigurationVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingFunctionConfigurationVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingFunctionConfigurationVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IncludeJsonConverter(),
                    new global::G.JsonConverters.IncludeNullableJsonConverter(),
                    new global::G.JsonConverters.KeyVariant1JsonConverter(),
                    new global::G.JsonConverters.KeyVariant1NullableJsonConverter(),
                    new global::G.JsonConverters.KeyVariant2JsonConverter(),
                    new global::G.JsonConverters.KeyVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.KeyVariant3JsonConverter(),
                    new global::G.JsonConverters.KeyVariant3NullableJsonConverter(),
                    new global::G.JsonConverters.KeyVariant4JsonConverter(),
                    new global::G.JsonConverters.KeyVariant4NullableJsonConverter(),
                    new global::G.JsonConverters.QuantizationJsonConverter(),
                    new global::G.JsonConverters.QuantizationNullableJsonConverter(),
                    new global::G.JsonConverters.ReadLevelJsonConverter(),
                    new global::G.JsonConverters.ReadLevelNullableJsonConverter(),
                    new global::G.JsonConverters.Space2JsonConverter(),
                    new global::G.JsonConverters.Space2NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteCollectionRecordsPayloadJsonConverter(),
                    new global::G.JsonConverters.EmbeddingFunctionConfigurationJsonConverter(),
                    new global::G.JsonConverters.EmbeddingsPayloadJsonConverter(),
                    new global::G.JsonConverters.GetRequestPayloadJsonConverter(),
                    new global::G.JsonConverters.KeyJsonConverter(),
                    new global::G.JsonConverters.QueryRequestPayloadJsonConverter(),
                    new global::G.JsonConverters.UpdateEmbeddingsPayloadJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::System.Guid?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.BoolInvertedIndexType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.Schema3>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.EmbeddingFunctionConfiguration?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HnswConfiguration>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.SpannConfiguration>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.CollectionConfiguration>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.Schema3>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.EmbeddingFunctionNewConfiguration, global::G.EmbeddingFunctionConfigurationVariant22>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.VectorIndexType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.FloatInvertedIndexType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<bool?, long?, double?, string, global::G.SparseVector, global::System.Collections.Generic.IList<bool>, global::System.Collections.Generic.IList<long>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.Space2?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.IntInvertedIndexType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.Space2?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.EmbeddingFunctionConfiguration?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.SparseVectorIndexType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.FtsIndexType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.StringInvertedIndexType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.EmbeddingFunctionConfiguration?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.UpdateHnswConfiguration>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.UpdateSpannConfiguration>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.UpdateCollectionConfiguration>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.UpdateEmbeddingsPayload?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.BoolValueType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.FloatValueType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.FloatListValueType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.IntValueType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.SparseVectorValueType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.StringValueType>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HashMap>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.Schema3>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.EmbeddingFunctionConfiguration?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.HnswIndexConfig>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.Space2?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<object, global::G.SpannIndexConfig>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AuthenticationClient Authentication => new AuthenticationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CollectionClient Collection => new CollectionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatabaseClient Database => new DatabaseClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FunctionClient Function => new FunctionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RecordClient Record => new RecordClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SystemClient System => new SystemClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant => new TenantClient(HttpClient, authorizations: Authorizations)
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