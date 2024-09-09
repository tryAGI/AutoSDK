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
                    new global::AutoSDK.JsonConverters.ChatRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamEventEventTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamEventEventTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamEndEventVariant2FinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamEndEventVariant2FinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TextContentTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.TextContentTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolCall2TypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolCall2TypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SystemMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.SystemMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolContentTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolContentTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolMessage2RoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ToolMessage2RoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.Tool2TypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.Tool2TypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatFinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatFinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantMessageResponseRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantMessageResponseRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamEventTypeTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamEventTypeTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolCallStartEventVariant2DeltaToolCallTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolCallStartEventVariant2DeltaToolCallTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateStreamEventEventTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateStreamEventEventTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedInputTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedInputTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedFloatsResponseResponseTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedFloatsResponseResponseTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedByTypeResponseResponseTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedJobStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedJobStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedJobTruncateJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedJobTruncateNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbedJobRequestTruncateJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbedJobRequestTruncateNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DatasetValidationStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.DatasetValidationStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DatasetTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.DatasetTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ConnectorAuthStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.ConnectorAuthStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuthTokenTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuthTokenTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetClusterJobResponseStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetClusterJobResponseStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateClusterJobRequestStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateClusterJobRequestStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CompatibleEndpointJsonConverter(),
                    new global::AutoSDK.JsonConverters.CompatibleEndpointNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BaseTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.BaseTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StrategyJsonConverter(),
                    new global::AutoSDK.JsonConverters.StrategyNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.StatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatRequestPromptTruncationJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatRequestPromptTruncationNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatRequestCitationQualityJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatRequestCitationQualityNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.Chatv2RequestCitationModeJsonConverter(),
                    new global::AutoSDK.JsonConverters.Chatv2RequestCitationModeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateRequestTruncateJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateRequestTruncateNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateRequestReturnLikelihoodsJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateRequestReturnLikelihoodsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedRequestTruncateJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbedRequestTruncateNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ClassifyRequestTruncateJsonConverter(),
                    new global::AutoSDK.JsonConverters.ClassifyRequestTruncateNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummarizeRequestLengthJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummarizeRequestLengthNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummarizeRequestFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummarizeRequestFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummarizeRequestExtractivenessJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummarizeRequestExtractivenessNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ClassifyResponseClassificationClassificationTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamStartEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatSearchQueriesGenerationEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatSearchResultsEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatTextGenerationEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCitationGenerationEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolCallsGenerationEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatStreamEndEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolCallsChunkEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.StreamedChatResponseJsonConverter(),
                    new global::AutoSDK.JsonConverters.ContentJsonConverter(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.SourceJsonConverter(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory1(),
                    new global::AutoSDK.JsonConverters.ChatMessage2JsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormat2JsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatMessageStartEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatContentStartEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatContentDeltaEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatContentEndEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolPlanDeltaEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolCallStartEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolCallDeltaEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatToolCallEndEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.CitationStartEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.CitationEndEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatMessageEndEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.StreamedChatResponse2JsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateStreamTextJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateStreamEndJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateStreamErrorJsonConverter(),
                    new global::AutoSDK.JsonConverters.GenerateStreamedResponseJsonConverter(),
                }
            };

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