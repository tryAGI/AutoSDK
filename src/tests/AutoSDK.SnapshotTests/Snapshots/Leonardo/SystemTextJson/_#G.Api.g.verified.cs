//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Leonardo.Ai API OpenAPI specification.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Leonardo.Ai API server
        /// </summary>
        public const string BaseUrl = "https://cloud.leonardo.ai/api/rest/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::G.EndPointAuthorization? _authorization;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.SdVersionsJsonConverter(),
                    new global::G.JsonConverters.SdVersionsNullableJsonConverter(),
                    new global::G.JsonConverters.StrengthJsonConverter(),
                    new global::G.JsonConverters.StrengthNullableJsonConverter(),
                    new global::G.JsonConverters.JobStatusJsonConverter(),
                    new global::G.JsonConverters.JobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MODELASSETTEXTURETYPESJsonConverter(),
                    new global::G.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter(),
                    new global::G.JsonConverters.CustomModelTypeJsonConverter(),
                    new global::G.JsonConverters.CustomModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SdGenerationSchedulersJsonConverter(),
                    new global::G.JsonConverters.SdGenerationSchedulersNullableJsonConverter(),
                    new global::G.JsonConverters.VARIATIONTYPEJsonConverter(),
                    new global::G.JsonConverters.VARIATIONTYPENullableJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputInitImageTypeJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputInitImageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputStrengthTypeJsonConverter(),
                    new global::G.JsonConverters.ControlnetInputStrengthTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SdGenerationStyleJsonConverter(),
                    new global::G.JsonConverters.SdGenerationStyleNullableJsonConverter(),
                    new global::G.JsonConverters.LcmGenerationStyleJsonConverter(),
                    new global::G.JsonConverters.LcmGenerationStyleNullableJsonConverter(),
                    new global::G.JsonConverters.UniversalUpscalerStyleJsonConverter(),
                    new global::G.JsonConverters.UniversalUpscalerStyleNullableJsonConverter(),
                    new global::G.JsonConverters.ControlnetTypeJsonConverter(),
                    new global::G.JsonConverters.ControlnetTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PricingCalculatorServicesJsonConverter(),
                    new global::G.JsonConverters.PricingCalculatorServicesNullableJsonConverter(),
                    new global::G.JsonConverters.CanvasRequestTypeJsonConverter(),
                    new global::G.JsonConverters.CanvasRequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateGenerationRequestTransparencyJsonConverter(),
                    new global::G.JsonConverters.CreateGenerationRequestTransparencyNullableJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset => new DatasetClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ElementsClient Elements => new ElementsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImageClient Image => new ImageClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InitImagesClient InitImages => new InitImagesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MotionClient Motion => new MotionClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PricingCalculatorClient PricingCalculator => new PricingCalculatorClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RealtimeCanvasClient RealtimeCanvas => new RealtimeCanvasClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextureClient Texture => new TextureClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VariationClient Variation => new VariationClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public x3DModelAssetsClient x3DModelAssets => new x3DModelAssetsClient(_httpClient, authorization: _authorization)
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
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::G.EndPointAuthorization? authorization = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

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