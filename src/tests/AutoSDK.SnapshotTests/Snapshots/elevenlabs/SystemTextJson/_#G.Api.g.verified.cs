//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the documentation for the ElevenLabs API. You can use this API to use our service programmatically, this is done by using your API key. You can find your API key in the dashboard at https://elevenlabs.io/app/settings/api-keys.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "";

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
                    new global::G.JsonConverters.ASRInputFormatJsonConverter(),
                    new global::G.JsonConverters.ASRInputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ASRProviderJsonConverter(),
                    new global::G.JsonConverters.ASRProviderNullableJsonConverter(),
                    new global::G.JsonConverters.ASRQualityJsonConverter(),
                    new global::G.JsonConverters.ASRQualityNullableJsonConverter(),
                    new global::G.JsonConverters.ASTAndOperatorNodeInputChildrenItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTAndOperatorNodeInputChildrenItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTAndOperatorNodeOutputChildrenItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTAndOperatorNodeOutputChildrenItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeInputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeInputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeOutputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeInputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeInputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeOutputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeOutputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeInputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeInputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeInputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeInputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTNotEqualsOperatorNodeOutputRightDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTOrOperatorNodeInputChildrenItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTOrOperatorNodeInputChildrenItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ASTOrOperatorNodeOutputChildrenItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ASTOrOperatorNodeOutputChildrenItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter(),
                    new global::G.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::G.JsonConverters.AgentDefinitionSourceJsonConverter(),
                    new global::G.JsonConverters.AgentDefinitionSourceNullableJsonConverter(),
                    new global::G.JsonConverters.AgentSortByJsonConverter(),
                    new global::G.JsonConverters.AgentSortByNullableJsonConverter(),
                    new global::G.JsonConverters.AgentTestEntityTypeJsonConverter(),
                    new global::G.JsonConverters.AgentTestEntityTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AgentWorkflowResponseModelNodesDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AllowedOutputFormatsJsonConverter(),
                    new global::G.JsonConverters.AllowedOutputFormatsNullableJsonConverter(),
                    new global::G.JsonConverters.ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSourceJsonConverter(),
                    new global::G.JsonConverters.ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::G.JsonConverters.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSourceJsonConverter(),
                    new global::G.JsonConverters.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::G.JsonConverters.AsyncConversationMetadataDeliveryStatusJsonConverter(),
                    new global::G.JsonConverters.AsyncConversationMetadataDeliveryStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AuthorizationMethodJsonConverter(),
                    new global::G.JsonConverters.AuthorizationMethodNullableJsonConverter(),
                    new global::G.JsonConverters.BatchCallRecipientStatusJsonConverter(),
                    new global::G.JsonConverters.BatchCallRecipientStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchCallStatusJsonConverter(),
                    new global::G.JsonConverters.BatchCallStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BillingPeriodJsonConverter(),
                    new global::G.JsonConverters.BillingPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdJsonConverter(),
                    new global::G.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter(),
                    new global::G.JsonConverters.BodyComposeMusicV1MusicPostModelIdJsonConverter(),
                    new global::G.JsonConverters.BodyComposeMusicV1MusicPostModelIdNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2JsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2JsonConverter(),
                    new global::G.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter(),
                    new global::G.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateCompositionPlanV1MusicPlanPostModelIdNullableJsonConverter(),
                    new global::G.JsonConverters.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionJsonConverter(),
                    new global::G.JsonConverters.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter(),
                    new global::G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdNullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter(),
                    new global::G.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter(),
                    new global::G.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter(),
                    new global::G.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdJsonConverter(),
                    new global::G.JsonConverters.BodyStreamComposedMusicV1MusicStreamPostModelIdNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BranchProtectionStatusJsonConverter(),
                    new global::G.JsonConverters.BranchProtectionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BreakdownTypesJsonConverter(),
                    new global::G.JsonConverters.BreakdownTypesNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleHorizontalPlacementModelAlignNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleModelTextAlign2JsonConverter(),
                    new global::G.JsonConverters.CaptionStyleModelTextAlign2NullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleModelTextStyle2JsonConverter(),
                    new global::G.JsonConverters.CaptionStyleModelTextStyle2NullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleModelTextWeight2JsonConverter(),
                    new global::G.JsonConverters.CaptionStyleModelTextWeight2NullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleSectionAnimationModelExitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleVerticalPlacementModelAlignNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleWordAnimationModelEnterTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter(),
                    new global::G.JsonConverters.CaptionStyleWordAnimationModelExitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter(),
                    new global::G.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter(),
                    new global::G.JsonConverters.ChapterResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ChapterResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterWithContentResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.CharacterRefreshPeriodJsonConverter(),
                    new global::G.JsonConverters.CharacterRefreshPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.ChatSourceMediumJsonConverter(),
                    new global::G.JsonConverters.ChatSourceMediumNullableJsonConverter(),
                    new global::G.JsonConverters.ClientEventJsonConverter(),
                    new global::G.JsonConverters.ClientEventNullableJsonConverter(),
                    new global::G.JsonConverters.ClipAnimationEnterEffectJsonConverter(),
                    new global::G.JsonConverters.ClipAnimationEnterEffectNullableJsonConverter(),
                    new global::G.JsonConverters.ClipAnimationExitEffectJsonConverter(),
                    new global::G.JsonConverters.ClipAnimationExitEffectNullableJsonConverter(),
                    new global::G.JsonConverters.ConfigEntityTypeJsonConverter(),
                    new global::G.JsonConverters.ConfigEntityTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationFeedbackTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationFeedbackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistorySIPTrunkingPhoneCallModelDirectionJsonConverter(),
                    new global::G.JsonConverters.ConversationHistorySIPTrunkingPhoneCallModelDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2JsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptOtherToolsResultCommonModelType2NullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptResponseModelRoleJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptResponseModelRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationInitiationSourceJsonConverter(),
                    new global::G.JsonConverters.ConversationInitiationSourceNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelDirection2JsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelDirection2NullableJsonConverter(),
                    new global::G.JsonConverters.ConversationTokenPurposeJsonConverter(),
                    new global::G.JsonConverters.ConversationTokenPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.CustomLLMAPITypeJsonConverter(),
                    new global::G.JsonConverters.CustomLLMAPITypeNullableJsonConverter(),
                    new global::G.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelJsonConverter(),
                    new global::G.JsonConverters.DefaultSharingGroupResponseModelPermissionLevelNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelDisplayMode2JsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelDisplayMode2NullableJsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelGenreVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelTargetAudience2JsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelTargetAudience2NullableJsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelPayoutType2JsonConverter(),
                    new global::G.JsonConverters.DirectPublishingReadResponseModelPayoutType2NullableJsonConverter(),
                    new global::G.JsonConverters.DocumentUsageModeEnumJsonConverter(),
                    new global::G.JsonConverters.DocumentUsageModeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.DubbingModelJsonConverter(),
                    new global::G.JsonConverters.DubbingModelNullableJsonConverter(),
                    new global::G.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter(),
                    new global::G.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedVariantJsonConverter(),
                    new global::G.JsonConverters.EmbedVariantNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEnumJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEnumNullableJsonConverter(),
                    new global::G.JsonConverters.EvaluationSuccessResultJsonConverter(),
                    new global::G.JsonConverters.EvaluationSuccessResultNullableJsonConverter(),
                    new global::G.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter(),
                    new global::G.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCurrency2JsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCurrency2NullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningResponseModelState2JsonConverter(),
                    new global::G.JsonConverters.FineTuningResponseModelState2NullableJsonConverter(),
                    new global::G.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderJsonConverter(),
                    new global::G.JsonConverters.GetAgentResponseModelPhoneNumberDiscriminatorProviderNullableJsonConverter(),
                    new global::G.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetConvAIDashboardSettingsResponseModelChartDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetConversationResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2JsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::G.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GuardrailExecutionModeJsonConverter(),
                    new global::G.JsonConverters.GuardrailExecutionModeNullableJsonConverter(),
                    new global::G.JsonConverters.IntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.IntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InvoiceResponseModelPaymentIntentStatus2JsonConverter(),
                    new global::G.JsonConverters.InvoiceResponseModelPaymentIntentStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.InvoiceResponseModelPaymentIntentStatusseJsonConverter(),
                    new global::G.JsonConverters.InvoiceResponseModelPaymentIntentStatusseNullableJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseDependentTypeJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseDependentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseSortByJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseSortByNullableJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LlmJsonConverter(),
                    new global::G.JsonConverters.LlmNullableJsonConverter(),
                    new global::G.JsonConverters.LLMReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.LLMReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter(),
                    new global::G.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter(),
                    new global::G.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LivekitStackTypeJsonConverter(),
                    new global::G.JsonConverters.LivekitStackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MCPApprovalPolicyJsonConverter(),
                    new global::G.JsonConverters.MCPApprovalPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MCPServerTransportJsonConverter(),
                    new global::G.JsonConverters.MCPServerTransportNullableJsonConverter(),
                    new global::G.JsonConverters.MCPToolApprovalPolicyJsonConverter(),
                    new global::G.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOverrideInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOverrideInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter(),
                    new global::G.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceNullableJsonConverter(),
                    new global::G.JsonConverters.MergingStrategyJsonConverter(),
                    new global::G.JsonConverters.MergingStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.MetricTypeJsonConverter(),
                    new global::G.JsonConverters.MetricTypeNullableJsonConverter(),
                    new global::G.JsonConverters.NonStreamingOutputFormatsJsonConverter(),
                    new global::G.JsonConverters.NonStreamingOutputFormatsNullableJsonConverter(),
                    new global::G.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PendingClipTaskTypeJsonConverter(),
                    new global::G.JsonConverters.PendingClipTaskTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter(),
                    new global::G.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierNullableJsonConverter(),
                    new global::G.JsonConverters.PermissionTypeJsonConverter(),
                    new global::G.JsonConverters.PermissionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PhoneNumberTransferCustomSipHeaderDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PhoneNumberTransferTransferDestinationVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PhoneNumberTransferTransferDestinationVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelTargetAudience2JsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelTargetAudience2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelFiction2JsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelFiction2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelSourceType2JsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelSourceType2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelAspectRatio2JsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelAspectRatio2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAccessLevelJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelFiction2JsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelSourceType2JsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAspectRatio2JsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAspectRatio2NullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelInputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::G.JsonConverters.RAGIndexStatusJsonConverter(),
                    new global::G.JsonConverters.RAGIndexStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter(),
                    new global::G.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ReferencedToolCommonModelTypeJsonConverter(),
                    new global::G.JsonConverters.ReferencedToolCommonModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RenderStatusJsonConverter(),
                    new global::G.JsonConverters.RenderStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RenderType2JsonConverter(),
                    new global::G.JsonConverters.RenderType2NullableJsonConverter(),
                    new global::G.JsonConverters.ResourceAccessInfoRoleJsonConverter(),
                    new global::G.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2JsonConverter(),
                    new global::G.JsonConverters.ResourceMetadataResponseModelAnonymousAccessLevelOverride2NullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFilterModeJsonConverter(),
                    new global::G.JsonConverters.ResponseFilterModeNullableJsonConverter(),
                    new global::G.JsonConverters.ReviewResponseModelReviewStatusJsonConverter(),
                    new global::G.JsonConverters.ReviewResponseModelReviewStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ReviewResponseModelRejectReasonsVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.SIPMediaEncryptionEnumJsonConverter(),
                    new global::G.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter(),
                    new global::G.JsonConverters.SIPTrunkTransportEnumJsonConverter(),
                    new global::G.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter(),
                    new global::G.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeJsonConverter(),
                    new global::G.JsonConverters.SMBToolConfigParamsDiscriminatorSmbToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SafetyRuleJsonConverter(),
                    new global::G.JsonConverters.SafetyRuleNullableJsonConverter(),
                    new global::G.JsonConverters.SampleConfigDBModelParentType2JsonConverter(),
                    new global::G.JsonConverters.SampleConfigDBModelParentType2NullableJsonConverter(),
                    new global::G.JsonConverters.SeatTypeJsonConverter(),
                    new global::G.JsonConverters.SeatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SecretDependencyTypeJsonConverter(),
                    new global::G.JsonConverters.SecretDependencyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ShareOptionResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SingleUseTokenTypeJsonConverter(),
                    new global::G.JsonConverters.SingleUseTokenTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SortDirectionJsonConverter(),
                    new global::G.JsonConverters.SortDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SpellingPatienceJsonConverter(),
                    new global::G.JsonConverters.SpellingPatienceNullableJsonConverter(),
                    new global::G.JsonConverters.StudioClipReferenceClipTypeJsonConverter(),
                    new global::G.JsonConverters.StudioClipReferenceClipTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCurrency2JsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCurrency2NullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionStatusTypeJsonConverter(),
                    new global::G.JsonConverters.SubscriptionStatusTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TTSConversationalModelJsonConverter(),
                    new global::G.JsonConverters.TTSConversationalModelNullableJsonConverter(),
                    new global::G.JsonConverters.TTSModelFamilyJsonConverter(),
                    new global::G.JsonConverters.TTSModelFamilyNullableJsonConverter(),
                    new global::G.JsonConverters.TTSOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TTSOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TelephonyProviderJsonConverter(),
                    new global::G.JsonConverters.TelephonyProviderNullableJsonConverter(),
                    new global::G.JsonConverters.TestRunMetadataTestTypeJsonConverter(),
                    new global::G.JsonConverters.TestRunMetadataTestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TestRunStatusJsonConverter(),
                    new global::G.JsonConverters.TestRunStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TestTypeJsonConverter(),
                    new global::G.JsonConverters.TestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TextNormalisationTypeJsonConverter(),
                    new global::G.JsonConverters.TextNormalisationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallSoundBehaviorJsonConverter(),
                    new global::G.JsonConverters.ToolCallSoundBehaviorNullableJsonConverter(),
                    new global::G.JsonConverters.ToolCallSoundTypeJsonConverter(),
                    new global::G.JsonConverters.ToolCallSoundTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolErrorHandlingModeJsonConverter(),
                    new global::G.JsonConverters.ToolErrorHandlingModeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolExecutionModeJsonConverter(),
                    new global::G.JsonConverters.ToolExecutionModeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ToolRequestModelToolConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ToolResponseModelToolConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolSortByJsonConverter(),
                    new global::G.JsonConverters.ToolSortByNullableJsonConverter(),
                    new global::G.JsonConverters.ToolTypeJsonConverter(),
                    new global::G.JsonConverters.ToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolTypeFilterJsonConverter(),
                    new global::G.JsonConverters.ToolTypeFilterNullableJsonConverter(),
                    new global::G.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter(),
                    new global::G.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonNullableJsonConverter(),
                    new global::G.JsonConverters.TransferTypeEnumJsonConverter(),
                    new global::G.JsonConverters.TransferTypeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.TurnEagernessJsonConverter(),
                    new global::G.JsonConverters.TurnEagernessNullableJsonConverter(),
                    new global::G.JsonConverters.TurnModeJsonConverter(),
                    new global::G.JsonConverters.TurnModeNullableJsonConverter(),
                    new global::G.JsonConverters.TurnModelJsonConverter(),
                    new global::G.JsonConverters.TurnModelNullableJsonConverter(),
                    new global::G.JsonConverters.TwilioEdgeLocationJsonConverter(),
                    new global::G.JsonConverters.TwilioEdgeLocationNullableJsonConverter(),
                    new global::G.JsonConverters.TwilioRegionIdJsonConverter(),
                    new global::G.JsonConverters.TwilioRegionIdNullableJsonConverter(),
                    new global::G.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UnitTestToolCallParameterEvalDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UsageAggregationIntervalJsonConverter(),
                    new global::G.JsonConverters.UsageAggregationIntervalNullableJsonConverter(),
                    new global::G.JsonConverters.UserFeedbackScoreJsonConverter(),
                    new global::G.JsonConverters.UserFeedbackScoreNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceCategoryJsonConverter(),
                    new global::G.JsonConverters.VoiceCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceDesignRequestModelModelIdJsonConverter(),
                    new global::G.JsonConverters.VoiceDesignRequestModelModelIdNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelCategoryJsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookAuthMethodTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookEventTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookUsageTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookUsageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter(),
                    new global::G.JsonConverters.WhatsAppConversationInfoDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2JsonConverter(),
                    new global::G.JsonConverters.WidgetConfigInputSyntaxHighlightTheme2NullableJsonConverter(),
                    new global::G.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2JsonConverter(),
                    new global::G.JsonConverters.WidgetConfigOutputSyntaxHighlightTheme2NullableJsonConverter(),
                    new global::G.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2JsonConverter(),
                    new global::G.JsonConverters.WidgetConfigResponseModelSyntaxHighlightTheme2NullableJsonConverter(),
                    new global::G.JsonConverters.WidgetEndFeedbackTypeJsonConverter(),
                    new global::G.JsonConverters.WidgetEndFeedbackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetExpandableJsonConverter(),
                    new global::G.JsonConverters.WidgetExpandableNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetFeedbackModeJsonConverter(),
                    new global::G.JsonConverters.WidgetFeedbackModeNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetPlacementJsonConverter(),
                    new global::G.JsonConverters.WidgetPlacementNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelInputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowEdgeModelOutputBackwardConditionVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowExpressionConditionModelInputExpressionDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowExpressionConditionModelInputExpressionDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowExpressionConditionModelOutputExpressionDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowExpressionConditionModelOutputExpressionDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputTransferDestinationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowToolResponseModelInputStepDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.WorkflowToolResponseModelOutputStepDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WorkspaceGroupPermissionJsonConverter(),
                    new global::G.JsonConverters.WorkspaceGroupPermissionNullableJsonConverter(),
                    new global::G.JsonConverters.WorkspaceResourceTypeJsonConverter(),
                    new global::G.JsonConverters.WorkspaceResourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetSpeechHistorySortDirection2JsonConverter(),
                    new global::G.JsonConverters.GetSpeechHistorySortDirection2NullableJsonConverter(),
                    new global::G.JsonConverters.GetSpeechHistorySource2JsonConverter(),
                    new global::G.JsonConverters.GetSpeechHistorySource2NullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechFullOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ListDubsDubbingStatusJsonConverter(),
                    new global::G.JsonConverters.ListDubsDubbingStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ListDubsFilterByCreatorJsonConverter(),
                    new global::G.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter(),
                    new global::G.JsonConverters.ListDubsOrderDirectionJsonConverter(),
                    new global::G.JsonConverters.ListDubsOrderDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter(),
                    new global::G.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter(),
                    new global::G.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionariesMetadataSort2JsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionariesMetadataSort2NullableJsonConverter(),
                    new global::G.JsonConverters.ListChatResponseTestsRouteSortModeJsonConverter(),
                    new global::G.JsonConverters.ListChatResponseTestsRouteSortModeNullableJsonConverter(),
                    new global::G.JsonConverters.GetConversationHistoriesRouteSummaryModeJsonConverter(),
                    new global::G.JsonConverters.GetConversationHistoriesRouteSummaryModeNullableJsonConverter(),
                    new global::G.JsonConverters.TextSearchConversationMessagesRouteSummaryModeJsonConverter(),
                    new global::G.JsonConverters.TextSearchConversationMessagesRouteSummaryModeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusJsonConverter(),
                    new global::G.JsonConverters.GetAgentSummariesRouteResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderJsonConverter(),
                    new global::G.JsonConverters.ListPhoneNumbersRouteResponseItemDiscriminatorProviderNullableJsonConverter(),
                    new global::G.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderJsonConverter(),
                    new global::G.JsonConverters.GetPhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter(),
                    new global::G.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderJsonConverter(),
                    new global::G.JsonConverters.UpdatePhoneNumberRouteResponseDiscriminatorProviderNullableJsonConverter(),
                    new global::G.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusJsonConverter(),
                    new global::G.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateDocumentRouteResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusJsonConverter(),
                    new global::G.JsonConverters.GetOrCreateRagIndexesResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ChildrenItemJsonConverter(),
                    new global::G.JsonConverters.ChildrenItem2JsonConverter(),
                    new global::G.JsonConverters.LeftJsonConverter(),
                    new global::G.JsonConverters.RightJsonConverter(),
                    new global::G.JsonConverters.Left2JsonConverter(),
                    new global::G.JsonConverters.Right2JsonConverter(),
                    new global::G.JsonConverters.Left3JsonConverter(),
                    new global::G.JsonConverters.Right3JsonConverter(),
                    new global::G.JsonConverters.Left4JsonConverter(),
                    new global::G.JsonConverters.Right4JsonConverter(),
                    new global::G.JsonConverters.Left5JsonConverter(),
                    new global::G.JsonConverters.Right5JsonConverter(),
                    new global::G.JsonConverters.Left6JsonConverter(),
                    new global::G.JsonConverters.Right6JsonConverter(),
                    new global::G.JsonConverters.Left7JsonConverter(),
                    new global::G.JsonConverters.Right7JsonConverter(),
                    new global::G.JsonConverters.Left8JsonConverter(),
                    new global::G.JsonConverters.Right8JsonConverter(),
                    new global::G.JsonConverters.Left9JsonConverter(),
                    new global::G.JsonConverters.Right9JsonConverter(),
                    new global::G.JsonConverters.Left10JsonConverter(),
                    new global::G.JsonConverters.Right10JsonConverter(),
                    new global::G.JsonConverters.Left11JsonConverter(),
                    new global::G.JsonConverters.Right11JsonConverter(),
                    new global::G.JsonConverters.Left12JsonConverter(),
                    new global::G.JsonConverters.Right12JsonConverter(),
                    new global::G.JsonConverters.ChildrenItem3JsonConverter(),
                    new global::G.JsonConverters.ChildrenItem4JsonConverter(),
                    new global::G.JsonConverters.NodesJsonConverter(),
                    new global::G.JsonConverters.Nodes2JsonConverter(),
                    new global::G.JsonConverters.SchemaOverridesVariant1JsonConverter(),
                    new global::G.JsonConverters.SchemaOverridesVariant12JsonConverter(),
                    new global::G.JsonConverters.TemplateParamsItemJsonConverter(),
                    new global::G.JsonConverters.ToolsItemJsonConverter(),
                    new global::G.JsonConverters.AgentsItemJsonConverter(),
                    new global::G.JsonConverters.PhoneCallVariant1JsonConverter(),
                    new global::G.JsonConverters.ResultVariant1JsonConverter(),
                    new global::G.JsonConverters.ResultVariant12JsonConverter(),
                    new global::G.JsonConverters.ToolDetailsVariant1JsonConverter(),
                    new global::G.JsonConverters.ToolDetailsVariant12JsonConverter(),
                    new global::G.JsonConverters.ExportOptionsJsonConverter(),
                    new global::G.JsonConverters.PhoneNumbersItemJsonConverter(),
                    new global::G.JsonConverters.ChartsItemJsonConverter(),
                    new global::G.JsonConverters.AgentsItem2JsonConverter(),
                    new global::G.JsonConverters.DocumentsItemJsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItemJsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem2JsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem3JsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem4JsonConverter(),
                    new global::G.JsonConverters.AgentsItem3JsonConverter(),
                    new global::G.JsonConverters.DataJsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem5JsonConverter(),
                    new global::G.JsonConverters.InputOverridesVariant1JsonConverter(),
                    new global::G.JsonConverters.InputOverridesVariant12JsonConverter(),
                    new global::G.JsonConverters.InputOverridesVariant13JsonConverter(),
                    new global::G.JsonConverters.InputOverridesVariant14JsonConverter(),
                    new global::G.JsonConverters.InputOverridesVariant15JsonConverter(),
                    new global::G.JsonConverters.ChartsItem2JsonConverter(),
                    new global::G.JsonConverters.CustomSipHeadersItemJsonConverter(),
                    new global::G.JsonConverters.TransferDestinationVariant1JsonConverter(),
                    new global::G.JsonConverters.PostDialDigitsVariant1JsonConverter(),
                    new global::G.JsonConverters.SourceContextVariant1JsonConverter(),
                    new global::G.JsonConverters.BackupLlmConfigJsonConverter(),
                    new global::G.JsonConverters.ToolsItem2JsonConverter(),
                    new global::G.JsonConverters.BackupLlmConfig2JsonConverter(),
                    new global::G.JsonConverters.ToolsItem3JsonConverter(),
                    new global::G.JsonConverters.ToolsVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ToolsVariant1Item2JsonConverter(),
                    new global::G.JsonConverters.ParamsJsonConverter(),
                    new global::G.JsonConverters.Params2JsonConverter(),
                    new global::G.JsonConverters.Params3JsonConverter(),
                    new global::G.JsonConverters.ToolConfigJsonConverter(),
                    new global::G.JsonConverters.ToolConfig2JsonConverter(),
                    new global::G.JsonConverters.BranchInfoVariant1JsonConverter(),
                    new global::G.JsonConverters.TestInfoVariant1JsonConverter(),
                    new global::G.JsonConverters.EvalJsonConverter(),
                    new global::G.JsonConverters.ParametersItemJsonConverter(),
                    new global::G.JsonConverters.ForwardConditionVariant1JsonConverter(),
                    new global::G.JsonConverters.BackwardConditionVariant1JsonConverter(),
                    new global::G.JsonConverters.ForwardConditionVariant12JsonConverter(),
                    new global::G.JsonConverters.BackwardConditionVariant12JsonConverter(),
                    new global::G.JsonConverters.ExpressionJsonConverter(),
                    new global::G.JsonConverters.Expression2JsonConverter(),
                    new global::G.JsonConverters.CustomSipHeadersItem2JsonConverter(),
                    new global::G.JsonConverters.TransferDestinationJsonConverter(),
                    new global::G.JsonConverters.PostDialDigitsVariant12JsonConverter(),
                    new global::G.JsonConverters.CustomSipHeadersItem3JsonConverter(),
                    new global::G.JsonConverters.TransferDestination2JsonConverter(),
                    new global::G.JsonConverters.PostDialDigitsVariant13JsonConverter(),
                    new global::G.JsonConverters.StepsItemJsonConverter(),
                    new global::G.JsonConverters.StepsItem2JsonConverter(),
                    new global::G.JsonConverters.GetAgentSummariesRouteResponse2JsonConverter(),
                    new global::G.JsonConverters.GetAgentResponseTestRouteResponseJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter(),
                    new global::G.JsonConverters.ListPhoneNumbersRouteResponseItemJsonConverter(),
                    new global::G.JsonConverters.GetPhoneNumberRouteResponseJsonConverter(),
                    new global::G.JsonConverters.UpdatePhoneNumberRouteResponseJsonConverter(),
                    new global::G.JsonConverters.GetAgentKnowledgeBaseSummariesRouteResponse2JsonConverter(),
                    new global::G.JsonConverters.UpdateDocumentRouteResponseJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter(),
                    new global::G.JsonConverters.GetOrCreateRagIndexesResponse2JsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastConversationMode, global::G.PodcastBulletinMode>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, object, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.PermissionType>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.PermissionType>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChapterContentBlockTtsNodeResponseModel, global::G.ChapterContentBlockExtendableNodeResponseModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PendingSubscriptionSwitchResponseModel, global::G.PendingCancellationResponseModel, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleResponseModel, global::G.PronunciationDictionaryPhonemeRuleResponseModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LiteralOverride, global::G.ObjectOverrideInput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LiteralOverride, global::G.ObjectOverrideOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ProjectVideoResponseModel, global::G.ProjectExternalAudioResponseModel, global::G.ProjectImageResponseModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.BackupLLMDefault, global::G.BackupLLMDisabled, global::G.BackupLLMOverride, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.BackupLLMDefault, global::G.BackupLLMDisabled, global::G.BackupLLMOverride, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::G.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModel, global::G.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateResponseUnitTestRequest, global::G.CreateToolCallUnitTestRequest, global::G.CreateSimulationTestRequest>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.UpdateResponseUnitTestRequest, global::G.UpdateToolCallUnitTestRequest, global::G.UpdateSimulationTestRequest>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateTwilioPhoneNumberRequest, global::G.CreateSIPTrunkPhoneNumberRequestV2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.NonStreamingOutputFormats?, global::G.AllowedOutputFormats?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.NonStreamingOutputFormats?, global::G.AllowedOutputFormats?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.DubbingTranscriptResponseModel, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SpeechToTextChunkResponseModel, global::G.MultichannelSpeechToTextResponseModel, global::G.SpeechToTextWebhookResponseModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SpeechToTextChunkResponseModel, global::G.MultichannelSpeechToTextResponseModel>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AgentsPlatformClient AgentsPlatform => new AgentsPlatformClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AudioIsolationClient AudioIsolation => new AudioIsolationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AudioNativeClient AudioNative => new AudioNativeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAiClient ConversationalAi => new ConversationalAiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAi2Client ConversationalAi2 => new ConversationalAi2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing => new DubbingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ForcedAlignmentClient ForcedAlignment => new ForcedAlignmentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HistoryClient History => new HistoryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access the different models of the platform.
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MusicClient Music => new MusicClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MusicGenerationClient MusicGeneration => new MusicGenerationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionariesClient PronunciationDictionaries => new PronunciationDictionariesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionaryClient PronunciationDictionary => new PronunciationDictionaryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PvcVoicesClient PvcVoices => new PvcVoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access to your samples. A sample is any audio file you attached to a voice. A voice can have one or more samples.
        /// </summary>
        public SamplesClient Samples => new SamplesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SingleUseTokenClient SingleUseToken => new SingleUseTokenClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpeechToSpeechClient SpeechToSpeech => new SpeechToSpeechClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Transcribe your audio files with detailed speaker annotations and precise timestamps using our cutting-edge model.
        /// </summary>
        public SpeechToTextClient SpeechToText => new SpeechToTextClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpeechToText2Client SpeechToText2 => new SpeechToText2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StudioClient Studio => new StudioClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToDialogueClient TextToDialogue => new TextToDialogueClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToSoundEffectsClient TextToSoundEffects => new TextToSoundEffectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech => new TextToSpeechClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToVoiceClient TextToVoice => new TextToVoiceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TextToVoice2Client TextToVoice2 => new TextToVoice2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage => new UsageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access to voices created either by you or ElevenLabs.
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access to workspace related endpoints.
        /// </summary>
        public WorkspaceClient Workspace => new WorkspaceClient(HttpClient, authorizations: Authorizations)
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