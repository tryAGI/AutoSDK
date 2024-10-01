//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the API definition for Ideogram AI.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "";

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
                    new global::G.JsonConverters.AspectRatioJsonConverter(),
                    new global::G.JsonConverters.AspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.ModelEnumJsonConverter(),
                    new global::G.JsonConverters.ModelEnumNullableJsonConverter(),
                    new global::G.JsonConverters.MagicPromptOptionJsonConverter(),
                    new global::G.JsonConverters.MagicPromptOptionNullableJsonConverter(),
                    new global::G.JsonConverters.StyleTypeJsonConverter(),
                    new global::G.JsonConverters.StyleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResolutionJsonConverter(),
                    new global::G.JsonConverters.ResolutionNullableJsonConverter(),
                    new global::G.JsonConverters.ColorPalettePresetNameJsonConverter(),
                    new global::G.JsonConverters.ColorPalettePresetNameNullableJsonConverter(),
                    new global::G.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter(),
                }
            };


        /// <summary>
        /// All things related to generating content.
        /// </summary>
        public GenerateClient Generate => new GenerateClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Content related to managing API account and API access
        /// </summary>
        public ManageClient Manage => new ManageClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Operations related to understanding visual content
        /// </summary>
        public VisionClient Vision => new VisionClient(_httpClient, authorization: _authorization)
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
        /// <param name="authorization"></param>
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