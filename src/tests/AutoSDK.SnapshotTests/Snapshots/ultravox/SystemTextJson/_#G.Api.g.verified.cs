//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API for the Ultravox service.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.ultravox.ai";

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
                    new global::G.JsonConverters.UltravoxV1CallTemplateInitialOutputMediumJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1CallTemplateInitialOutputMediumNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1TimedMessageEndBehaviorJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1TimedMessageEndBehaviorNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1DynamicParameterLocationJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1DynamicParameterLocationNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StaticParameterLocationJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StaticParameterLocationNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1AutomaticParameterLocationJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1AutomaticParameterLocationNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1AutomaticParameterKnownValueJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1AutomaticParameterKnownValueNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1BaseToolDefinitionDefaultReactionJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1BaseToolDefinitionDefaultReactionNullableJsonConverter(),
                    new global::G.JsonConverters.EndReasonEnumJsonConverter(),
                    new global::G.JsonConverters.EndReasonEnumNullableJsonConverter(),
                    new global::G.JsonConverters.NullEnumJsonConverter(),
                    new global::G.JsonConverters.NullEnumNullableJsonConverter(),
                    new global::G.JsonConverters.FirstSpeakerEnumJsonConverter(),
                    new global::G.JsonConverters.FirstSpeakerEnumNullableJsonConverter(),
                    new global::G.JsonConverters.InitialOutputMediumEnumJsonConverter(),
                    new global::G.JsonConverters.InitialOutputMediumEnumNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1CallToolDefaultReactionJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1CallToolDefaultReactionNullableJsonConverter(),
                    new global::G.JsonConverters.EventsEnumJsonConverter(),
                    new global::G.JsonConverters.EventsEnumNullableJsonConverter(),
                    new global::G.JsonConverters.OwnershipEnumJsonConverter(),
                    new global::G.JsonConverters.OwnershipEnumNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1CorpusStatsStatusJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1CorpusStatsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1SourceStatsStatusJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1SourceStatsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1MessageRoleJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1MessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1MessageMediumJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1MessageMediumNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StartAgentCallRequestInitialOutputMediumJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StartAgentCallRequestInitialOutputMediumNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StartCallRequestFirstSpeakerJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StartCallRequestFirstSpeakerNullableJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumJsonConverter(),
                    new global::G.JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumNullableJsonConverter(),
                    new global::G.JsonConverters.SchemaRetrieveFormatJsonConverter(),
                    new global::G.JsonConverters.SchemaRetrieveFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SchemaRetrieveLangJsonConverter(),
                    new global::G.JsonConverters.SchemaRetrieveLangNullableJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.EndReasonEnum?, global::G.NullEnum?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.EndReasonEnum?, global::G.NullEnum?>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public AccountsClient Accounts => new AccountsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CallsClient Calls => new CallsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CorporaClient Corpora => new CorporaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeletedCallsClient DeletedCalls => new DeletedCallsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SchemaClient Schema => new SchemaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
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