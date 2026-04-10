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
        /// Fish Audio API
        /// </summary>
        public const string DefaultBaseUrl = "https://api.fish.audio/";

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
                    new global::G.JsonConverters.TTSRequestFormatJsonConverter(),
                    new global::G.JsonConverters.TTSRequestFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TTSRequestLatencyJsonConverter(),
                    new global::G.JsonConverters.TTSRequestLatencyNullableJsonConverter(),
                    new global::G.JsonConverters.ModelEntityTypeJsonConverter(),
                    new global::G.JsonConverters.ModelEntityTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelEntityTrainModeJsonConverter(),
                    new global::G.JsonConverters.ModelEntityTrainModeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelEntityStateJsonConverter(),
                    new global::G.JsonConverters.ModelEntityStateNullableJsonConverter(),
                    new global::G.JsonConverters.ModelEntityVisibilityJsonConverter(),
                    new global::G.JsonConverters.ModelEntityVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestVisibilityJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestTypeJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestTrainModeJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestTrainModeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestVisibility2JsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestVisibility2NullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestType2JsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestType2NullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestTrainMode2JsonConverter(),
                    new global::G.JsonConverters.CreateModelRequestTrainMode2NullableJsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility2JsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility2NullableJsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility4JsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility4NullableJsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility6JsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility6NullableJsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility8JsonConverter(),
                    new global::G.JsonConverters.PatchModelRequestVisibility8NullableJsonConverter(),
                    new global::G.JsonConverters.CreateTtsModelJsonConverter(),
                    new global::G.JsonConverters.CreateTtsModelNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelSortByJsonConverter(),
                    new global::G.JsonConverters.GetModelSortByNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTtsResponseItemInJsonConverter(),
                    new global::G.JsonConverters.CreateTtsResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAsrResponseItemInJsonConverter(),
                    new global::G.JsonConverters.CreateAsrResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.GetWalletPackageResponseItemInJsonConverter(),
                    new global::G.JsonConverters.GetWalletPackageResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.GetWalletApiCreditResponseItemInJsonConverter(),
                    new global::G.JsonConverters.GetWalletApiCreditResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseItemInJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseTypeJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseTrainModeJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseTrainModeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseStateJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseStateNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseVisibilityJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseItemInJsonConverter(),
                    new global::G.JsonConverters.CreateModelResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseTypeJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseTrainModeJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseTrainModeNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseStateJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseStateNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseVisibilityJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelResponseItemIn2JsonConverter(),
                    new global::G.JsonConverters.GetModelResponseItemIn2NullableJsonConverter(),
                    new global::G.JsonConverters.PatchModelResponseItemInJsonConverter(),
                    new global::G.JsonConverters.PatchModelResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteModelResponseItemInJsonConverter(),
                    new global::G.JsonConverters.DeleteModelResponseItemInNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.ReferenceAudio>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public ModelClient Model => new ModelClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OpenAPIV1Client OpenAPIV1 => new OpenAPIV1Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WalletClient Wallet => new WalletClient(HttpClient, authorizations: Authorizations, options: Options)
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