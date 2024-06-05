//HintName: G.OpenAiClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class OpenAiClient : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Build Assistants that can call models and use tools.
        /// </summary>
        public AssistantsClient Assistants => new AssistantsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Learn how to turn audio into text or text into audio.
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
        /// 
        /// </summary>
        public VectorStoresClient VectorStores => new VectorStoresClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the OpenAiClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public OpenAiClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://api.openai.com/v1");
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::OpenApiGenerator.JsonConverters.ListModelsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionResponseChoicesFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateCompletionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionRequestFunctionMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionToolTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionMessageToolCallChunkTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestResponseFormatTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseChoicesFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionFunctionResponseChoicesFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseChoicesFinishReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestQualityJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestStyleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageEditRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateImageVariationRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModerationRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFileRequestPurposeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteFileResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersBatchSizeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersLearningRateMultiplierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestHyperparametersNEpochsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestIntegrationsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateFineTuningJobRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEmbeddingResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranscriptionRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateTranslationRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestVoiceJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateSpeechRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFileObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFilePurposeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OpenAIFileStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmbeddingObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningIntegrationTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobEventLevelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobEventObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FineTuningJobCheckpointObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantObjectResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateAssistantRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModifyAssistantRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteAssistantResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsCodeTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFileSearchTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantToolsFunctionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TruncationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectRequiredActionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectLastErrorCodeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectToolChoiceJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunObjectResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateRunRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateRunRequestToolChoiceJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateRunRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunToolCallObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadAndRunRequestModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadAndRunRequestToolChoiceJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateThreadAndRunRequestResponseFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ThreadObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteThreadResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageObjectRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateMessageRequestRoleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteMessageResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageFileObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectLastErrorCodeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ErrorEventEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneEventEventJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DoneEventDataJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchRequestInputMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListBatchesResponseObjectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListAssistantsOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListMessagesOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRunsOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRunStepsOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoresOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoreFilesOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListVectorStoreFilesFilterJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesInVectorStoreBatchOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListFilesInVectorStoreBatchFilterJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateBatchRequestEndpointJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateBatchRequestCompletionWindowJsonConverter(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}