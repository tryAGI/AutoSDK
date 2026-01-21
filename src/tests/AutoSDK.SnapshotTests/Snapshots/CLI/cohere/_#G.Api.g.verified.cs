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
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// production
        /// </summary>
        public const string DefaultBaseUrl = "https://api.cohere.com";

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
                    new global::G.JsonConverters.ChatRoleJsonConverter(),
                    new global::G.JsonConverters.ChatRoleNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDiscriminatorRoleJsonConverter(),
                    new global::G.JsonConverters.MessageDiscriminatorRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCitationTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FinishReasonJsonConverter(),
                    new global::G.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.ChatStreamEventEventTypeJsonConverter(),
                    new global::G.JsonConverters.ChatStreamEventEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatStreamEndEventVariant2FinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChatStreamEndEventVariant2FinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.StreamedChatResponseDiscriminatorEventTypeJsonConverter(),
                    new global::G.JsonConverters.StreamedChatResponseDiscriminatorEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextContentTypeJsonConverter(),
                    new global::G.JsonConverters.TextContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentTypeJsonConverter(),
                    new global::G.JsonConverters.ContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageUrlDetailJsonConverter(),
                    new global::G.JsonConverters.ImageUrlDetailNullableJsonConverter(),
                    new global::G.JsonConverters.ContentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ContentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UserMessageRoleJsonConverter(),
                    new global::G.JsonConverters.UserMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallV2TypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallV2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CitationTypeJsonConverter(),
                    new global::G.JsonConverters.CitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageRoleJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageContentVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SystemMessageRoleJsonConverter(),
                    new global::G.JsonConverters.SystemMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.SystemMessageContentVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.SystemMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentContentTypeJsonConverter(),
                    new global::G.JsonConverters.DocumentContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolContentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ToolContentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolMessageV2RoleJsonConverter(),
                    new global::G.JsonConverters.ToolMessageV2RoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageV2DiscriminatorRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageV2DiscriminatorRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.ReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.ToolV2TypeJsonConverter(),
                    new global::G.JsonConverters.ToolV2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CitationOptionsModeJsonConverter(),
                    new global::G.JsonConverters.CitationOptionsModeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeV2JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeV2NullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatV2DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatV2DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChatFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageResponseRoleJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageResponseRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageResponseContentItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatStreamEventTypeTypeJsonConverter(),
                    new global::G.JsonConverters.ChatStreamEventTypeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeJsonConverter(),
                    new global::G.JsonConverters.ChatContentStartEventVariant2DeltaMessageContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamedChatResponseV2DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.StreamedChatResponseV2DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateStreamEventEventTypeJsonConverter(),
                    new global::G.JsonConverters.GenerateStreamEventEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeJsonConverter(),
                    new global::G.JsonConverters.GenerateStreamedResponseDiscriminatorEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedInputTypeJsonConverter(),
                    new global::G.JsonConverters.EmbedInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedFloatsResponseResponseTypeJsonConverter(),
                    new global::G.JsonConverters.EmbedFloatsResponseResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter(),
                    new global::G.JsonConverters.EmbedByTypeResponseResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedContentTypeJsonConverter(),
                    new global::G.JsonConverters.EmbedContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedContentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.EmbedContentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedJobStatusJsonConverter(),
                    new global::G.JsonConverters.EmbedJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedJobTruncateJsonConverter(),
                    new global::G.JsonConverters.EmbedJobTruncateNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbedJobRequestTruncateJsonConverter(),
                    new global::G.JsonConverters.CreateEmbedJobRequestTruncateNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetValidationStatusJsonConverter(),
                    new global::G.JsonConverters.DatasetValidationStatusNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetTypeJsonConverter(),
                    new global::G.JsonConverters.DatasetTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConnectorAuthStatusJsonConverter(),
                    new global::G.JsonConverters.ConnectorAuthStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AuthTokenTypeJsonConverter(),
                    new global::G.JsonConverters.AuthTokenTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetClusterJobResponseStatusJsonConverter(),
                    new global::G.JsonConverters.GetClusterJobResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateClusterJobRequestStatusJsonConverter(),
                    new global::G.JsonConverters.UpdateClusterJobRequestStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CompatibleEndpointJsonConverter(),
                    new global::G.JsonConverters.CompatibleEndpointNullableJsonConverter(),
                    new global::G.JsonConverters.BaseTypeJsonConverter(),
                    new global::G.JsonConverters.BaseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StrategyJsonConverter(),
                    new global::G.JsonConverters.StrategyNullableJsonConverter(),
                    new global::G.JsonConverters.LoraTargetModulesJsonConverter(),
                    new global::G.JsonConverters.LoraTargetModulesNullableJsonConverter(),
                    new global::G.JsonConverters.StatusJsonConverter(),
                    new global::G.JsonConverters.StatusNullableJsonConverter(),
                    new global::G.JsonConverters.ChatRequestPromptTruncationJsonConverter(),
                    new global::G.JsonConverters.ChatRequestPromptTruncationNullableJsonConverter(),
                    new global::G.JsonConverters.ChatRequestCitationQualityJsonConverter(),
                    new global::G.JsonConverters.ChatRequestCitationQualityNullableJsonConverter(),
                    new global::G.JsonConverters.ChatRequestSafetyModeJsonConverter(),
                    new global::G.JsonConverters.ChatRequestSafetyModeNullableJsonConverter(),
                    new global::G.JsonConverters.Chatv2RequestSafetyModeJsonConverter(),
                    new global::G.JsonConverters.Chatv2RequestSafetyModeNullableJsonConverter(),
                    new global::G.JsonConverters.Chatv2RequestToolChoiceJsonConverter(),
                    new global::G.JsonConverters.Chatv2RequestToolChoiceNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateRequestTruncateJsonConverter(),
                    new global::G.JsonConverters.GenerateRequestTruncateNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateRequestReturnLikelihoodsJsonConverter(),
                    new global::G.JsonConverters.GenerateRequestReturnLikelihoodsNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedRequestTruncateJsonConverter(),
                    new global::G.JsonConverters.EmbedRequestTruncateNullableJsonConverter(),
                    new global::G.JsonConverters.Embedv2RequestTruncateJsonConverter(),
                    new global::G.JsonConverters.Embedv2RequestTruncateNullableJsonConverter(),
                    new global::G.JsonConverters.ClassifyRequestTruncateJsonConverter(),
                    new global::G.JsonConverters.ClassifyRequestTruncateNullableJsonConverter(),
                    new global::G.JsonConverters.SummarizeRequestLengthJsonConverter(),
                    new global::G.JsonConverters.SummarizeRequestLengthNullableJsonConverter(),
                    new global::G.JsonConverters.SummarizeRequestFormatJsonConverter(),
                    new global::G.JsonConverters.SummarizeRequestFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SummarizeRequestExtractivenessJsonConverter(),
                    new global::G.JsonConverters.SummarizeRequestExtractivenessNullableJsonConverter(),
                    new global::G.JsonConverters.ChatAcceptsJsonConverter(),
                    new global::G.JsonConverters.ChatAcceptsNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedResponseDiscriminatorResponseTypeJsonConverter(),
                    new global::G.JsonConverters.EmbedResponseDiscriminatorResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter(),
                    new global::G.JsonConverters.ClassifyResponseClassificationClassificationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonConverter(),
                    new global::G.JsonConverters.ChatStreamStartEventJsonConverter(),
                    new global::G.JsonConverters.ChatSearchQueriesGenerationEventJsonConverter(),
                    new global::G.JsonConverters.ChatSearchResultsEventJsonConverter(),
                    new global::G.JsonConverters.ChatTextGenerationEventJsonConverter(),
                    new global::G.JsonConverters.ChatCitationGenerationEventJsonConverter(),
                    new global::G.JsonConverters.ChatToolCallsGenerationEventJsonConverter(),
                    new global::G.JsonConverters.ChatStreamEndEventJsonConverter(),
                    new global::G.JsonConverters.ChatToolCallsChunkEventJsonConverter(),
                    new global::G.JsonConverters.ChatDebugEventJsonConverter(),
                    new global::G.JsonConverters.StreamedChatResponseJsonConverter(),
                    new global::G.JsonConverters.ContentJsonConverter(),
                    new global::G.JsonConverters.SourceJsonConverter(),
                    new global::G.JsonConverters.ContentVariant2ItemJsonConverter(),
                    new global::G.JsonConverters.ContentVariant2Item2JsonConverter(),
                    new global::G.JsonConverters.ToolContentJsonConverter(),
                    new global::G.JsonConverters.ChatMessageV2JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatV2JsonConverter(),
                    new global::G.JsonConverters.ContentItemJsonConverter(),
                    new global::G.JsonConverters.ChatMessageStartEventJsonConverter(),
                    new global::G.JsonConverters.ChatContentStartEventJsonConverter(),
                    new global::G.JsonConverters.ChatContentDeltaEventJsonConverter(),
                    new global::G.JsonConverters.ChatContentEndEventJsonConverter(),
                    new global::G.JsonConverters.ChatToolPlanDeltaEventJsonConverter(),
                    new global::G.JsonConverters.ChatToolCallStartEventJsonConverter(),
                    new global::G.JsonConverters.ChatToolCallDeltaEventJsonConverter(),
                    new global::G.JsonConverters.ChatToolCallEndEventJsonConverter(),
                    new global::G.JsonConverters.CitationStartEventJsonConverter(),
                    new global::G.JsonConverters.CitationEndEventJsonConverter(),
                    new global::G.JsonConverters.ChatMessageEndEventJsonConverter(),
                    new global::G.JsonConverters.StreamedChatResponseV2JsonConverter(),
                    new global::G.JsonConverters.GenerateStreamTextJsonConverter(),
                    new global::G.JsonConverters.GenerateStreamEndJsonConverter(),
                    new global::G.JsonConverters.GenerateStreamErrorJsonConverter(),
                    new global::G.JsonConverters.GenerateStreamedResponseJsonConverter(),
                    new global::G.JsonConverters.EmbedContentJsonConverter(),
                    new global::G.JsonConverters.EmbedResponseJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.Content>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item2>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ToolContent>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::G.Document>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::G.RerankDocument>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.NonStreamedChatResponse, global::G.StreamedChatResponse?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ChatResponse, global::G.StreamedChatResponseV2?>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// Datasets API
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Connectors API
        /// </summary>
        public ConnectorsClient Connectors => new ConnectorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Embed Jobs API
        /// </summary>
        public EmbedJobsClient EmbedJobs => new EmbedJobsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Finetuning API (Beta)
        /// </summary>
        public FinetuningClient Finetuning => new FinetuningClient(HttpClient, authorizations: Authorizations)
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