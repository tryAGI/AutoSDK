//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API Spec for Anthropic API. Please see https://docs.anthropic.com/en/api for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.anthropic.com/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


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
                    new global::OpenApiGenerator.JsonConverters.CreateMessageRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateMessageRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolChoiceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolChoiceTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImageBlockSourceMediaTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImageBlockSourceMediaTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImageBlockSourceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImageBlockSourceTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StopReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StopReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory4(),
                    new global::OpenApiGenerator.JsonConverters.BlockJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BlockDeltaJsonConverter(),
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