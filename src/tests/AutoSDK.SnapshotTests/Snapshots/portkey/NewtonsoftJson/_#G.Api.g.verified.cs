//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Portkey REST API. Please see https://portkey.ai/docs/api-reference for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Portkey API Public Endpoint
        /// </summary>
        public const string DefaultBaseUrl = "https://api.portkey.ai/v1";

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
                    new global::G.JsonConverters.ModelPricingConfigCurrencyJsonConverter(),

                    new global::G.JsonConverters.ModelPricingConfigCurrencyNullableJsonConverter(),

                    new global::G.JsonConverters.ModelCalculateOperationOperationJsonConverter(),

                    new global::G.JsonConverters.ModelCalculateOperationOperationNullableJsonConverter(),

                    new global::G.JsonConverters.InviteRoleJsonConverter(),

                    new global::G.JsonConverters.InviteRoleNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceInviteRoleJsonConverter(),

                    new global::G.JsonConverters.WorkspaceInviteRoleNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceInviteTypeJsonConverter(),

                    new global::G.JsonConverters.WorkspaceInviteTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListModelsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ListModelsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateCompletionRequestModelJsonConverter(),

                    new global::G.JsonConverters.CreateCompletionRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter(),

                    new global::G.JsonConverters.CreateCompletionResponseChoiceFinishReasonNullableJsonConverter(),

                    new global::G.JsonConverters.CreateCompletionResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreateCompletionResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartImageImageUrlDetailNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageContentPartThinkingTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageContentPartThinkingTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageContentPartRedactedThinkingTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestSystemMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestSystemMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestDeveloperMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestDeveloperMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestUserMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestUserMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolTypeJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolRankingOptionsRankerNullableJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolCallStatusJsonConverter(),

                    new global::G.JsonConverters.FileSearchToolCallStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleJsonConverter(),

                    new global::G.JsonConverters.FineTuneChatCompletionRequestAssistantMessageRoleNullableJsonConverter(),

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

                    new global::G.JsonConverters.OutputAudioTypeJsonConverter(),

                    new global::G.JsonConverters.OutputAudioTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageTypeJsonConverter(),

                    new global::G.JsonConverters.OutputMessageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageRoleJsonConverter(),

                    new global::G.JsonConverters.OutputMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatusJsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatusNullableJsonConverter(),

                    new global::G.JsonConverters.OutputTextTypeJsonConverter(),

                    new global::G.JsonConverters.OutputTextTypeNullableJsonConverter(),

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

                    new global::G.JsonConverters.CreateChatCompletionRequestThinkingTypeJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionRequestThinkingTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionRequestFunctionCallJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionRequestFunctionCallNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionResponseChoiceFinishReasonNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseChoiceFinishReasonNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionFunctionResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ListPaginatedFineTuningJobsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ListPaginatedFineTuningJobsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter(),

                    new global::G.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonNullableJsonConverter(),

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

                    new global::G.JsonConverters.IncludableJsonConverter(),

                    new global::G.JsonConverters.IncludableNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionToolTypeJsonConverter(),

                    new global::G.JsonConverters.FunctionToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallStatusJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallOutputTypeJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallOutputStatusJsonConverter(),

                    new global::G.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter(),

                    new global::G.JsonConverters.InputAudioTypeJsonConverter(),

                    new global::G.JsonConverters.InputAudioTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputAudioFormatJsonConverter(),

                    new global::G.JsonConverters.InputAudioFormatNullableJsonConverter(),

                    new global::G.JsonConverters.InputFileTypeJsonConverter(),

                    new global::G.JsonConverters.InputFileTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputImageTypeJsonConverter(),

                    new global::G.JsonConverters.InputImageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputImageDetailJsonConverter(),

                    new global::G.JsonConverters.InputImageDetailNullableJsonConverter(),

                    new global::G.JsonConverters.InputMessageTypeJsonConverter(),

                    new global::G.JsonConverters.InputMessageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputMessageRoleJsonConverter(),

                    new global::G.JsonConverters.InputMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.InputMessageStatusJsonConverter(),

                    new global::G.JsonConverters.InputMessageStatusNullableJsonConverter(),

                    new global::G.JsonConverters.InputTextTypeJsonConverter(),

                    new global::G.JsonConverters.InputTextTypeNullableJsonConverter(),

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

                    new global::G.JsonConverters.ListFilesResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ListFilesResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateFileRequestPurposeJsonConverter(),

                    new global::G.JsonConverters.CreateFileRequestPurposeNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteFileResponseObjectJsonConverter(),

                    new global::G.JsonConverters.DeleteFileResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIFinetuneJobMethodTypeJsonConverter(),

                    new global::G.JsonConverters.OpenAIFinetuneJobMethodTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListFineTuningJobEventsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ListFineTuningJobEventsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ListFineTuningJobCheckpointsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateEmbeddingRequestModelJsonConverter(),

                    new global::G.JsonConverters.CreateEmbeddingRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.CreateEmbeddingRequestEncodingFormatJsonConverter(),

                    new global::G.JsonConverters.CreateEmbeddingRequestEncodingFormatNullableJsonConverter(),

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

                    new global::G.JsonConverters.ModelObjectJsonConverter(),

                    new global::G.JsonConverters.ModelObjectNullableJsonConverter(),

                    new global::G.JsonConverters.MoveTypeJsonConverter(),

                    new global::G.JsonConverters.MoveTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIFileObjectJsonConverter(),

                    new global::G.JsonConverters.OpenAIFileObjectNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIFilePurposeJsonConverter(),

                    new global::G.JsonConverters.OpenAIFilePurposeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIFileStatusJsonConverter(),

                    new global::G.JsonConverters.OpenAIFileStatusNullableJsonConverter(),

                    new global::G.JsonConverters.DoubleClickTypeJsonConverter(),

                    new global::G.JsonConverters.DoubleClickTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DragTypeJsonConverter(),

                    new global::G.JsonConverters.DragTypeNullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRoleJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageTypeJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.EmbeddingObjectJsonConverter(),

                    new global::G.JsonConverters.EmbeddingObjectNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobHyperparametersNEpochsJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobHyperparametersNEpochsNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobObjectJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobObjectNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobStatusJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuningIntegrationTypeJsonConverter(),

                    new global::G.JsonConverters.FineTuningIntegrationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobEventLevelJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobEventLevelNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobEventObjectJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobEventObjectNullableJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobCheckpointObjectJsonConverter(),

                    new global::G.JsonConverters.FineTuningJobCheckpointObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ClickTypeJsonConverter(),

                    new global::G.JsonConverters.ClickTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ClickButtonJsonConverter(),

                    new global::G.JsonConverters.ClickButtonNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterFileOutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterTextOutputTypeJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterTextOutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterToolTypeJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterToolCallStatusJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ComparisonFilterTypeJsonConverter(),

                    new global::G.JsonConverters.ComparisonFilterTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CompoundFilterTypeJsonConverter(),

                    new global::G.JsonConverters.CompoundFilterTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerScreenshotImageTypeJsonConverter(),

                    new global::G.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerToolTypeJsonConverter(),

                    new global::G.JsonConverters.ComputerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerToolEnvironmentJsonConverter(),

                    new global::G.JsonConverters.ComputerToolEnvironmentNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallStatusJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallOutputTypeJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallOutputStatusJsonConverter(),

                    new global::G.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter(),

                    new global::G.JsonConverters.CostsResultObjectJsonConverter(),

                    new global::G.JsonConverters.CostsResultObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningGenerateSummaryJsonConverter(),

                    new global::G.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningEffortJsonConverter(),

                    new global::G.JsonConverters.ReasoningEffortNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemTypeJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemSummaryItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemStatusJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.RefusalTypeJsonConverter(),

                    new global::G.JsonConverters.RefusalTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseVariant3ObjectJsonConverter(),

                    new global::G.JsonConverters.ResponseVariant3ObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.ResponseVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter(),

                    new global::G.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseCompletedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseCreatedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseErrorCodeJsonConverter(),

                    new global::G.JsonConverters.ResponseErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseErrorEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseErrorEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFailedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFailedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatTextTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatTextTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseInProgressEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseIncompleteEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseItemListObjectJsonConverter(),

                    new global::G.JsonConverters.ResponseItemListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseModalitieJsonConverter(),

                    new global::G.JsonConverters.ResponseModalitieNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseModalitiesTextOnlyItemJsonConverter(),

                    new global::G.JsonConverters.ResponseModalitiesTextOnlyItemNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsePropertiesTruncationJsonConverter(),

                    new global::G.JsonConverters.ResponsePropertiesTruncationNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseTextAnnotationDeltaEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseTextAnnotationDeltaEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseTextDeltaEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseTextDoneEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantsApiResponseFormatOptionEnumJsonConverter(),

                    new global::G.JsonConverters.AssistantsApiResponseFormatOptionEnumNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantsApiResponseFormatTypeJsonConverter(),

                    new global::G.JsonConverters.AssistantsApiResponseFormatTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantObjectObjectJsonConverter(),

                    new global::G.JsonConverters.AssistantObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateAssistantRequestModelJsonConverter(),

                    new global::G.JsonConverters.CreateAssistantRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter(),

                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter(),

                    new global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ModelIdsResponsesEnumJsonConverter(),

                    new global::G.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteAssistantResponseObjectJsonConverter(),

                    new global::G.JsonConverters.DeleteAssistantResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ItemReferenceTypeJsonConverter(),

                    new global::G.JsonConverters.ItemReferenceTypeNullableJsonConverter(),

                    new global::G.JsonConverters.KeyPressTypeJsonConverter(),

                    new global::G.JsonConverters.KeyPressTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsCodeTypeJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsCodeTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsFileSearchTypeJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsFileSearchTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsFunctionTypeJsonConverter(),

                    new global::G.JsonConverters.AssistantToolsFunctionTypeNullableJsonConverter(),

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

                    new global::G.JsonConverters.RunObjectLastErrorCodeJsonConverter(),

                    new global::G.JsonConverters.RunObjectLastErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.RunObjectIncompleteDetailsReasonJsonConverter(),

                    new global::G.JsonConverters.RunObjectIncompleteDetailsReasonNullableJsonConverter(),

                    new global::G.JsonConverters.CreateRunRequestModelJsonConverter(),

                    new global::G.JsonConverters.CreateRunRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter(),

                    new global::G.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunToolCallObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunToolCallObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ScreenshotTypeJsonConverter(),

                    new global::G.JsonConverters.ScreenshotTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ScrollTypeJsonConverter(),

                    new global::G.JsonConverters.ScrollTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateThreadAndRunRequestModelJsonConverter(),

                    new global::G.JsonConverters.CreateThreadAndRunRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.ThreadObjectObjectJsonConverter(),

                    new global::G.JsonConverters.ThreadObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeJsonConverter(),

                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategyTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter(),

                    new global::G.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeNullableJsonConverter(),

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

                    new global::G.JsonConverters.MessageDeltaObjectObjectJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaObjectDeltaRoleJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaObjectDeltaRoleNullableJsonConverter(),

                    new global::G.JsonConverters.CreateMessageRequestRoleJsonConverter(),

                    new global::G.JsonConverters.CreateMessageRequestRoleNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteMessageResponseObjectJsonConverter(),

                    new global::G.JsonConverters.DeleteMessageResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageFileObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageFileObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageFileObjectImageFileDetailNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailNullableJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageUrlObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageUrlObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter(),

                    new global::G.JsonConverters.MessageContentImageUrlObjectImageUrlDetailNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailNullableJsonConverter(),

                    new global::G.JsonConverters.MessageContentTextObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageContentTextObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageRequestContentTextObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentTextObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentTextObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter(),

                    new global::G.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectObjectJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectStatusJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectStatusNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectLastErrorCodeJsonConverter(),

                    new global::G.JsonConverters.RunStepObjectLastErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaObjectObjectJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsMessageCreationObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsMessageCreationObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsMessageCreationObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeJsonConverter(),

                    new global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFunctionObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreExpirationAfterAnchorJsonConverter(),

                    new global::G.JsonConverters.VectorStoreExpirationAfterAnchorNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreObjectObjectJsonConverter(),

                    new global::G.JsonConverters.VectorStoreObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreObjectStatusJsonConverter(),

                    new global::G.JsonConverters.VectorStoreObjectStatusNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter(),

                    new global::G.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter(),

                    new global::G.JsonConverters.VectorStoreSearchResultContentObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreSearchResultsPageObjectJsonConverter(),

                    new global::G.JsonConverters.VectorStoreSearchResultsPageObjectNullableJsonConverter(),

                    new global::G.JsonConverters.VoiceIdsSharedEnumJsonConverter(),

                    new global::G.JsonConverters.VoiceIdsSharedEnumNullableJsonConverter(),

                    new global::G.JsonConverters.WaitTypeJsonConverter(),

                    new global::G.JsonConverters.WaitTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchContextSizeJsonConverter(),

                    new global::G.JsonConverters.WebSearchContextSizeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolUserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolUserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolCallStatusJsonConverter(),

                    new global::G.JsonConverters.WebSearchToolCallStatusNullableJsonConverter(),

                    new global::G.JsonConverters.TypeType1JsonConverter(),

                    new global::G.JsonConverters.TypeType1NullableJsonConverter(),

                    new global::G.JsonConverters.UrlCitationTypeJsonConverter(),

                    new global::G.JsonConverters.UrlCitationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteVectorStoreResponseObjectJsonConverter(),

                    new global::G.JsonConverters.DeleteVectorStoreResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileObjectObjectJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileObjectStatusJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileObjectStatusNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileObjectLastErrorCodeJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileObjectLastErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.OtherChunkingStrategyResponseParamTypeJsonConverter(),

                    new global::G.JsonConverters.OtherChunkingStrategyResponseParamTypeNullableJsonConverter(),

                    new global::G.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter(),

                    new global::G.JsonConverters.StaticChunkingStrategyResponseParamTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter(),

                    new global::G.JsonConverters.AutoChunkingStrategyRequestParamTypeNullableJsonConverter(),

                    new global::G.JsonConverters.StaticChunkingStrategyRequestParamTypeJsonConverter(),

                    new global::G.JsonConverters.StaticChunkingStrategyRequestParamTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteVectorStoreFileResponseObjectJsonConverter(),

                    new global::G.JsonConverters.DeleteVectorStoreFileResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileBatchObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter(),

                    new global::G.JsonConverters.VectorStoreFileBatchObjectStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ThreadStreamEventVariant1EventJsonConverter(),

                    new global::G.JsonConverters.ThreadStreamEventVariant1EventNullableJsonConverter(),

                    new global::G.JsonConverters.ToolChoiceFunctionTypeJsonConverter(),

                    new global::G.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ToolChoiceOptionsJsonConverter(),

                    new global::G.JsonConverters.ToolChoiceOptionsNullableJsonConverter(),

                    new global::G.JsonConverters.ToolChoiceTypesTypeJsonConverter(),

                    new global::G.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter(),

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

                    new global::G.JsonConverters.FileCitationTypeJsonConverter(),

                    new global::G.JsonConverters.FileCitationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FilePathTypeJsonConverter(),

                    new global::G.JsonConverters.FilePathTypeNullableJsonConverter(),

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

                    new global::G.JsonConverters.RateLimitsTypeJsonConverter(),

                    new global::G.JsonConverters.RateLimitsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RateLimitsUnitJsonConverter(),

                    new global::G.JsonConverters.RateLimitsUnitNullableJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsTypeJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPeriodicResetJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPeriodicResetNullableJsonConverter(),

                    new global::G.JsonConverters.AzureOpenAIConfigurationAzureAuthModeJsonConverter(),

                    new global::G.JsonConverters.AzureOpenAIConfigurationAzureAuthModeNullableJsonConverter(),

                    new global::G.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter(),

                    new global::G.JsonConverters.BedrockConfigurationAwsAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.VertexAIConfigurationVertexAuthTypeJsonConverter(),

                    new global::G.JsonConverters.VertexAIConfigurationVertexAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AzureAIConfigurationAzureAuthModeJsonConverter(),

                    new global::G.JsonConverters.AzureAIConfigurationAzureAuthModeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter(),

                    new global::G.JsonConverters.CreateSecretReferenceRequestManagerTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceListItemManagerTypeJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceListItemManagerTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceListItemStatusJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceListItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceListItemObjectJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceListItemObjectNullableJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceDetailResponseManagerTypeJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceDetailResponseManagerTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceDetailResponseStatusJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceDetailResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceDetailResponseObjectJsonConverter(),

                    new global::G.JsonConverters.SecretReferenceDetailResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter(),

                    new global::G.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter(),

                    new global::G.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter(),

                    new global::G.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AzureEntraAuthConfigAzureAuthModeJsonConverter(),

                    new global::G.JsonConverters.AzureEntraAuthConfigAzureAuthModeNullableJsonConverter(),

                    new global::G.JsonConverters.AzureManagedAuthConfigAzureAuthModeJsonConverter(),

                    new global::G.JsonConverters.AzureManagedAuthConfigAzureAuthModeNullableJsonConverter(),

                    new global::G.JsonConverters.AzureDefaultAuthConfigAzureAuthModeJsonConverter(),

                    new global::G.JsonConverters.AzureDefaultAuthConfigAzureAuthModeNullableJsonConverter(),

                    new global::G.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeJsonConverter(),

                    new global::G.JsonConverters.HashicorpTokenAuthConfigVaultAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeJsonConverter(),

                    new global::G.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeJsonConverter(),

                    new global::G.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.IntegrationListStatusJsonConverter(),

                    new global::G.JsonConverters.IntegrationListStatusNullableJsonConverter(),

                    new global::G.JsonConverters.IntegrationListObjectJsonConverter(),

                    new global::G.JsonConverters.IntegrationListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.PricingConfigTypeJsonConverter(),

                    new global::G.JsonConverters.PricingConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ProvidersStatusJsonConverter(),

                    new global::G.JsonConverters.ProvidersStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ProvidersObjectJsonConverter(),

                    new global::G.JsonConverters.ProvidersObjectNullableJsonConverter(),

                    new global::G.JsonConverters.VirtualKeysStatusJsonConverter(),

                    new global::G.JsonConverters.VirtualKeysStatusNullableJsonConverter(),

                    new global::G.JsonConverters.VirtualKeysObjectJsonConverter(),

                    new global::G.JsonConverters.VirtualKeysObjectNullableJsonConverter(),

                    new global::G.JsonConverters.InviteRole2JsonConverter(),

                    new global::G.JsonConverters.InviteRole2NullableJsonConverter(),

                    new global::G.JsonConverters.InviteStatusJsonConverter(),

                    new global::G.JsonConverters.InviteStatusNullableJsonConverter(),

                    new global::G.JsonConverters.InviteListObjectJsonConverter(),

                    new global::G.JsonConverters.InviteListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.UserObjectJsonConverter(),

                    new global::G.JsonConverters.UserObjectNullableJsonConverter(),

                    new global::G.JsonConverters.UserRoleJsonConverter(),

                    new global::G.JsonConverters.UserRoleNullableJsonConverter(),

                    new global::G.JsonConverters.UserListObjectJsonConverter(),

                    new global::G.JsonConverters.UserListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberObjectJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberObjectNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberOrgRoleJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberOrgRoleNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberRoleJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberRoleNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberStatusJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberStatusNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberListObjectJsonConverter(),

                    new global::G.JsonConverters.WorkspaceMemberListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceDefaultsObjectJsonConverter(),

                    new global::G.JsonConverters.WorkspaceDefaultsObjectNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceListObjectJsonConverter(),

                    new global::G.JsonConverters.WorkspaceListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.WorkspaceWithUsersDefaultsObjectJsonConverter(),

                    new global::G.JsonConverters.WorkspaceWithUsersDefaultsObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CollectionStatusJsonConverter(),

                    new global::G.JsonConverters.CollectionStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptSummaryObjectJsonConverter(),

                    new global::G.JsonConverters.PromptSummaryObjectNullableJsonConverter(),

                    new global::G.JsonConverters.PromptPromptVersionStatusJsonConverter(),

                    new global::G.JsonConverters.PromptPromptVersionStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionSummaryStatusJsonConverter(),

                    new global::G.JsonConverters.PromptVersionSummaryStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionSummaryObjectJsonConverter(),

                    new global::G.JsonConverters.PromptVersionSummaryObjectNullableJsonConverter(),

                    new global::G.JsonConverters.PromptPartialSummaryStatusJsonConverter(),

                    new global::G.JsonConverters.PromptPartialSummaryStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptPartialSummaryObjectJsonConverter(),

                    new global::G.JsonConverters.PromptPartialSummaryObjectNullableJsonConverter(),

                    new global::G.JsonConverters.PromptPartialStatusJsonConverter(),

                    new global::G.JsonConverters.PromptPartialStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter(),

                    new global::G.JsonConverters.PromptPartialVersionPromptVersionStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PromptPartialVersionObjectJsonConverter(),

                    new global::G.JsonConverters.PromptPartialVersionObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ExportListResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ExportListResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ExportItemStatusJsonConverter(),

                    new global::G.JsonConverters.ExportItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ExportItemObjectJsonConverter(),

                    new global::G.JsonConverters.ExportItemObjectNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateExportResponseObjectJsonConverter(),

                    new global::G.JsonConverters.UpdateExportResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ExportTaskResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ExportTaskResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.LogRequestMethodJsonConverter(),

                    new global::G.JsonConverters.LogRequestMethodNullableJsonConverter(),

                    new global::G.JsonConverters.LogExportsRequestedDataItemJsonConverter(),

                    new global::G.JsonConverters.LogExportsRequestedDataItemNullableJsonConverter(),

                    new global::G.JsonConverters.AuditLogObjectListRecordMethodJsonConverter(),

                    new global::G.JsonConverters.AuditLogObjectListRecordMethodNullableJsonConverter(),

                    new global::G.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter(),

                    new global::G.JsonConverters.AuditLogObjectListRecordUserTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AuditLogObjectListObjectJsonConverter(),

                    new global::G.JsonConverters.AuditLogObjectListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectTypeJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectStatusJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectCreationModeJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectCreationModeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectObjectJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectListObjectJsonConverter(),

                    new global::G.JsonConverters.ApiKeyObjectListObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailCheckIdJsonConverter(),

                    new global::G.JsonConverters.GuardrailCheckIdNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailSummaryStatusJsonConverter(),

                    new global::G.JsonConverters.GuardrailSummaryStatusNullableJsonConverter(),

                    new global::G.JsonConverters.JSONKeysParametersOperatorJsonConverter(),

                    new global::G.JsonConverters.JSONKeysParametersOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.ContainsParametersOperatorJsonConverter(),

                    new global::G.JsonConverters.ContainsParametersOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.ContainsCodeParametersFormatJsonConverter(),

                    new global::G.JsonConverters.ContainsCodeParametersFormatNullableJsonConverter(),

                    new global::G.JsonConverters.RequiredMetadataKeysParametersOperatorJsonConverter(),

                    new global::G.JsonConverters.RequiredMetadataKeysParametersOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.AllowedRequestTypesParametersAllowedTypeJsonConverter(),

                    new global::G.JsonConverters.AllowedRequestTypesParametersAllowedTypeNullableJsonConverter(),

                    new global::G.JsonConverters.AllowedRequestTypesParametersBlockedTypeJsonConverter(),

                    new global::G.JsonConverters.AllowedRequestTypesParametersBlockedTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PillarScanParametersScannerJsonConverter(),

                    new global::G.JsonConverters.PillarScanParametersScannerNullableJsonConverter(),

                    new global::G.JsonConverters.PortkeyModerationParametersCategorieJsonConverter(),

                    new global::G.JsonConverters.PortkeyModerationParametersCategorieNullableJsonConverter(),

                    new global::G.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter(),

                    new global::G.JsonConverters.PortkeyLanguageParametersLanguageNullableJsonConverter(),

                    new global::G.JsonConverters.PortkeyPIIParametersCategorieJsonConverter(),

                    new global::G.JsonConverters.PortkeyPIIParametersCategorieNullableJsonConverter(),

                    new global::G.JsonConverters.MistralModerationParametersCategorieJsonConverter(),

                    new global::G.JsonConverters.MistralModerationParametersCategorieNullableJsonConverter(),

                    new global::G.JsonConverters.AcuvityScanParametersLanguageValuesJsonConverter(),

                    new global::G.JsonConverters.AcuvityScanParametersLanguageValuesNullableJsonConverter(),

                    new global::G.JsonConverters.AcuvityScanParametersPiiCategorieJsonConverter(),

                    new global::G.JsonConverters.AcuvityScanParametersPiiCategorieNullableJsonConverter(),

                    new global::G.JsonConverters.AcuvityScanParametersSecretsCategorieJsonConverter(),

                    new global::G.JsonConverters.AcuvityScanParametersSecretsCategorieNullableJsonConverter(),

                    new global::G.JsonConverters.AzureContentSafetyParametersCategorieJsonConverter(),

                    new global::G.JsonConverters.AzureContentSafetyParametersCategorieNullableJsonConverter(),

                    new global::G.JsonConverters.AzurePIIParametersDomainJsonConverter(),

                    new global::G.JsonConverters.AzurePIIParametersDomainNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter(),

                    new global::G.JsonConverters.OpenAIBatchJobCompletionWindowNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIBatchJobEndpointJsonConverter(),

                    new global::G.JsonConverters.OpenAIBatchJobEndpointNullableJsonConverter(),

                    new global::G.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter(),

                    new global::G.JsonConverters.CreateUsageLimitsPolicyRequestTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter(),

                    new global::G.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetJsonConverter(),

                    new global::G.JsonConverters.UpdateUsageLimitsPolicyRequestPeriodicResetNullableJsonConverter(),

                    new global::G.JsonConverters.CreateRateLimitsPolicyRequestTypeJsonConverter(),

                    new global::G.JsonConverters.CreateRateLimitsPolicyRequestTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateRateLimitsPolicyRequestUnitJsonConverter(),

                    new global::G.JsonConverters.CreateRateLimitsPolicyRequestUnitNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateRateLimitsPolicyRequestUnitJsonConverter(),

                    new global::G.JsonConverters.UpdateRateLimitsPolicyRequestUnitNullableJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPolicyTypeJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPolicyTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPolicyPeriodicResetNullableJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPolicyStatusJsonConverter(),

                    new global::G.JsonConverters.UsageLimitsPolicyStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ValueKeyUsageStatusJsonConverter(),

                    new global::G.JsonConverters.ValueKeyUsageStatusNullableJsonConverter(),

                    new global::G.JsonConverters.RateLimitsPolicyTypeJsonConverter(),

                    new global::G.JsonConverters.RateLimitsPolicyTypeNullableJsonConverter(),

                    new global::G.JsonConverters.RateLimitsPolicyUnitJsonConverter(),

                    new global::G.JsonConverters.RateLimitsPolicyUnitNullableJsonConverter(),

                    new global::G.JsonConverters.RateLimitsPolicyStatusJsonConverter(),

                    new global::G.JsonConverters.RateLimitsPolicyStatusNullableJsonConverter(),

                    new global::G.JsonConverters.CreateMcpIntegrationAuthTypeJsonConverter(),

                    new global::G.JsonConverters.CreateMcpIntegrationAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateMcpIntegrationTransportJsonConverter(),

                    new global::G.JsonConverters.CreateMcpIntegrationTransportNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationAuthTypeJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationTransportJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationTransportNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationTypeJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationListItemTypeJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationListItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationListItemAuthTypeJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationListItemAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationListItemTransportJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationListItemTransportNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter(),

                    new global::G.JsonConverters.UpdateMcpIntegrationAuthTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UpdateMcpIntegrationTransportJsonConverter(),

                    new global::G.JsonConverters.UpdateMcpIntegrationTransportNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationCapabilityItemTypeJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationCapabilityItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeJsonConverter(),

                    new global::G.JsonConverters.BulkUpdateMcpIntegrationCapabilitiesCapabilitieTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpServerCapabilityItemTypeJsonConverter(),

                    new global::G.JsonConverters.McpServerCapabilityItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter(),

                    new global::G.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter(),

                    new global::G.JsonConverters.McpServerUserAccessItemConnectionStatusNullableJsonConverter(),

                    new global::G.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter(),

                    new global::G.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter(),

                    new global::G.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessJsonConverter(),

                    new global::G.JsonConverters.BulkUpdateMcpServerUserAccessDefaultUserAccessNullableJsonConverter(),

                    new global::G.JsonConverters.CreateVirtualKeysRequestProviderJsonConverter(),

                    new global::G.JsonConverters.CreateVirtualKeysRequestProviderNullableJsonConverter(),

                    new global::G.JsonConverters.PutAdminUsersRequestRoleJsonConverter(),

                    new global::G.JsonConverters.PutAdminUsersRequestRoleNullableJsonConverter(),

                    new global::G.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleJsonConverter(),

                    new global::G.JsonConverters.CreateAdminWorkspacesUsersRequestUserRoleNullableJsonConverter(),

                    new global::G.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter(),

                    new global::G.JsonConverters.PutAdminWorkspacesUsersRequestRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ListModelsSortJsonConverter(),

                    new global::G.JsonConverters.ListModelsSortNullableJsonConverter(),

                    new global::G.JsonConverters.ListModelsOrderJsonConverter(),

                    new global::G.JsonConverters.ListModelsOrderNullableJsonConverter(),

                    new global::G.JsonConverters.ListAssistantsOrderJsonConverter(),

                    new global::G.JsonConverters.ListAssistantsOrderNullableJsonConverter(),

                    new global::G.JsonConverters.ListInputItemsOrderJsonConverter(),

                    new global::G.JsonConverters.ListInputItemsOrderNullableJsonConverter(),

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

                    new global::G.JsonConverters.GetIntegrationsTypeJsonConverter(),

                    new global::G.JsonConverters.GetIntegrationsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetAdminUsersInvitesRoleJsonConverter(),

                    new global::G.JsonConverters.GetAdminUsersInvitesRoleNullableJsonConverter(),

                    new global::G.JsonConverters.GetAdminUsersInvitesStatusJsonConverter(),

                    new global::G.JsonConverters.GetAdminUsersInvitesStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetAdminUsersRoleJsonConverter(),

                    new global::G.JsonConverters.GetAdminUsersRoleNullableJsonConverter(),

                    new global::G.JsonConverters.GetAdminWorkspacesUsersRoleJsonConverter(),

                    new global::G.JsonConverters.GetAdminWorkspacesUsersRoleNullableJsonConverter(),

                    new global::G.JsonConverters.GetAdminWorkspacesStatusJsonConverter(),

                    new global::G.JsonConverters.GetAdminWorkspacesStatusNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationsListTypeJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationsListTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationCapabilitiesListTypeJsonConverter(),

                    new global::G.JsonConverters.McpIntegrationCapabilitiesListTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpServerCapabilitiesListTypeJsonConverter(),

                    new global::G.JsonConverters.McpServerCapabilitiesListTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuditLogsMethodJsonConverter(),

                    new global::G.JsonConverters.GetAuditLogsMethodNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuditLogsUserTypeJsonConverter(),

                    new global::G.JsonConverters.GetAuditLogsUserTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateKeysTypeJsonConverter(),

                    new global::G.JsonConverters.CreateKeysTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreateKeysSubTypeJsonConverter(),

                    new global::G.JsonConverters.CreateKeysSubTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListUsageLimitsPoliciesStatusJsonConverter(),

                    new global::G.JsonConverters.ListUsageLimitsPoliciesStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ListUsageLimitsPoliciesTypeJsonConverter(),

                    new global::G.JsonConverters.ListUsageLimitsPoliciesTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetUsageLimitsPolicyStatusJsonConverter(),

                    new global::G.JsonConverters.GetUsageLimitsPolicyStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ListUsageLimitsPolicyEntitiesStatusJsonConverter(),

                    new global::G.JsonConverters.ListUsageLimitsPolicyEntitiesStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ListRateLimitsPoliciesStatusJsonConverter(),

                    new global::G.JsonConverters.ListRateLimitsPoliciesStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ListRateLimitsPoliciesTypeJsonConverter(),

                    new global::G.JsonConverters.ListRateLimitsPoliciesTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ListRateLimitsPoliciesUnitJsonConverter(),

                    new global::G.JsonConverters.ListRateLimitsPoliciesUnitNullableJsonConverter(),

                    new global::G.JsonConverters.GetRateLimitsPolicyStatusJsonConverter(),

                    new global::G.JsonConverters.GetRateLimitsPolicyStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ListSecretReferencesManagerTypeJsonConverter(),

                    new global::G.JsonConverters.ListSecretReferencesManagerTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CreatePromptResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreatePromptResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetIntegrationsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetIntegrationsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetProvidersResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetProvidersResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetVirtualKeysResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetVirtualKeysResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateKeysResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreateKeysResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsCostResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsCostResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsTokensResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsTokensResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsUsersResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsUsersResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsUsersRequestsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsRateResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsStacksResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsErrorsStatusCodesResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsRequestsRescuedResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsCacheHitRateResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsCacheLatencyResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksScoresResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksWeightedResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsSummaryCacheResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsSummaryCacheResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsUsersResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsUsersResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsUsersResponseDataItemObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsAiModelsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsAiModelsResponseDataItemObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsMetadataResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectJsonConverter(),

                    new global::G.JsonConverters.GetAnalyticsGroupsMetadataResponseDataItemObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ListSecretReferencesResponseObjectJsonConverter(),

                    new global::G.JsonConverters.ListSecretReferencesResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateSecretReferenceResponseObjectJsonConverter(),

                    new global::G.JsonConverters.CreateSecretReferenceResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// Get data points for graphical representation.
        /// </summary>
        public AnalyticsGraphsClient AnalyticsGraphs => new AnalyticsGraphsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get grouped metrics for the selected time bucket.
        /// </summary>
        public AnalyticsGroupsClient AnalyticsGroups => new AnalyticsGroupsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get overall summary for the selected time bucket.
        /// </summary>
        public AnalyticsSummaryClient AnalyticsSummary => new AnalyticsSummaryClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey API keys.
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Build Assistants that can call models and use tools.
        /// </summary>
        public AssistantsClient Assistants => new AssistantsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Turn audio into text or text into audio.
        /// </summary>
        public AudioClient Audio => new AudioClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get audit logs for your Portkey account.
        /// </summary>
        public AuditLogsClient AuditLogs => new AuditLogsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create large batches of API requests to run asynchronously.
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete collections of prompts.
        /// </summary>
        public CollectionsClient Collections => new CollectionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, and Update your Portkey Configs.
        /// </summary>
        public ConfigsClient Configs => new ConfigsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Send and Update any feedback.
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Files are used to upload documents that can be used with features like Assistants and Fine-tuning.
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage fine-tuning jobs to tailor a model to your specific training data.
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FinetuneClient Finetune => new FinetuneClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete prompt Guardrails.
        /// </summary>
        public GuardrailsClient Guardrails => new GuardrailsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a prompt and/or an input image, the model will generate a new image.
        /// </summary>
        public ImagesClient Images => new ImagesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Integrations.
        /// </summary>
        public IntegrationsClient Integrations => new IntegrationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage model access for your Portkey Integrations.
        /// </summary>
        public IntegrationsModelsClient IntegrationsModels => new IntegrationsModelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage workspace access for your Portkey Integrations.
        /// </summary>
        public IntegrationsWorkspacesClient IntegrationsWorkspaces => new IntegrationsWorkspacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete labels.
        /// </summary>
        public LabelsClient Labels => new LabelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Custom Logger to add external logs to Portkey.
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Exports logs service.
        /// </summary>
        public LogsExportClient LogsExport => new LogsExportClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete MCP Integrations.
        /// </summary>
        public McpIntegrationsClient McpIntegrations => new McpIntegrationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and manage capabilities for MCP Integrations.
        /// </summary>
        public McpIntegrationsCapabilitiesClient McpIntegrationsCapabilities => new McpIntegrationsCapabilitiesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Get MCP Integration metadata and sync info.
        /// </summary>
        public McpIntegrationsMetadataClient McpIntegrationsMetadata => new McpIntegrationsMetadataClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage workspace access for MCP Integrations.
        /// </summary>
        public McpIntegrationsWorkspacesClient McpIntegrationsWorkspaces => new McpIntegrationsWorkspacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete MCP Servers (workspace instances of MCP Integrations).
        /// </summary>
        public McpServersClient McpServers => new McpServersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and manage capabilities for MCP Servers.
        /// </summary>
        public McpServersCapabilitiesClient McpServersCapabilities => new McpServersCapabilitiesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and manage user access for MCP Servers.
        /// </summary>
        public McpServersUserAccessClient McpServersUserAccess => new McpServersUserAccessClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Model pricing configurations for 2300+ LLMs across 40+ providers.
        /// </summary>
        public ModelPricingClient ModelPricing => new ModelPricingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List and describe the various models available in the API.
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a input text, outputs if the model classifies it as potentially harmful.
        /// </summary>
        public ModerationsClient Moderations => new ModerationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete prompt partials.
        /// </summary>
        public PromptPartialsClient PromptPartials => new PromptPartialsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Given a prompt template ID and variables, will run the saved prompt template and return a response.
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Providers.
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage rate limits policies to control request or token rates.
        /// </summary>
        public RateLimitsPoliciesClient RateLimitsPolicies => new RateLimitsPoliciesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// WebSocket proxy for provider Realtime APIs.
        /// </summary>
        public RealtimeClient Realtime => new RealtimeClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClient Responses => new ResponsesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete secret references to external secret managers.
        /// </summary>
        public SecretReferencesClient SecretReferences => new SecretReferencesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage usage limits policies to control total usage over time.
        /// </summary>
        public UsageLimitsPoliciesClient UsageLimitsPolicies => new UsageLimitsPoliciesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage user invites.
        /// </summary>
        public UserInvitesClient UserInvites => new UserInvitesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage users.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VectorStoresClient VectorStores => new VectorStoresClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, List, Retrieve, Update, and Delete your Portkey Virtual keys.
        /// </summary>
        public VirtualKeysClient VirtualKeys => new VirtualKeysClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage workspaces.
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage workspace members.
        /// </summary>
        public WorkspacesMembersClient WorkspacesMembers => new WorkspacesMembersClient(HttpClient, authorizations: Authorizations, options: Options)
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