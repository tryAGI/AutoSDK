//HintName: G.OpenAiClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class OpenAiClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.openai.com/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Build Assistants that can call models and use tools.
        /// </summary>
        public AssistantsClient Assistants => new AssistantsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Turn audio into text or text into audio.
        /// </summary>
        public AudioClient Audio => new AudioClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Manage fine-tuning jobs to tailor a model to your specific training data.
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Create large batches of API requests to run asynchronously.
        /// </summary>
        public BatchClient Batch => new BatchClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Files are used to upload documents that can be used with features like Assistants and Fine-tuning.
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Use Uploads to upload large files in multiple parts.
        /// </summary>
        public UploadsClient Uploads => new UploadsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Given a prompt and/or an input image, the model will generate a new image.
        /// </summary>
        public ImagesClient Images => new ImagesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// List and describe the various models available in the API.
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Given a input text, outputs if the model classifies it as potentially harmful.
        /// </summary>
        public ModerationsClient Moderations => new ModerationsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// List user actions and configuration changes within this organization.
        /// </summary>
        public AuditLogsClient AuditLogs => new AuditLogsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public VectorStoresClient VectorStores => new VectorStoresClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public InvitesClient Invites => new InvitesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the OpenAiClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public OpenAiClient(
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
                    new global::G.JsonConverters.ListModelsResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListModelsResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ModelObjectJsonConverter(),
                    new global::G.JsonConverters.ModelObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCompletionRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateCompletionRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCompletionResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTextTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter(),
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
                    new global::G.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseServiceTierJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseServiceTierNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobObjectJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobStatusJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseServiceTierJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseServiceTierNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestQualityJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestQualityNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestSizeJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestSizeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestStyleJsonConverter(),
                    new global::G.JsonConverters.CreateImageRequestStyleNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageEditRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateImageEditRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageEditRequestSizeJsonConverter(),
                    new global::G.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageVariationRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageVariationRequestSizeJsonConverter(),
                    new global::G.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateModerationRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateModerationRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAIFileObjectJsonConverter(),
                    new global::G.JsonConverters.OpenAIFileObjectNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAIFilePurposeJsonConverter(),
                    new global::G.JsonConverters.OpenAIFilePurposeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAIFileStatusJsonConverter(),
                    new global::G.JsonConverters.OpenAIFileStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListFilesResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateFileRequestPurposeJsonConverter(),
                    new global::G.JsonConverters.CreateFileRequestPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteFileResponseObjectJsonConverter(),
                    new global::G.JsonConverters.DeleteFileResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateUploadRequestPurposeJsonConverter(),
                    new global::G.JsonConverters.CreateUploadRequestPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullableJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsNullableJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.CreateFineTuningJobRequestIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobEventLevelJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobEventLevelNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobEventObjectJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobEventObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobCheckpointObjectJsonConverter(),
                    new global::G.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingObjectJsonConverter(),
                    new global::G.JsonConverters.EmbeddingObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingResponseObjectJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter(),
                    new global::G.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTranslationRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateTranslationRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestVoiceJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.UploadStatusJsonConverter(),
                    new global::G.JsonConverters.UploadStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UploadObjectJsonConverter(),
                    new global::G.JsonConverters.UploadObjectNullableJsonConverter(),
                    new global::G.JsonConverters.UploadPartObjectJsonConverter(),
                    new global::G.JsonConverters.UploadPartObjectNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter(),
                    new global::G.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantObjectObjectJsonConverter(),
                    new global::G.JsonConverters.AssistantObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsCodeTypeJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsFileSearchTypeJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsFunctionTypeJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAssistantRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateAssistantRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteAssistantResponseObjectJsonConverter(),
                    new global::G.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter(),
                    new global::G.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TruncationObjectTypeJsonConverter(),
                    new global::G.JsonConverters.TruncationObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter(),
                    new global::G.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter(),
                    new global::G.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunObjectObjectJsonConverter(),
                    new global::G.JsonConverters.RunObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.RunObjectStatusJsonConverter(),
                    new global::G.JsonConverters.RunObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RunObjectRequiredActionTypeJsonConverter(),
                    new global::G.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunToolCallObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunToolCallObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunObjectLastErrorCodeJsonConverter(),
                    new global::G.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter(),
                    new global::G.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CreateRunRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateRunRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateMessageRequestRoleJsonConverter(),
                    new global::G.JsonConverters.CreateMessageRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageFileObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::G.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::G.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateThreadAndRunRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.ThreadObjectObjectJsonConverter(),
                    new global::G.JsonConverters.ThreadObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteThreadResponseObjectJsonConverter(),
                    new global::G.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.MessageObjectObjectJsonConverter(),
                    new global::G.JsonConverters.MessageObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.MessageObjectStatusJsonConverter(),
                    new global::G.JsonConverters.MessageObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter(),
                    new global::G.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::G.JsonConverters.MessageObjectRoleJsonConverter(),
                    new global::G.JsonConverters.MessageObjectRoleNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentTextObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentRefusalObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageContentRefusalObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaObjectObjectJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentRefusalObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentRefusalObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteMessageResponseObjectJsonConverter(),
                    new global::G.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectObjectJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectStatusJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectLastErrorCodeJsonConverter(),
                    new global::G.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaObjectObjectJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter(),
                    new global::G.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreObjectObjectJsonConverter(),
                    new global::G.JsonConverters.VectorStoreObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreObjectStatusJsonConverter(),
                    new global::G.JsonConverters.VectorStoreObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::G.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::G.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter(),
                    new global::G.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileObjectObjectJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileObjectStatusJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::G.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::G.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter(),
                    new global::G.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ThreadStreamEventVariant1EventJsonConverter(),
                    new global::G.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant1EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant2EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant3EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant4EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant5EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant6EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant7EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant8EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant9EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant10EventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant1EventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant2EventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant3EventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant4EventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant5EventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant6EventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant7EventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant1EventJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant2EventJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant3EventJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant4EventJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant5EventJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter(),
                    new global::G.JsonConverters.ErrorEventEventJsonConverter(),
                    new global::G.JsonConverters.ErrorEventEventNullableJsonConverter(),
                    new global::G.JsonConverters.DoneEventEventJsonConverter(),
                    new global::G.JsonConverters.DoneEventEventNullableJsonConverter(),
                    new global::G.JsonConverters.DoneEventDataJsonConverter(),
                    new global::G.JsonConverters.DoneEventDataNullableJsonConverter(),
                    new global::G.JsonConverters.BatchObjectJsonConverter(),
                    new global::G.JsonConverters.BatchObjectNullableJsonConverter(),
                    new global::G.JsonConverters.BatchStatusJsonConverter(),
                    new global::G.JsonConverters.BatchStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchRequestInputMethodJsonConverter(),
                    new global::G.JsonConverters.BatchRequestInputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.ListBatchesResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListBatchesResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.AuditLogActorApiKeyTypeJsonConverter(),
                    new global::G.JsonConverters.AuditLogActorApiKeyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AuditLogActorTypeJsonConverter(),
                    new global::G.JsonConverters.AuditLogActorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AuditLogEventTypeJsonConverter(),
                    new global::G.JsonConverters.AuditLogEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListAuditLogsResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ListAuditLogsResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.InviteObjectJsonConverter(),
                    new global::G.JsonConverters.InviteObjectNullableJsonConverter(),
                    new global::G.JsonConverters.InviteRoleJsonConverter(),
                    new global::G.JsonConverters.InviteRoleNullableJsonConverter(),
                    new global::G.JsonConverters.InviteStatusJsonConverter(),
                    new global::G.JsonConverters.InviteStatusNullableJsonConverter(),
                    new global::G.JsonConverters.InviteListResponseObjectJsonConverter(),
                    new global::G.JsonConverters.InviteListResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.InviteRequestRoleJsonConverter(),
                    new global::G.JsonConverters.InviteRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.InviteDeleteResponseObjectJsonConverter(),
                    new global::G.JsonConverters.InviteDeleteResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.UserObjectJsonConverter(),
                    new global::G.JsonConverters.UserObjectNullableJsonConverter(),
                    new global::G.JsonConverters.UserRoleJsonConverter(),
                    new global::G.JsonConverters.UserRoleNullableJsonConverter(),
                    new global::G.JsonConverters.UserListResponseObjectJsonConverter(),
                    new global::G.JsonConverters.UserListResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.UserRoleUpdateRequestRoleJsonConverter(),
                    new global::G.JsonConverters.UserRoleUpdateRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.UserDeleteResponseObjectJsonConverter(),
                    new global::G.JsonConverters.UserDeleteResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectStatusJsonConverter(),
                    new global::G.JsonConverters.ProjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectListResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectListResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectUserObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectUserObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectUserRoleJsonConverter(),
                    new global::G.JsonConverters.ProjectUserRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectUserCreateRequestRoleJsonConverter(),
                    new global::G.JsonConverters.ProjectUserCreateRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectUserUpdateRequestRoleJsonConverter(),
                    new global::G.JsonConverters.ProjectUserUpdateRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectUserDeleteResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectUserDeleteResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountRoleJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountListResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountListResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountCreateResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountCreateResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountCreateResponseRoleJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountCreateResponseRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountApiKeyObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountApiKeyObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountDeleteResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectServiceAccountDeleteResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyOwnerTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyOwnerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyListResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyListResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyDeleteResponseObjectJsonConverter(),
                    new global::G.JsonConverters.ProjectApiKeyDeleteResponseObjectNullableJsonConverter(),
                    new global::G.JsonConverters.CreateBatchRequestEndpointJsonConverter(),
                    new global::G.JsonConverters.CreateBatchRequestEndpointNullableJsonConverter(),
                    new global::G.JsonConverters.CreateBatchRequestCompletionWindowJsonConverter(),
                    new global::G.JsonConverters.CreateBatchRequestCompletionWindowNullableJsonConverter(),
                    new global::G.JsonConverters.ListAssistantsOrderJsonConverter(),
                    new global::G.JsonConverters.ListAssistantsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListMessagesOrderJsonConverter(),
                    new global::G.JsonConverters.ListMessagesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListRunsOrderJsonConverter(),
                    new global::G.JsonConverters.ListRunsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListRunStepsOrderJsonConverter(),
                    new global::G.JsonConverters.ListRunStepsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListVectorStoresOrderJsonConverter(),
                    new global::G.JsonConverters.ListVectorStoresOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListVectorStoreFilesOrderJsonConverter(),
                    new global::G.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListVectorStoreFilesFilterJsonConverter(),
                    new global::G.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter(),
                    new global::G.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter(),
                    new global::G.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory4(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestSystemMessageContentPartJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestAssistantMessageContentPartJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestToolMessageContentPartJsonConverter(),
                    new global::G.JsonConverters.FineTuneChatCompletionRequestAssistantMessageJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory3(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory1(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory5(),
                    new global::G.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory1(),
                    new global::G.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter(),
                    new global::G.JsonConverters.ChunkingStrategyRequestParamJsonConverter(),
                    new global::G.JsonConverters.AssistantStreamEventJsonConverter(),
                    new global::G.JsonConverters.ThreadStreamEventJsonConverter(),
                    new global::G.JsonConverters.RunStreamEventJsonConverter(),
                    new global::G.JsonConverters.RunStepStreamEventJsonConverter(),
                    new global::G.JsonConverters.MessageStreamEventJsonConverter(),
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