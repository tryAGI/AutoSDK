//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// use tripo to generate 3d models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.tripo3d.ai/v2/openapi";

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
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.TaskStatusJsonConverter(),
                    new global::G.JsonConverters.TaskStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant1ModelVersionJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant1ModelVersionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant2ModelVersionJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant2ModelVersionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant3ModeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant3ModeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant3ModelVersionJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant3ModelVersionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant5TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant5TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant6TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant6TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant7TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant7TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant7AnimationJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant7AnimationNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant8TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant8TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant8StyleJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant8StyleNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant9TypeJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant9TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant9FormatJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant9FormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant9TextureFormatJsonConverter(),
                    new global::G.JsonConverters.CreateTaskRequestVariant9TextureFormatNullableJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CreateTaskRequestVariant1, global::G.CreateTaskRequestVariant2, global::G.CreateTaskRequestVariant3, global::G.CreateTaskRequestVariant4, global::G.CreateTaskRequestVariant5, global::G.CreateTaskRequestVariant6, global::G.CreateTaskRequestVariant7, global::G.CreateTaskRequestVariant8, global::G.CreateTaskRequestVariant9>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
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