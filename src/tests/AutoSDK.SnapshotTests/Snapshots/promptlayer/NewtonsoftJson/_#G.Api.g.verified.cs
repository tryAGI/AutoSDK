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
        public const string DefaultBaseUrl = "https://api.promptlayer.com/";

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
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.EvaluationRunStatusJsonConverter(),

                    new global::G.JsonConverters.EvaluationRunStatusNullableJsonConverter(),

                    new global::G.JsonConverters.EdgeConditionalOperatorJsonConverter(),

                    new global::G.JsonConverters.EdgeConditionalOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.GetPromptTemplateProvider2JsonConverter(),

                    new global::G.JsonConverters.GetPromptTemplateProvider2NullableJsonConverter(),

                    new global::G.JsonConverters.CompletionPromptContentItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CompletionPromptContentItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CompletionPromptTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.CompletionPromptTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.CompletionPromptTypeJsonConverter(),

                    new global::G.JsonConverters.CompletionPromptTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TextContentTypeJsonConverter(),

                    new global::G.JsonConverters.TextContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ThinkingContentTypeJsonConverter(),

                    new global::G.JsonConverters.ThinkingContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MediaFormatJsonConverter(),

                    new global::G.JsonConverters.MediaFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ImageContentTypeJsonConverter(),

                    new global::G.JsonConverters.ImageContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MediaContentTypeJsonConverter(),

                    new global::G.JsonConverters.MediaContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MediaVariableTypeJsonConverter(),

                    new global::G.JsonConverters.MediaVariableTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMediaContentTypeJsonConverter(),

                    new global::G.JsonConverters.OutputMediaContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMediaContentMediaTypeJsonConverter(),

                    new global::G.JsonConverters.OutputMediaContentMediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeContentTypeJsonConverter(),

                    new global::G.JsonConverters.CodeContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ServerToolUseContentTypeJsonConverter(),

                    new global::G.JsonConverters.ServerToolUseContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchResultTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchResultTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolResultContentTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolResultContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeExecutionResultContentTypeJsonConverter(),

                    new global::G.JsonConverters.CodeExecutionResultContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpListToolsContentTypeJsonConverter(),

                    new global::G.JsonConverters.McpListToolsContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpCallContentTypeJsonConverter(),

                    new global::G.JsonConverters.McpCallContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpApprovalRequestContentTypeJsonConverter(),

                    new global::G.JsonConverters.McpApprovalRequestContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpApprovalResponseContentTypeJsonConverter(),

                    new global::G.JsonConverters.McpApprovalResponseContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BashCodeExecutionToolResultContentTypeJsonConverter(),

                    new global::G.JsonConverters.BashCodeExecutionToolResultContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TextEditorCodeExecutionToolResultContentTypeJsonConverter(),

                    new global::G.JsonConverters.TextEditorCodeExecutionToolResultContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ShellCallContentTypeJsonConverter(),

                    new global::G.JsonConverters.ShellCallContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ShellCallOutputContentTypeJsonConverter(),

                    new global::G.JsonConverters.ShellCallOutputContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApplyPatchCallContentTypeJsonConverter(),

                    new global::G.JsonConverters.ApplyPatchCallContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApplyPatchCallOutputContentTypeJsonConverter(),

                    new global::G.JsonConverters.ApplyPatchCallOutputContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BuiltInToolTypeJsonConverter(),

                    new global::G.JsonConverters.BuiltInToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SystemMessageTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.SystemMessageTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.SystemMessageContentItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.SystemMessageContentItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UserMessageTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.UserMessageTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.UserMessageContentItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.UserMessageContentItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantMessageTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.AssistantMessageTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.AssistantMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionMessageTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.FunctionMessageTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.FunctionMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DeveloperMessageTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.DeveloperMessageTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.DeveloperMessageContentItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatPromptMessageDiscriminatorRoleJsonConverter(),

                    new global::G.JsonConverters.ChatPromptMessageDiscriminatorRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatPromptTypeJsonConverter(),

                    new global::G.JsonConverters.ChatPromptTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.GetPromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.GetPromptTemplateRawResponsePromptTemplateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.PromptVersionPromptTemplateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.CreatePromptTemplateResponsePromptTemplateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ToolMessageTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.ToolMessageTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ToolMessageContentItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.ToolMessageContentItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ToolDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PlaceholderMessageTemplateFormatJsonConverter(),

                    new global::G.JsonConverters.PlaceholderMessageTemplateFormatNullableJsonConverter(),

                    new global::G.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PlaceholderMessageRoleJsonConverter(),

                    new global::G.JsonConverters.PlaceholderMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.LogRequestInputDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.LogRequestInputDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LogRequestOutputDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.LogRequestOutputDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LogRequestStatusJsonConverter(),

                    new global::G.JsonConverters.LogRequestStatusNullableJsonConverter(),

                    new global::G.JsonConverters.LogRequestErrorType2JsonConverter(),

                    new global::G.JsonConverters.LogRequestErrorType2NullableJsonConverter(),

                    new global::G.JsonConverters.LogRequestResponseStatusJsonConverter(),

                    new global::G.JsonConverters.LogRequestResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.PromptBlueprintPromptTemplateDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SpanKindJsonConverter(),

                    new global::G.JsonConverters.SpanKindNullableJsonConverter(),

                    new global::G.JsonConverters.StatusCodeJsonConverter(),

                    new global::G.JsonConverters.StatusCodeNullableJsonConverter(),

                    new global::G.JsonConverters.EntityTypeJsonConverter(),

                    new global::G.JsonConverters.EntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptEntityMetadataTypeJsonConverter(),

                    new global::G.JsonConverters.PromptEntityMetadataTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SearchRequestLogsRequestSortByJsonConverter(),

                    new global::G.JsonConverters.SearchRequestLogsRequestSortByNullableJsonConverter(),

                    new global::G.JsonConverters.SearchRequestLogsRequestSortOrderJsonConverter(),

                    new global::G.JsonConverters.SearchRequestLogsRequestSortOrderNullableJsonConverter(),

                    new global::G.JsonConverters.StructuredFilterFieldJsonConverter(),

                    new global::G.JsonConverters.StructuredFilterFieldNullableJsonConverter(),

                    new global::G.JsonConverters.StructuredFilterOperatorJsonConverter(),

                    new global::G.JsonConverters.StructuredFilterOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.StructuredFilterGroupLogicJsonConverter(),

                    new global::G.JsonConverters.StructuredFilterGroupLogicNullableJsonConverter(),

                    new global::G.JsonConverters.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageJsonConverter(),

                    new global::G.JsonConverters.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageNullableJsonConverter(),

                    new global::G.JsonConverters.AddReportColumnRequestColumnTypeJsonConverter(),

                    new global::G.JsonConverters.AddReportColumnRequestColumnTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListDatasetsStatusJsonConverter(),

                    new global::G.JsonConverters.ListDatasetsStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ListEvaluationsStatusJsonConverter(),

                    new global::G.JsonConverters.ListEvaluationsStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetAllPromptTemplatesGetStatusJsonConverter(),

                    new global::G.JsonConverters.GetAllPromptTemplatesGetStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2JsonConverter(),

                    new global::G.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2NullableJsonConverter(),

                    new global::G.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemJsonConverter(),

                    new global::G.JsonConverters.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItemNullableJsonConverter(),

                    new global::G.JsonConverters.IngestOtlpTracesContentTypeJsonConverter(),

                    new global::G.JsonConverters.IngestOtlpTracesContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.IngestOtlpTracesContentEncodingJsonConverter(),

                    new global::G.JsonConverters.IngestOtlpTracesContentEncodingNullableJsonConverter(),

                    new global::G.JsonConverters.GetRequestSearchSuggestionsFieldJsonConverter(),

                    new global::G.JsonConverters.GetRequestSearchSuggestionsFieldNullableJsonConverter(),

                    new global::G.JsonConverters.GetReportResponseStatusJsonConverter(),

                    new global::G.JsonConverters.GetReportResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter(),

                    new global::G.JsonConverters.GetReportScoreResponseScoreScoreTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetDatasetRowsResponseRowItemTypeJsonConverter(),

                    new global::G.JsonConverters.GetDatasetRowsResponseRowItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetEvaluationRowsResponseRowItemTypeJsonConverter(),

                    new global::G.JsonConverters.GetEvaluationRowsResponseRowItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetEvaluationRowsResponseRowItemStatusJsonConverter(),

                    new global::G.JsonConverters.GetEvaluationRowsResponseRowItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluationsClient Evaluations => new EvaluationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FoldersClient Folders => new FoldersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GroupClient Group => new GroupClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata => new MetadataClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OtlpClient Otlp => new OtlpClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptTemplatesClient PromptTemplates => new PromptTemplatesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReportsClient Reports => new ReportsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RequestClient Request => new RequestClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RestClient Rest => new RestClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScoreClient Score => new ScoreClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpansClient Spans => new SpansClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TrackingClient Tracking => new TrackingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkflowClient Workflow => new WorkflowClient(HttpClient, authorizations: Authorizations, options: Options)
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