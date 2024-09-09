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
                    new global::AutoSDK.JsonConverters.ListModelsResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListModelsResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateCompletionRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateCompletionRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateCompletionResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatTextTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatTextTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolChoiceOptionEnumJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolChoiceOptionEnumNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionRequestServiceTierJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionRequestServiceTierNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionResponseServiceTierJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionResponseServiceTierNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningIntegrationTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionStreamResponseServiceTierJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionStreamResponseServiceTierNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestQualityJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestQualityNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestResponseFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestSizeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestSizeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestStyleJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageRequestStyleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageEditRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageEditRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageEditRequestSizeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageVariationRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageVariationRequestSizeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateModerationRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateModerationRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OpenAIFileObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.OpenAIFileObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OpenAIFilePurposeJsonConverter(),
                    new global::AutoSDK.JsonConverters.OpenAIFilePurposeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OpenAIFileStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.OpenAIFileStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFilesResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFilesResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFileRequestPurposeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFileRequestPurposeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteFileResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteFileResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateUploadRequestPurposeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateUploadRequestPurposeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestIntegrationTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateFineTuningJobRequestIntegrationTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobEventLevelJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobEventLevelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobEventObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobEventObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobCheckpointObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbeddingRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmbeddingObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbeddingResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranscriptionRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranslationRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateTranslationRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateSpeechRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateSpeechRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateSpeechRequestVoiceJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UploadStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.UploadStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UploadObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.UploadObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UploadPartObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.UploadPartObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsCodeTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsFileSearchTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsFunctionTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateAssistantRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateAssistantRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteAssistantResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TruncationObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.TruncationObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantsApiToolChoiceOptionEnumJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantsApiToolChoiceOptionEnumNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectRequiredActionTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunToolCallObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunToolCallObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectLastErrorCodeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateRunRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateRunRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateMessageRequestRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateMessageRequestRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageFileObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateThreadAndRunRequestModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ThreadObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ThreadObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteThreadResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageObjectRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentTextObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentRefusalObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageContentRefusalObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentRefusalObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentRefusalObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteMessageResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectLastErrorCodeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreObjectStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreObjectStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileObjectStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ThreadStreamEventVariant1EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant1EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant2EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant3EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant4EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant5EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant6EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant7EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant8EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant9EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant10EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant1EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant2EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant3EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant4EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant5EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant6EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant7EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant1EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant2EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant3EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant4EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant5EventJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ErrorEventEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ErrorEventEventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DoneEventEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.DoneEventEventNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DoneEventDataJsonConverter(),
                    new global::AutoSDK.JsonConverters.DoneEventDataNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchRequestInputMethodJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchRequestInputMethodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListBatchesResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListBatchesResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuditLogActorApiKeyTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuditLogActorApiKeyTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuditLogActorTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuditLogActorTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuditLogEventTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AuditLogEventTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListAuditLogsResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListAuditLogsResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteListResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteListResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteRequestRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteRequestRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteDeleteResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.InviteDeleteResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserListResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserListResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserRoleUpdateRequestRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserRoleUpdateRequestRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserDeleteResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserDeleteResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectListResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectListResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserCreateRequestRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserCreateRequestRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserUpdateRequestRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserUpdateRequestRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserDeleteResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectUserDeleteResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountListResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountListResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountCreateResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountCreateResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountCreateResponseRoleJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountCreateResponseRoleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountApiKeyObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountApiKeyObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountDeleteResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectServiceAccountDeleteResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyOwnerTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyOwnerTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyListResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyListResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyDeleteResponseObjectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ProjectApiKeyDeleteResponseObjectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateBatchRequestEndpointJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateBatchRequestEndpointNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateBatchRequestCompletionWindowJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateBatchRequestCompletionWindowNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListAssistantsOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListAssistantsOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListMessagesOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListMessagesOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRunsOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRunsOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRunStepsOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRunStepsOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListVectorStoresOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListVectorStoresOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListVectorStoreFilesOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListVectorStoreFilesFilterJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory4(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestMessageJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestSystemMessageContentPartJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestAssistantMessageContentPartJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionRequestToolMessageContentPartJsonConverter(),
                    new global::AutoSDK.JsonConverters.FineTuneChatCompletionRequestAssistantMessageJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory3(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory1(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory5(),
                    new global::AutoSDK.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory1(),
                    new global::AutoSDK.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChunkingStrategyRequestParamJsonConverter(),
                    new global::AutoSDK.JsonConverters.AssistantStreamEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.ThreadStreamEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStreamEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunStepStreamEventJsonConverter(),
                    new global::AutoSDK.JsonConverters.MessageStreamEventJsonConverter(),
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