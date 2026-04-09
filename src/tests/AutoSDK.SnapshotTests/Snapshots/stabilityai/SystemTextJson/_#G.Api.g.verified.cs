//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Welcome to the Stability.ai REST API!<br/>
    /// Your DreamStudio API key will be required for authentication: [How to find your API key](https://platform.stability.ai/docs/getting-started/authentication)<br/>
    /// API operations use the following versioning scheme:<br/>
    /// - `/v*` interface is stable and ready for production workloads<br/>
    /// - `/v*beta*`: interface is stable, preparing for production release<br/>
    /// - `/v*alpha*`: under development and the interface is subject to change<br/>
    /// NOTE: The v1alpha and v1beta endpoints from the developer preview are still available, but they<br/>
    /// will disabled on May 1st, 2023.  Please migrate to the v1 endpoints as soon as possible.<br/>
    /// If you have feedback or encounter any issues with the API, please reach out:<br/>
    ///   - [https://github.com/Stability-AI/REST-API](https://github.com/Stability-AI/REST-API)<br/>
    ///   - [https://discord.gg/stablediffusion #API channel](https://discord.com/channels/1002292111942635562/1042896447311454361)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.stability.ai/";

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
                    new global::G.JsonConverters.EngineTypeJsonConverter(),
                    new global::G.JsonConverters.EngineTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClipGuidancePresetJsonConverter(),
                    new global::G.JsonConverters.ClipGuidancePresetNullableJsonConverter(),
                    new global::G.JsonConverters.SamplerJsonConverter(),
                    new global::G.JsonConverters.SamplerNullableJsonConverter(),
                    new global::G.JsonConverters.InitImageModeJsonConverter(),
                    new global::G.JsonConverters.InitImageModeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageToImageRequestBodyDiscriminatorInitImageModeJsonConverter(),
                    new global::G.JsonConverters.ImageToImageRequestBodyDiscriminatorInitImageModeNullableJsonConverter(),
                    new global::G.JsonConverters.MaskingRequestBodyDiscriminatorMaskSourceJsonConverter(),
                    new global::G.JsonConverters.MaskingRequestBodyDiscriminatorMaskSourceNullableJsonConverter(),
                    new global::G.JsonConverters.FinishReasonJsonConverter(),
                    new global::G.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.ImageFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ImageFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.TextToImageAcceptJsonConverter(),
                    new global::G.JsonConverters.TextToImageAcceptNullableJsonConverter(),
                    new global::G.JsonConverters.ImageToImageAcceptJsonConverter(),
                    new global::G.JsonConverters.ImageToImageAcceptNullableJsonConverter(),
                    new global::G.JsonConverters.UpscaleImageAcceptJsonConverter(),
                    new global::G.JsonConverters.UpscaleImageAcceptNullableJsonConverter(),
                    new global::G.JsonConverters.MaskingAcceptJsonConverter(),
                    new global::G.JsonConverters.MaskingAcceptNullableJsonConverter(),
                    new global::G.JsonConverters.ImageToImageUsingImageStrengthRequestBodyJsonConverter(),
                    new global::G.JsonConverters.ImageToImageUsingStepScheduleRequestBodyJsonConverter(),
                    new global::G.JsonConverters.MaskingUsingMaskImageRequestBodyJsonConverter(),
                    new global::G.JsonConverters.MaskingUsingInitImageAlphaRequestBodyJsonConverter(),
                    new global::G.JsonConverters.TextToImageRequestBodyJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Enumerate available engines.
        /// </summary>
        public V1EnginesClient V1Engines => new V1EnginesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Generate images from text, existing images, or both.
        /// </summary>
        public V1GenerationClient V1Generation => new V1GenerationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage your Stability.ai account, and view account/organization balances.
        /// </summary>
        public V1UserClient V1User => new V1UserClient(HttpClient, authorizations: Authorizations, options: Options)
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