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
                    new global::OpenApiGenerator.JsonConverters.ListModelsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListModelsResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartRefusalTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestToolMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestFunctionMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatTextTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatTextTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolChoiceOptionVariant1JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolChoiceOptionVariant1NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionNamedToolChoiceTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageToolCallChunkTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestServiceTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestServiceTierNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseServiceTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseServiceTierNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningIntegrationTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseServiceTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseServiceTierNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestQualityJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestQualityNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestResponseFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestSizeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestStyleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestStyleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestSizeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestResponseFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestResponseFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestSizeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModerationRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModerationRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFileObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFileObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFilePurposeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFilePurposeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFileStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFileStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFileRequestPurposeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFileRequestPurposeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteFileResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteFileResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateUploadRequestPurposeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateUploadRequestPurposeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestIntegrationTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestIntegrationTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobEventLevelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobEventLevelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobEventObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobEventObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobCheckpointObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestResponseFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestTimestampGranularitieJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestTimestampGranularitieNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranslationRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranslationRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestVoiceJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestVoiceNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UploadStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UploadStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UploadObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UploadObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UploadPartObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UploadPartObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsApiResponseFormatOptionVariant1JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsApiResponseFormatOptionVariant1NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsCodeTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFileSearchTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFunctionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteAssistantResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TruncationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TruncationObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsApiToolChoiceOptionVariant1JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsApiToolChoiceOptionVariant1NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsNamedToolChoiceTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectRequiredActionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectRequiredActionTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunToolCallObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunToolCallObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectLastErrorCodeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateRunRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateRunRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateMessageRequestRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateMessageRequestRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageFileObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadAndRunRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ThreadObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ThreadObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteThreadResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteThreadResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectIncompleteDetailsReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentRefusalObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentRefusalObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentRefusalObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentRefusalObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteMessageResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectLastErrorCodeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreObjectStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ThreadStreamEventVariant1EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant1EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant1EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant2EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant2EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant3EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant3EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant4EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant4EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant5EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant5EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant6EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant6EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant7EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant7EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant8EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant8EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant9EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant9EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant10EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventVariant10EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant1EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant1EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant2EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant2EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant3EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant3EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant4EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant4EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant5EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant5EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant6EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant6EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant7EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventVariant7EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant1EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant1EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant2EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant2EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant3EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant3EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant4EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant4EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant5EventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventVariant5EventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ErrorEventEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ErrorEventEventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneEventEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneEventEventNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneEventDataJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneEventDataNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchRequestInputMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchRequestInputMethodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListBatchesResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListBatchesResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuditLogActorApiKeyTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuditLogActorApiKeyTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuditLogActorTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuditLogActorTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuditLogEventTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AuditLogEventTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListAuditLogsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListAuditLogsResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteListResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteListResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteRequestRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteRequestRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteDeleteResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.InviteDeleteResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserListResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserListResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserRoleUpdateRequestRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserRoleUpdateRequestRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserDeleteResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserDeleteResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectListResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectListResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserCreateRequestRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserCreateRequestRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserUpdateRequestRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserUpdateRequestRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserDeleteResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectUserDeleteResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountListResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountListResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountCreateResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountCreateResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountCreateResponseRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountCreateResponseRoleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountApiKeyObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountApiKeyObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountDeleteResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectServiceAccountDeleteResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyOwnerTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyOwnerTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyListResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyListResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyDeleteResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ProjectApiKeyDeleteResponseObjectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateBatchRequestEndpointJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateBatchRequestEndpointNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateBatchRequestCompletionWindowJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateBatchRequestCompletionWindowNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListAssistantsOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListAssistantsOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListMessagesOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListMessagesOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRunsOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRunsOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRunStepsOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRunStepsOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoresOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoresOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoreFilesOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoreFilesOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoreFilesFilterJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoreFilesFilterNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesInVectorStoreBatchOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesInVectorStoreBatchFilterNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory1(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory4(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory3(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory1(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory5(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestSystemMessageContentPartJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestUserMessageContentPartJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestAssistantMessageContentPartJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestToolMessageContentPartJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsApiToolChoiceOptionJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChunkingStrategyRequestParamJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantStreamEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ThreadStreamEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStreamEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepStreamEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageStreamEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuneChatCompletionRequestAssistantMessageJsonConverter(),
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