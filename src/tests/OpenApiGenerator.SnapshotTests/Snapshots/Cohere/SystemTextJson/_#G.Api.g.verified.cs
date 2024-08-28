//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Cohere Platform is centered around models.<br/>
    /// Each model has a different amount of power (i.e. parameters), to be used for different tasks.<br/>
    /// Cohere also supports finetuning of baseline models to improve performance on downstream tasks or to teach the model large quantities of information which cannot be extracted with few-shot learning or prompt engineering.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// production
        /// </summary>
        public const string BaseUrl = "https://api.cohere.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Datasets API
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Connectors API
        /// </summary>
        public ConnectorsClient Connectors => new ConnectorsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Embed Jobs API
        /// </summary>
        public EmbedJobsClient EmbedJobs => new EmbedJobsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Finetuning API (Beta)
        /// </summary>
        public FinetuningClient Finetuning => new FinetuningClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

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
                    new global::OpenApiGenerator.JsonConverters.ChatRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamEventEventTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamEventEventTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamEndEventVariant2FinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamEndEventVariant2FinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TextContentTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TextContentTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolCall2TypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolCall2TypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SystemMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SystemMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolContentTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolContentTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolMessage2RoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ToolMessage2RoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.Tool2TypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.Tool2TypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatFinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantMessageResponseRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantMessageResponseRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamEventTypeTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamEventTypeTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolCallStartEventVariant2DeltaToolCallTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolCallStartEventVariant2DeltaToolCallTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateStreamEventEventTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateStreamEventEventTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedInputTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedInputTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedFloatsResponseResponseTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedFloatsResponseResponseTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedByTypeResponseResponseTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedJobStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedJobStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedJobTruncateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedJobTruncateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbedJobRequestTruncateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbedJobRequestTruncateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DatasetValidationStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DatasetValidationStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DatasetTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DatasetTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ConnectorAuthStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ConnectorAuthStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuthTokenTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuthTokenTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetClusterJobResponseStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetClusterJobResponseStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateClusterJobRequestStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateClusterJobRequestStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CompatibleEndpointJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CompatibleEndpointNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BaseTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BaseTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StrategyJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StrategyNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatRequestPromptTruncationJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatRequestPromptTruncationNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatRequestCitationQualityJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatRequestCitationQualityNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.Chatv2RequestCitationModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.Chatv2RequestCitationModeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateRequestTruncateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateRequestTruncateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateRequestReturnLikelihoodsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateRequestReturnLikelihoodsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedRequestTruncateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbedRequestTruncateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ClassifyRequestTruncateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ClassifyRequestTruncateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummarizeRequestLengthJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummarizeRequestLengthNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummarizeRequestFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummarizeRequestFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummarizeRequestExtractivenessJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummarizeRequestExtractivenessNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ClassifyResponseClassificationClassificationTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamStartEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatSearchQueriesGenerationEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatSearchResultsEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatTextGenerationEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCitationGenerationEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolCallsGenerationEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatStreamEndEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolCallsChunkEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StreamedChatResponseJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ContentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.SourceJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory1(),
                    new global::OpenApiGenerator.JsonConverters.ChatMessage2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormat2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatMessageStartEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatContentStartEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatContentDeltaEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatContentEndEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolPlanDeltaEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolCallStartEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolCallDeltaEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatToolCallEndEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CitationStartEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CitationEndEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatMessageEndEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StreamedChatResponse2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateStreamTextJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateStreamEndJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateStreamErrorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GenerateStreamedResponseJsonConverter(),
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