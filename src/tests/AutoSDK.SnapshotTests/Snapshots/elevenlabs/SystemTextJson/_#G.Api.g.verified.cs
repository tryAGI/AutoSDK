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
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ASRQualityJsonConverter(),
                    new global::G.JsonConverters.ASRQualityNullableJsonConverter(),
                    new global::G.JsonConverters.ASRProviderJsonConverter(),
                    new global::G.JsonConverters.ASRProviderNullableJsonConverter(),
                    new global::G.JsonConverters.ASRInputFormatJsonConverter(),
                    new global::G.JsonConverters.ASRInputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterWithContentResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ChapterWithContentResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelTargetAudience2JsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelTargetAudience2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAccessLevelJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelFiction2JsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelFiction2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelSourceType2JsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelSourceType2NullableJsonConverter(),
                    new global::G.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2JsonConverter(),
                    new global::G.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::G.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter(),
                    new global::G.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter(),
                    new global::G.JsonConverters.BanReasonTypeJsonConverter(),
                    new global::G.JsonConverters.BanReasonTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LLMJsonConverter(),
                    new global::G.JsonConverters.LLMNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter(),
                    new global::G.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigInputParamsDiscriminatorSystemToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.IntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.IntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MCPApprovalPolicyJsonConverter(),
                    new global::G.JsonConverters.MCPApprovalPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentInputToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentInputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseDocumentTypeJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseDocumentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentUsageModeEnumJsonConverter(),
                    new global::G.JsonConverters.DocumentUsageModeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEnumJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEnumNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigOutputParamsDiscriminatorSystemToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentOutputToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentOutputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentDBModelToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentDBModelToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedVariantJsonConverter(),
                    new global::G.JsonConverters.EmbedVariantNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetPlacementJsonConverter(),
                    new global::G.JsonConverters.WidgetPlacementNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetExpandableJsonConverter(),
                    new global::G.JsonConverters.WidgetExpandableNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetFeedbackModeJsonConverter(),
                    new global::G.JsonConverters.WidgetFeedbackModeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelOutputRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptToolCallCommonModelToolDetailsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UserFeedbackScoreJsonConverter(),
                    new global::G.JsonConverters.UserFeedbackScoreNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelOutputSourceMedium2JsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelOutputSourceMedium2NullableJsonConverter(),
                    new global::G.JsonConverters.EvaluationSuccessResultJsonConverter(),
                    new global::G.JsonConverters.EvaluationSuccessResultNullableJsonConverter(),
                    new global::G.JsonConverters.ResourceAccessInfoRoleJsonConverter(),
                    new global::G.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AuthorizationMethodJsonConverter(),
                    new global::G.JsonConverters.AuthorizationMethodNullableJsonConverter(),
                    new global::G.JsonConverters.TelephonyProviderJsonConverter(),
                    new global::G.JsonConverters.TelephonyProviderNullableJsonConverter(),
                    new global::G.JsonConverters.BatchCallStatusJsonConverter(),
                    new global::G.JsonConverters.BatchCallStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchCallRecipientStatusJsonConverter(),
                    new global::G.JsonConverters.BatchCallRecipientStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2JsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2JsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostTargetAudience2JsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostTargetAudience2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostFiction2JsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostFiction2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostApplyTextNormalization2JsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostApplyTextNormalization2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostSourceType2JsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostSourceType2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.TurnModeJsonConverter(),
                    new global::G.JsonConverters.TurnModeNullableJsonConverter(),
                    new global::G.JsonConverters.TTSConversationalModelJsonConverter(),
                    new global::G.JsonConverters.TTSConversationalModelNullableJsonConverter(),
                    new global::G.JsonConverters.TTSModelFamilyJsonConverter(),
                    new global::G.JsonConverters.TTSModelFamilyNullableJsonConverter(),
                    new global::G.JsonConverters.TTSOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TTSOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ClientEventJsonConverter(),
                    new global::G.JsonConverters.ClientEventNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFiction2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2JsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceType2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScaleJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScaleNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterContentBlockInputModelSubType2JsonConverter(),
                    new global::G.JsonConverters.ChapterContentBlockInputModelSubType2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderNullableJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeNullableJsonConverter(),
                    new global::G.JsonConverters.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2JsonConverter(),
                    new global::G.JsonConverters.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2NullableJsonConverter(),
                    new global::G.JsonConverters.RenderType2JsonConverter(),
                    new global::G.JsonConverters.RenderType2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter(),
                    new global::G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter(),
                    new global::G.JsonConverters.WorkspaceResourceTypeJsonConverter(),
                    new global::G.JsonConverters.WorkspaceResourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputSourceMedium2JsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelInputSourceMedium2NullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2JsonConverter(),
                    new global::G.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2JsonConverter(),
                    new global::G.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2NullableJsonConverter(),
                    new global::G.JsonConverters.BreakdownTypesJsonConverter(),
                    new global::G.JsonConverters.BreakdownTypesNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ChapterResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentToolIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentToolIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesAgentToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesAgentToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SecretDependencyTypeJsonConverter(),
                    new global::G.JsonConverters.SecretDependencyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistorySIPTrunkingPhoneCallModelDirectionJsonConverter(),
                    new global::G.JsonConverters.ConversationHistorySIPTrunkingPhoneCallModelDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationTokenPurposeJsonConverter(),
                    new global::G.JsonConverters.ConversationTokenPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.SIPTrunkTransportEnumJsonConverter(),
                    new global::G.JsonConverters.SIPTrunkTransportEnumNullableJsonConverter(),
                    new global::G.JsonConverters.SIPMediaEncryptionEnumJsonConverter(),
                    new global::G.JsonConverters.SIPMediaEncryptionEnumNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.RenderStatusJsonConverter(),
                    new global::G.JsonConverters.RenderStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCurrency2JsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCurrency2NullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionStatusTypeJsonConverter(),
                    new global::G.JsonConverters.SubscriptionStatusTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelBillingPeriod2JsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelBillingPeriod2NullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCharacterRefreshPeriod2JsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCharacterRefreshPeriod2NullableJsonConverter(),
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
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter(),
                    new global::G.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2JsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2JsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategory2NullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelSource2JsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelSource2NullableJsonConverter(),
                    new global::G.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelCategoryJsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter(),
                    new global::G.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter(),
                    new global::G.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelSafetyControl2JsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelSafetyControl2NullableJsonConverter(),
                    new global::G.JsonConverters.MCPToolApprovalPolicyJsonConverter(),
                    new global::G.JsonConverters.MCPToolApprovalPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.MCPServerTransportJsonConverter(),
                    new global::G.JsonConverters.MCPServerTransportNullableJsonConverter(),
                    new global::G.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MCPServerResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MetricTypeJsonConverter(),
                    new global::G.JsonConverters.MetricTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelResponseModelConcurrencyGroupJsonConverter(),
                    new global::G.JsonConverters.ModelResponseModelConcurrencyGroupNullableJsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelSafetyStatus2JsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelSafetyStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelWarningStatus2JsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelWarningStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeNullableJsonConverter(),
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
                    new global::G.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2JsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryVersionResponseModelPermissionOnResource2NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.RAGIndexStatusJsonConverter(),
                    new global::G.JsonConverters.RAGIndexStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ShareOptionResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SafetyRuleJsonConverter(),
                    new global::G.JsonConverters.SafetyRuleNullableJsonConverter(),
                    new global::G.JsonConverters.SimilarVoiceCategoryJsonConverter(),
                    new global::G.JsonConverters.SimilarVoiceCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCurrency2JsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCurrency2NullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelBillingPeriod2JsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelBillingPeriod2NullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriod2JsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriod2NullableJsonConverter(),
                    new global::G.JsonConverters.UsageAggregationIntervalJsonConverter(),
                    new global::G.JsonConverters.UsageAggregationIntervalNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookAuthMethodTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookAuthMethodTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookUsageTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookUsageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListGeneratedItemsV1HistoryGetSource2JsonConverter(),
                    new global::G.JsonConverters.ListGeneratedItemsV1HistoryGetSource2NullableJsonConverter(),
                    new global::G.JsonConverters.SoundGenerationV1SoundGenerationPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.SoundGenerationV1SoundGenerationPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechV1TextToSpeechVoiceIdPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechV1TextToSpeechVoiceIdPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToDialogueMultiVoiceV1TextToDialoguePostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToDialogueMultiVoiceV1TextToDialoguePostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeJsonConverter(),
                    new global::G.JsonConverters.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionariesV1PronunciationDictionariesGetSort2JsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionariesV1PronunciationDictionariesGetSort2NullableJsonConverter(),
                    new global::G.JsonConverters.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProviderJsonConverter(),
                    new global::G.JsonConverters.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProviderNullableJsonConverter(),
                    new global::G.JsonConverters.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProviderJsonConverter(),
                    new global::G.JsonConverters.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProviderNullableJsonConverter(),
                    new global::G.JsonConverters.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProviderJsonConverter(),
                    new global::G.JsonConverters.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProviderNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExportOptionsJsonConverter(),
                    new global::G.JsonConverters.ToolsItem2JsonConverter(),
                    new global::G.JsonConverters.ParamsJsonConverter(),
                    new global::G.JsonConverters.ToolsItem3JsonConverter(),
                    new global::G.JsonConverters.Params2JsonConverter(),
                    new global::G.JsonConverters.ToolsItem4JsonConverter(),
                    new global::G.JsonConverters.ToolDetailsVariant1JsonConverter(),
                    new global::G.JsonConverters.ToolsItemJsonConverter(),
                    new global::G.JsonConverters.AgentToolsItemJsonConverter(),
                    new global::G.JsonConverters.PhoneCallVariant1JsonConverter(),
                    new global::G.JsonConverters.PhoneNumbersItemJsonConverter(),
                    new global::G.JsonConverters.ChartsItemJsonConverter(),
                    new global::G.JsonConverters.AgentsItemJsonConverter(),
                    new global::G.JsonConverters.DocumentsItemJsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem3JsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItemJsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem2JsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem4JsonConverter(),
                    new global::G.JsonConverters.ChartsItem2JsonConverter(),
                    new global::G.JsonConverters.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseJsonConverter(),
                    new global::G.JsonConverters.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseJsonConverter(),
                    new global::G.JsonConverters.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemJsonConverter(),
                    new global::G.JsonConverters.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChapterContentBlockTtsNodeResponseModel, global::G.ChapterContentBlockExtendableNodeResponseModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator, global::G.ConvAIDynamicVariable>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastConversationMode, global::G.PodcastBulletinMode>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastConversationMode, global::G.PodcastBulletinMode>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateTwilioPhoneNumberRequest, global::G.CreateSIPTrunkPhoneNumberRequest>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// Convert text into lifelike speech using a voice of your choice.
        /// </summary>
        public TextToSpeechClient TextToSpeech => new TextToSpeechClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create speech by combining the style and content of an audio file you upload with a voice of your choice.
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
        /// Force align an audio file to a text transcript to get precise word-level and character level timing information. Response is a list of characters with their start and end times as milliseconds elapsed from the start of the recording.
        /// </summary>
        public ForcedAlignmentClient ForcedAlignment => new ForcedAlignmentClient(HttpClient, authorizations: Authorizations)
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
        /// Access to voices created either by you or ElevenLabs.
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations)
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
        /// Accesses your speech history. Your speech history is a list of all your created audio including its metadata using our text-to-speech and speech-to-speech models.
        /// </summary>
        public SpeechHistoryClient SpeechHistory => new SpeechHistoryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Access, create and convert Studio Projects programmatically, only specifically whitelisted accounts can access the Projects API. If you need access please contact our sales team.
        /// </summary>
        public StudiosClient Studios => new StudiosClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SoundGenerationClient SoundGeneration => new SoundGenerationClient(HttpClient, authorizations: Authorizations)
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
        public TextToDialogueClient TextToDialogue => new TextToDialogueClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoiceGenerationClient VoiceGeneration => new VoiceGenerationClient(HttpClient, authorizations: Authorizations)
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
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
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
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
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
        public ResourceClient Resource => new ResourceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SegmentClient Segment => new SegmentClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnterpriseClient Enterprise => new EnterpriseClient(HttpClient, authorizations: Authorizations)
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
        public UsageClient Usage => new UsageClient(HttpClient, authorizations: Authorizations)
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
        public WorkspaceClient Workspace => new WorkspaceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAIClient ConversationalAI => new ConversationalAIClient(HttpClient, authorizations: Authorizations)
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