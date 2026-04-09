//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API for AI-powered video and image generation, including text-to-video, image-to-video, video extension, lip sync, video effects, virtual try-on, and image generation.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.klingai.com/";

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
                    new global::G.JsonConverters.CameraControlTypeJsonConverter(),
                    new global::G.JsonConverters.CameraControlTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EffectsInputEffectSceneJsonConverter(),
                    new global::G.JsonConverters.EffectsInputEffectSceneNullableJsonConverter(),
                    new global::G.JsonConverters.TaskDataTaskStatusJsonConverter(),
                    new global::G.JsonConverters.TaskDataTaskStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TaskListDataTaskStatusJsonConverter(),
                    new global::G.JsonConverters.TaskListDataTaskStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestModelNameJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestModelNameNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestModeJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestModeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestAspectRatioJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestAspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestDurationJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestDurationNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestSoundJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestSoundNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestModelNameJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestModelNameNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestModeJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestModeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestAspectRatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestAspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestDurationJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestDurationNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestSoundJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestSoundNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAvatarRequestModeJsonConverter(),
                    new global::G.JsonConverters.CreateAvatarRequestModeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestModelNameJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestModelNameNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestImageReferenceJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestImageReferenceNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestAspectRatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestAspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestResolutionJsonConverter(),
                    new global::G.JsonConverters.CreateImageGenerationRequestResolutionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateMultiImageGenerationRequestAspectRatioJsonConverter(),
                    new global::G.JsonConverters.CreateMultiImageGenerationRequestAspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageExpansionRequestAspectRatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageExpansionRequestAspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVirtualTryOnRequestModelNameJsonConverter(),
                    new global::G.JsonConverters.CreateVirtualTryOnRequestModelNameNullableJsonConverter(),
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