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
        public const string DefaultBaseUrl = "file:///web-app";

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

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }
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
                    new global::G.JsonConverters.AssetAsset1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AssetAsset1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AssetTypeJsonConverter(),
                    new global::G.JsonConverters.AssetTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ErrorCodeJsonConverter(),
                    new global::G.JsonConverters.ErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateImageRequestTypeJsonConverter(),
                    new global::G.JsonConverters.GenerateImageRequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateImageResponseTypeJsonConverter(),
                    new global::G.JsonConverters.GenerateImageResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GeneratedVideoInputsCharacterOrientation2JsonConverter(),
                    new global::G.JsonConverters.GeneratedVideoInputsCharacterOrientation2NullableJsonConverter(),
                    new global::G.JsonConverters.GenerationInputDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GenerationInputDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerationStatusJsonConverter(),
                    new global::G.JsonConverters.GenerationStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GenerationTypeJsonConverter(),
                    new global::G.JsonConverters.GenerationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SupportedLanguageJsonConverter(),
                    new global::G.JsonConverters.SupportedLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.Asset1JsonConverter(),
                    new global::G.JsonConverters.InputJsonConverter(),
                    new global::G.JsonConverters.GenerateAssetPublicGenerationsPostRequestJsonConverter(),
                    new global::G.JsonConverters.GenerateAssetPublicGenerationsPostResponseJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AssetType?, global::G.GenerationType?, object>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


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
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
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