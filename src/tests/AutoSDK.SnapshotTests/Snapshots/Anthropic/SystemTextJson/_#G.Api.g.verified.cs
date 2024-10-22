//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API Spec for Anthropic API. Please see https://docs.anthropic.com/en/api for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.anthropic.com/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.CreateMessageRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateMessageRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.ImageBlockSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.ImageBlockSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageBlockSourceTypeJsonConverter(),
                    new global::G.JsonConverters.ImageBlockSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BlockDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BlockDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageRoleJsonConverter(),
                    new global::G.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.StopReasonJsonConverter(),
                    new global::G.JsonConverters.StopReasonNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventTypeJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BlockDeltaDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BlockDeltaDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::G.JsonConverters.BlockJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventJsonConverter(),
                    new global::G.JsonConverters.BlockDeltaJsonConverter(),
                }
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
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
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