//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.writer.com";

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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ChatCompletionFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ChatResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkObjectJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRequestRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.GraphTypeJsonConverter(),
                    new global::G.JsonConverters.GraphTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphStageStatusJsonConverter(),
                    new global::G.JsonConverters.GraphStageStatusNullableJsonConverter(),
                    new global::G.JsonConverters.WebConnectorUrlTypeJsonConverter(),
                    new global::G.JsonConverters.WebConnectorUrlTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebConnectorUrlErrorTypeJsonConverter(),
                    new global::G.JsonConverters.WebConnectorUrlErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebConnectorUrlStatusJsonConverter(),
                    new global::G.JsonConverters.WebConnectorUrlStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ApiJobStatusJsonConverter(),
                    new global::G.JsonConverters.ApiJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ApplicationTypeJsonConverter(),
                    new global::G.JsonConverters.ApplicationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ApplicationStatusJsonConverter(),
                    new global::G.JsonConverters.ApplicationStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ApplicationInputTypeJsonConverter(),
                    new global::G.JsonConverters.ApplicationInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileUploadTypeJsonConverter(),
                    new global::G.JsonConverters.FileUploadTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionToolTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphToolTypeJsonConverter(),
                    new global::G.JsonConverters.GraphToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LlmToolTypeJsonConverter(),
                    new global::G.JsonConverters.LlmToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VisionToolTypeJsonConverter(),
                    new global::G.JsonConverters.VisionToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VisionFunctionModelJsonConverter(),
                    new global::G.JsonConverters.VisionFunctionModelNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallStreamingTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallStreamingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StringToolChoiceOptionsJsonConverter(),
                    new global::G.JsonConverters.StringToolChoiceOptionsNullableJsonConverter(),
                    new global::G.JsonConverters.AiDetectionResponseLabelJsonConverter(),
                    new global::G.JsonConverters.AiDetectionResponseLabelNullableJsonConverter(),
                    new global::G.JsonConverters.ComprehendMedicalTypeJsonConverter(),
                    new global::G.JsonConverters.ComprehendMedicalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SplittingStrategyJsonConverter(),
                    new global::G.JsonConverters.SplittingStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.PdfConversionFormatJsonConverter(),
                    new global::G.JsonConverters.PdfConversionFormatNullableJsonConverter(),
                    new global::G.JsonConverters.VisionRequestModelJsonConverter(),
                    new global::G.JsonConverters.VisionRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationRequestModelJsonConverter(),
                    new global::G.JsonConverters.TranslationRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationToolTypeJsonConverter(),
                    new global::G.JsonConverters.TranslationToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationFunctionModelJsonConverter(),
                    new global::G.JsonConverters.TranslationFunctionModelNullableJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestTopicJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestTopicNullableJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestSearchDepthJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestSearchDepthNullableJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestTimeRangeJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestTimeRangeNullableJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestIncludeRawContentJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestIncludeRawContentNullableJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestCountryJsonConverter(),
                    new global::G.JsonConverters.WebSearchRequestCountryNullableJsonConverter(),
                    new global::G.JsonConverters.WebSearchToolTypeJsonConverter(),
                    new global::G.JsonConverters.WebSearchToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextFragmentTypeJsonConverter(),
                    new global::G.JsonConverters.TextFragmentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageFragmentTypeJsonConverter(),
                    new global::G.JsonConverters.ImageFragmentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FindGraphsWithFileStatusOrderJsonConverter(),
                    new global::G.JsonConverters.FindGraphsWithFileStatusOrderNullableJsonConverter(),
                    new global::G.JsonConverters.GatewayGetFilesOrderJsonConverter(),
                    new global::G.JsonConverters.GatewayGetFilesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.GatewayGetFilesStatusJsonConverter(),
                    new global::G.JsonConverters.GatewayGetFilesStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetApplicationsOrderJsonConverter(),
                    new global::G.JsonConverters.GetApplicationsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ApplicationInputOptionsJsonConverter(),
                    new global::G.JsonConverters.ToolJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceJsonConverter(),
                    new global::G.JsonConverters.CompositeContentJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.CompositeContent>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.WebSearchRequestIncludeRawContent?, bool?>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public FileApiClient FileApi => new FileApiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationApiClient GenerationApi => new GenerationApiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public KgApiClient KgApi => new KgApiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TemplateClient Template => new TemplateClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsApiClient ToolsApi => new ToolsApiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranslationClient Translation => new TranslationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VisionClient Vision => new VisionClient(HttpClient, authorizations: Authorizations)
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