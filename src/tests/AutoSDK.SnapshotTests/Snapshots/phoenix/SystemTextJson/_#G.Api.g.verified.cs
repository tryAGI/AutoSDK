//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for Arize-Phoenix REST API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Local Phoenix instance
        /// </summary>
        public const string DefaultBaseUrl = "http://localhost:6006";

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
                    new global::G.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodJsonConverter(),
                    new global::G.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodNullableJsonConverter(),
                    new global::G.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodJsonConverter(),
                    new global::G.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodJsonConverter(),
                    new global::G.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodNullableJsonConverter(),
                    new global::G.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodJsonConverter(),
                    new global::G.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter(),
                    new global::G.JsonConverters.LDAPUserRoleJsonConverter(),
                    new global::G.JsonConverters.LDAPUserRoleNullableJsonConverter(),
                    new global::G.JsonConverters.LDAPUserDataRoleJsonConverter(),
                    new global::G.JsonConverters.LDAPUserDataRoleNullableJsonConverter(),
                    new global::G.JsonConverters.LocalUserRoleJsonConverter(),
                    new global::G.JsonConverters.LocalUserRoleNullableJsonConverter(),
                    new global::G.JsonConverters.LocalUserDataRoleJsonConverter(),
                    new global::G.JsonConverters.LocalUserDataRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ModelProviderJsonConverter(),
                    new global::G.JsonConverters.ModelProviderNullableJsonConverter(),
                    new global::G.JsonConverters.OAuth2UserRoleJsonConverter(),
                    new global::G.JsonConverters.OAuth2UserRoleNullableJsonConverter(),
                    new global::G.JsonConverters.OAuth2UserDataRoleJsonConverter(),
                    new global::G.JsonConverters.OAuth2UserDataRoleNullableJsonConverter(),
                    new global::G.JsonConverters.OptimizationDirectionJsonConverter(),
                    new global::G.JsonConverters.OptimizationDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.OtlpDoubleValueJsonConverter(),
                    new global::G.JsonConverters.OtlpDoubleValueNullableJsonConverter(),
                    new global::G.JsonConverters.OtlpKindJsonConverter(),
                    new global::G.JsonConverters.OtlpKindNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptMessageRoleJsonConverter(),
                    new global::G.JsonConverters.PromptMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptTemplateFormatJsonConverter(),
                    new global::G.JsonConverters.PromptTemplateFormatNullableJsonConverter(),
                    new global::G.JsonConverters.PromptTemplateTypeJsonConverter(),
                    new global::G.JsonConverters.PromptTemplateTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.PromptToolsToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptToolsToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVersionTemplateDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptVersionTemplateDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.SessionAnnotationSourceJsonConverter(),
                    new global::G.JsonConverters.SessionAnnotationSourceNullableJsonConverter(),
                    new global::G.JsonConverters.SessionAnnotationAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.SessionAnnotationAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.SessionAnnotationDataAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.SessionAnnotationDataAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.SpanAnnotationSourceJsonConverter(),
                    new global::G.JsonConverters.SpanAnnotationSourceNullableJsonConverter(),
                    new global::G.JsonConverters.SpanAnnotationAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.SpanAnnotationAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.SpanAnnotationDataAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.SpanAnnotationDataAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TraceAnnotationSourceJsonConverter(),
                    new global::G.JsonConverters.TraceAnnotationSourceNullableJsonConverter(),
                    new global::G.JsonConverters.TraceAnnotationAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.TraceAnnotationAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.TraceAnnotationDataAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.TraceAnnotationDataAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindJsonConverter(),
                    new global::G.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.UploadDatasetRequestActionJsonConverter(),
                    new global::G.JsonConverters.UploadDatasetRequestActionNullableJsonConverter(),
                    new global::G.JsonConverters.UploadDatasetRequestAction2JsonConverter(),
                    new global::G.JsonConverters.UploadDatasetRequestAction2NullableJsonConverter(),
                    new global::G.JsonConverters.ListProjectTracesSortJsonConverter(),
                    new global::G.JsonConverters.ListProjectTracesSortNullableJsonConverter(),
                    new global::G.JsonConverters.ListProjectTracesOrderJsonConverter(),
                    new global::G.JsonConverters.ListProjectTracesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListProjectSessionsOrderJsonConverter(),
                    new global::G.JsonConverters.ListProjectSessionsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAnnotationConfigDataJsonConverter(),
                    new global::G.JsonConverters.DataJsonConverter(),
                    new global::G.JsonConverters.UserJsonConverter(),
                    new global::G.JsonConverters.Data2JsonConverter(),
                    new global::G.JsonConverters.Data3JsonConverter(),
                    new global::G.JsonConverters.Data4JsonConverter(),
                    new global::G.JsonConverters.DataItemJsonConverter(),
                    new global::G.JsonConverters.DataItem2JsonConverter(),
                    new global::G.JsonConverters.Data5JsonConverter(),
                    new global::G.JsonConverters.ThinkingJsonConverter(),
                    new global::G.JsonConverters.ContentVariant2ItemJsonConverter(),
                    new global::G.JsonConverters.ToolsItemJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceJsonConverter(),
                    new global::G.JsonConverters.TemplateJsonConverter(),
                    new global::G.JsonConverters.InvocationParametersJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant1JsonConverter(),
                    new global::G.JsonConverters.Template2JsonConverter(),
                    new global::G.JsonConverters.InvocationParameters2JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant12JsonConverter(),
                    new global::G.JsonConverters.Data6JsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, global::G.OtlpDoubleValue?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<long?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<long?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OtlpKind?, int?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<long?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, object>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public AnnotationConfigsClient AnnotationConfigs => new AnnotationConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsClient Annotations => new AnnotationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExperimentsClient Experiments => new ExperimentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SessionsClient Sessions => new SessionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpansClient Spans => new SpansClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TracesClient Traces => new TracesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
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