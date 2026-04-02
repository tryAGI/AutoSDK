//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification of the Groq cloud API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.groq.com";

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
                    new global::G.JsonConverters.CreateSpeechRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestLanguageJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranslationRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateTranslationRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranslationRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateTranslationRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.BatchObjectJsonConverter(),
                    new global::G.JsonConverters.BatchObjectNullableJsonConverter(),
                    new global::G.JsonConverters.BatchStatusJsonConverter(),
                    new global::G.JsonConverters.BatchStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchRequestInputMethodJsonConverter(),
                    new global::G.JsonConverters.BatchRequestInputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.ListBatchesResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListBatchesResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartDocumentTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartDocumentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDocumentSourceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDocumentSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDocumentSourceTextTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDocumentSourceTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDocumentSourceJSONTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDocumentSourceJSONTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestServiceTierJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestServiceTierNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestReasoningFormatJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestReasoningFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestCitationOptionsJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestCitationOptionsNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTextTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseServiceTierJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseServiceTierNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChartTypeJsonConverter(),
                    new global::G.JsonConverters.ChartTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnnotationTypeJsonConverter(),
                    new global::G.JsonConverters.AnnotationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingObjectJsonConverter(),
                    new global::G.JsonConverters.EmbeddingObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FileObjectJsonConverter(),
                    new global::G.JsonConverters.FileObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FilePurposeJsonConverter(),
                    new global::G.JsonConverters.FilePurposeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateFileRequestPurposeJsonConverter(),
                    new global::G.JsonConverters.CreateFileRequestPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteFileResponseObjectJsonConverter(),
                    new global::G.JsonConverters.DeleteFileResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListFilesResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ModelObjectJsonConverter(),
                    new global::G.JsonConverters.ModelObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ListModelsResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListModelsResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestServiceTierJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestServiceTierNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestTruncationJsonConverter(),
                    new global::G.JsonConverters.CreateResponseRequestTruncationNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseInputItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseInputItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseEasyInputMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ResponseEasyInputMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseInputMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseInputMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseInputMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ResponseInputMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseInputMessageStatusJsonConverter(),
                    new global::G.JsonConverters.ResponseInputMessageStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseInputContentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseInputContentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseInputTextContentTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseInputTextContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseItemReferenceTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseItemReferenceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallStatusJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallOutputTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallOutputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallOutputStatusJsonConverter(),
                    new global::G.JsonConverters.ResponseFunctionCallOutputStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseToolTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseToolChoiceOptionEnumJsonConverter(),
                    new global::G.JsonConverters.ResponseToolChoiceOptionEnumNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseNamedToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseNamedToolChoiceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseStatusJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseTruncationJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseTruncationNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseServiceTierJsonConverter(),
                    new global::G.JsonConverters.CreateResponseResponseServiceTierNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputMessageStatusJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputMessageStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputContentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputContentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputTextContentTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputTextContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseAnnotationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseAnnotationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFileCitationTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFileCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseUrlCitationTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseUrlCitationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputFunctionCallTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputFunctionCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputFunctionCallStatusJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputFunctionCallStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputReasoningTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputReasoningTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateBatchRequestEndpointJsonConverter(),
                    new global::G.JsonConverters.CreateBatchRequestEndpointNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionDocumentSourceJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter(),
                    new global::G.JsonConverters.ResponseInputItemJsonConverter(),
                    new global::G.JsonConverters.ResponseInputContentJsonConverter(),
                    new global::G.JsonConverters.ResponseToolChoiceOptionJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatConfigurationJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputItemJsonConverter(),
                    new global::G.JsonConverters.ResponseOutputContentJsonConverter(),
                    new global::G.JsonConverters.ResponseAnnotationJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateSpeechRequestModel?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateTranscriptionRequestModel?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateTranscriptionRequestLanguage?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateTranslationRequestModel?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPartText>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPart>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPartText>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessageContentPart>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionToolType?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateChatCompletionRequestModel?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CreateChatCompletionRequestFunctionCall?, global::G.ChatCompletionFunctionCallOption>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<double>, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateEmbeddingRequestModel?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateResponseRequestModel?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ResponseInputItem>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ResponseInputContent>>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AudioClient Audio => new AudioClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(HttpClient, authorizations: Authorizations)
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
        public RerankingClient Reranking => new RerankingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClient Responses => new ResponsesClient(HttpClient, authorizations: Authorizations)
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