//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API for AI-powered 3D and 2D content generation<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.meshy.ai/";

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
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.TaskStatusJsonConverter(),

                    new global::G.JsonConverters.TaskStatusNullableJsonConverter(),

                    new global::G.JsonConverters.AiModelJsonConverter(),

                    new global::G.JsonConverters.AiModelNullableJsonConverter(),

                    new global::G.JsonConverters.ModelTypeJsonConverter(),

                    new global::G.JsonConverters.ModelTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TopologyJsonConverter(),

                    new global::G.JsonConverters.TopologyNullableJsonConverter(),

                    new global::G.JsonConverters.SymmetryModeJsonConverter(),

                    new global::G.JsonConverters.SymmetryModeNullableJsonConverter(),

                    new global::G.JsonConverters.PoseModeJsonConverter(),

                    new global::G.JsonConverters.PoseModeNullableJsonConverter(),

                    new global::G.JsonConverters.TargetFormat3DJsonConverter(),

                    new global::G.JsonConverters.TargetFormat3DNullableJsonConverter(),

                    new global::G.JsonConverters.TargetFormatRemeshJsonConverter(),

                    new global::G.JsonConverters.TargetFormatRemeshNullableJsonConverter(),

                    new global::G.JsonConverters.OriginAtJsonConverter(),

                    new global::G.JsonConverters.OriginAtNullableJsonConverter(),

                    new global::G.JsonConverters.ImageAiModelJsonConverter(),

                    new global::G.JsonConverters.ImageAiModelNullableJsonConverter(),

                    new global::G.JsonConverters.AspectRatioJsonConverter(),

                    new global::G.JsonConverters.AspectRatioNullableJsonConverter(),

                    new global::G.JsonConverters.TextTo3DPreviewRequestModeJsonConverter(),

                    new global::G.JsonConverters.TextTo3DPreviewRequestModeNullableJsonConverter(),

                    new global::G.JsonConverters.TextTo3DPreviewRequestArtStyleJsonConverter(),

                    new global::G.JsonConverters.TextTo3DPreviewRequestArtStyleNullableJsonConverter(),

                    new global::G.JsonConverters.TextTo3DRefineRequestModeJsonConverter(),

                    new global::G.JsonConverters.TextTo3DRefineRequestModeNullableJsonConverter(),

                    new global::G.JsonConverters.TextToImageRequestPoseModeJsonConverter(),

                    new global::G.JsonConverters.TextToImageRequestPoseModeNullableJsonConverter(),

                    new global::G.JsonConverters.RemeshTaskStatusJsonConverter(),

                    new global::G.JsonConverters.RemeshTaskStatusNullableJsonConverter(),

                    new global::G.JsonConverters.AnimationPostProcessOperationTypeJsonConverter(),

                    new global::G.JsonConverters.AnimationPostProcessOperationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateTextTo3DTaskRequestDiscriminatorModeJsonConverter(),

                    new global::G.JsonConverters.CreateTextTo3DTaskRequestDiscriminatorModeNullableJsonConverter(),

                    new global::G.JsonConverters.ListTextTo3DTasksSortByJsonConverter(),

                    new global::G.JsonConverters.ListTextTo3DTasksSortByNullableJsonConverter(),

                    new global::G.JsonConverters.ListImageTo3DTasksSortByJsonConverter(),

                    new global::G.JsonConverters.ListImageTo3DTasksSortByNullableJsonConverter(),

                    new global::G.JsonConverters.ListMultiImageTo3DTasksSortByJsonConverter(),

                    new global::G.JsonConverters.ListMultiImageTo3DTasksSortByNullableJsonConverter(),

                    new global::G.JsonConverters.ListTextToImageTasksSortByJsonConverter(),

                    new global::G.JsonConverters.ListTextToImageTasksSortByNullableJsonConverter(),

                    new global::G.JsonConverters.ListImageToImageTasksSortByJsonConverter(),

                    new global::G.JsonConverters.ListImageToImageTasksSortByNullableJsonConverter(),

                    new global::G.JsonConverters.ListRemeshTasksSortByJsonConverter(),

                    new global::G.JsonConverters.ListRemeshTasksSortByNullableJsonConverter(),

                    new global::G.JsonConverters.ListRetextureTasksSortByJsonConverter(),

                    new global::G.JsonConverters.ListRetextureTasksSortByNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public AnimationClient Animation => new AnimationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BalanceClient Balance => new BalanceClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImageTo3dClient ImageTo3d => new ImageTo3dClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageClient ImageToImage => new ImageToImageClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MultiImageTo3dClient MultiImageTo3d => new MultiImageTo3dClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RemeshClient Remesh => new RemeshClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RetextureClient Retexture => new RetextureClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RiggingClient Rigging => new RiggingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextTo3dClient TextTo3d => new TextTo3dClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToImageClient TextToImage => new TextToImageClient(HttpClient, authorizations: Authorizations, options: Options)
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