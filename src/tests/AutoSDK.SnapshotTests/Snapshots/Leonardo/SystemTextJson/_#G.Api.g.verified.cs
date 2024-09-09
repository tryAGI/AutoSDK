//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Leonardo.Ai API OpenAPI specification.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// Leonardo.Ai API server
        /// </summary>
        public const string BaseUrl = "https://cloud.leonardo.ai/api/rest/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset => new DatasetClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ElementsClient Elements => new ElementsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ImageClient Image => new ImageClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public InitImagesClient InitImages => new InitImagesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public MotionClient Motion => new MotionClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public PricingCalculatorClient PricingCalculator => new PricingCalculatorClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public RealtimeCanvasClient RealtimeCanvas => new RealtimeCanvasClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public TextureClient Texture => new TextureClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public VariationClient Variation => new VariationClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public x3DModelAssetsClient x3DModelAssets => new x3DModelAssetsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

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
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::AutoSDK.JsonConverters.SdVersionsJsonConverter(),
                    new global::AutoSDK.JsonConverters.SdVersionsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StrengthJsonConverter(),
                    new global::AutoSDK.JsonConverters.StrengthNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.JobStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.JobStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MODELASSETTEXTURETYPESJsonConverter(),
                    new global::AutoSDK.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomModelTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomModelTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SdGenerationSchedulersJsonConverter(),
                    new global::AutoSDK.JsonConverters.SdGenerationSchedulersNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VARIATIONTYPEJsonConverter(),
                    new global::AutoSDK.JsonConverters.VARIATIONTYPENullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ControlnetInputInitImageTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ControlnetInputInitImageTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ControlnetInputStrengthTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ControlnetInputStrengthTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SdGenerationStyleJsonConverter(),
                    new global::AutoSDK.JsonConverters.SdGenerationStyleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.LcmGenerationStyleJsonConverter(),
                    new global::AutoSDK.JsonConverters.LcmGenerationStyleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UniversalUpscalerStyleJsonConverter(),
                    new global::AutoSDK.JsonConverters.UniversalUpscalerStyleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ControlnetTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ControlnetTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.PricingCalculatorServicesJsonConverter(),
                    new global::AutoSDK.JsonConverters.PricingCalculatorServicesNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CanvasRequestTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CanvasRequestTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateGenerationRequestTransparencyJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateGenerationRequestTransparencyNullableJsonConverter(),
                }
            };

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