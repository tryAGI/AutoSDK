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
                    new global::OpenApiGenerator.JsonConverters.SdVersionsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SdVersionsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StrengthJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StrengthNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.JobStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.JobStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MODELASSETTEXTURETYPESJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomModelTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomModelTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SdGenerationSchedulersJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SdGenerationSchedulersNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VARIATIONTYPEJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VARIATIONTYPENullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ControlnetInputInitImageTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ControlnetInputInitImageTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ControlnetInputStrengthTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ControlnetInputStrengthTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SdGenerationStyleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SdGenerationStyleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LcmGenerationStyleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LcmGenerationStyleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UniversalUpscalerStyleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UniversalUpscalerStyleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ControlnetTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ControlnetTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PricingCalculatorServicesJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PricingCalculatorServicesNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CanvasRequestTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CanvasRequestTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateGenerationRequestTransparencyJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateGenerationRequestTransparencyNullableJsonConverter(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

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