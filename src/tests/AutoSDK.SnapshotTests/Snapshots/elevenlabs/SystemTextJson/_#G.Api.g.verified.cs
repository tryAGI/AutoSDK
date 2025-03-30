//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the documentation for the ElevenLabs API. You can use this API to use our service programmatically, this is done by using your xi-api-key. &lt;br/&gt; You can view your xi-api-key using the 'Profile' tab on https://elevenlabs.io. Our API is experimental so all endpoints are subject to change.<br/>
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
                    new global::G.JsonConverters.ChapterContentBlockTtsNodeResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ChapterContentBlockTtsNodeResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterContentBlockExtendableNodeResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ChapterContentBlockExtendableNodeResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelTargetAudienceJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelTargetAudienceNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAccessLevelJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelFictionJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelFictionNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectCreationMetaResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelSourceTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectResponseModelSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BanReasonTypeJsonConverter(),
                    new global::G.JsonConverters.BanReasonTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LLMJsonConverter(),
                    new global::G.JsonConverters.LLMNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolConfigInputTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookToolConfigInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputMethodJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigInputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.LiteralJsonSchemaPropertyTypeJsonConverter(),
                    new global::G.JsonConverters.LiteralJsonSchemaPropertyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectJsonSchemaPropertyInputTypeJsonConverter(),
                    new global::G.JsonConverters.ObjectJsonSchemaPropertyInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ArrayJsonSchemaPropertyInputTypeJsonConverter(),
                    new global::G.JsonConverters.ArrayJsonSchemaPropertyInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClientToolConfigInputTypeJsonConverter(),
                    new global::G.JsonConverters.ClientToolConfigInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigTypeJsonConverter(),
                    new global::G.JsonConverters.SystemToolConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentInputToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentInputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseLocatorTypeJsonConverter(),
                    new global::G.JsonConverters.KnowledgeBaseLocatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentUsageModeEnumJsonConverter(),
                    new global::G.JsonConverters.DocumentUsageModeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEnumJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEnumNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolConfigOutputTypeJsonConverter(),
                    new global::G.JsonConverters.WebhookToolConfigOutputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputMethodJsonConverter(),
                    new global::G.JsonConverters.WebhookToolApiSchemaConfigOutputMethodNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectJsonSchemaPropertyOutputTypeJsonConverter(),
                    new global::G.JsonConverters.ObjectJsonSchemaPropertyOutputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ArrayJsonSchemaPropertyOutputTypeJsonConverter(),
                    new global::G.JsonConverters.ArrayJsonSchemaPropertyOutputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClientToolConfigOutputTypeJsonConverter(),
                    new global::G.JsonConverters.ClientToolConfigOutputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptAgentOutputToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PromptAgentOutputToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptEvaluationCriteriaTypeJsonConverter(),
                    new global::G.JsonConverters.PromptEvaluationCriteriaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedVariantJsonConverter(),
                    new global::G.JsonConverters.EmbedVariantNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetExpandableJsonConverter(),
                    new global::G.JsonConverters.WidgetExpandableNullableJsonConverter(),
                    new global::G.JsonConverters.OrbAvatarTypeJsonConverter(),
                    new global::G.JsonConverters.OrbAvatarTypeNullableJsonConverter(),
                    new global::G.JsonConverters.URLAvatarTypeJsonConverter(),
                    new global::G.JsonConverters.URLAvatarTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageAvatarTypeJsonConverter(),
                    new global::G.JsonConverters.ImageAvatarTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WidgetFeedbackModeJsonConverter(),
                    new global::G.JsonConverters.WidgetFeedbackModeNullableJsonConverter(),
                    new global::G.JsonConverters.ResourceAccessInfoRoleJsonConverter(),
                    new global::G.JsonConverters.ResourceAccessInfoRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AuthorizationMethodJsonConverter(),
                    new global::G.JsonConverters.AuthorizationMethodNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryAliasRuleRequestModelTypeJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryAliasRuleRequestModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryPhonemeRuleRequestModelTypeJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictionaryPhonemeRuleRequestModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessJsonConverter(),
                    new global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostTargetAudienceJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostTargetAudienceNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostFictionJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostFictionNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostSourceTypeJsonConverter(),
                    new global::G.JsonConverters.BodyAddProjectV1ProjectsAddPostSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TurnModeJsonConverter(),
                    new global::G.JsonConverters.TurnModeNullableJsonConverter(),
                    new global::G.JsonConverters.TTSConversationalModelJsonConverter(),
                    new global::G.JsonConverters.TTSConversationalModelNullableJsonConverter(),
                    new global::G.JsonConverters.TTSOutputFormatJsonConverter(),
                    new global::G.JsonConverters.TTSOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ClientEventJsonConverter(),
                    new global::G.JsonConverters.ClientEventNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudienceJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostTargetAudienceNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFictionJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFictionNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceTypeJsonConverter(),
                    new global::G.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PodcastConversationModeTypeJsonConverter(),
                    new global::G.JsonConverters.PodcastConversationModeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PodcastBulletinModeTypeJsonConverter(),
                    new global::G.JsonConverters.PodcastBulletinModeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PodcastTextSourceTypeJsonConverter(),
                    new global::G.JsonConverters.PodcastTextSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PodcastURLSourceTypeJsonConverter(),
                    new global::G.JsonConverters.PodcastURLSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScaleJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScaleNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleJsonConverter(),
                    new global::G.JsonConverters.BodyCreatePodcastV1StudioPodcastsPostDurationScaleNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterContentParagraphTtsNodeInputModelTypeJsonConverter(),
                    new global::G.JsonConverters.ChapterContentParagraphTtsNodeInputModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderNullableJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeJsonConverter(),
                    new global::G.JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAgeNullableJsonConverter(),
                    new global::G.JsonConverters.UserFeedbackScoreJsonConverter(),
                    new global::G.JsonConverters.UserFeedbackScoreNullableJsonConverter(),
                    new global::G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter(),
                    new global::G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleNullableJsonConverter(),
                    new global::G.JsonConverters.WorkspaceResourceTypeJsonConverter(),
                    new global::G.JsonConverters.WorkspaceResourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter(),
                    new global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechV1TextToSpeechVoiceIdPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleJsonConverter(),
                    new global::G.JsonConverters.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleNullableJsonConverter(),
                    new global::G.JsonConverters.BreakdownTypesJsonConverter(),
                    new global::G.JsonConverters.BreakdownTypesNullableJsonConverter(),
                    new global::G.JsonConverters.ChapterResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ChapterResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierTypeJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableToolIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.DependentUnknownToolIdentifierTypeJsonConverter(),
                    new global::G.JsonConverters.DependentUnknownToolIdentifierTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentToolIdentifierTypeJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentToolIdentifierTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentToolIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentToolIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.DependentUnknownAgentToolIdentifierTypeJsonConverter(),
                    new global::G.JsonConverters.DependentUnknownAgentToolIdentifierTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesAgentToolDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConvAIStoredSecretDependenciesAgentToolDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SecretDependencyTypeJsonConverter(),
                    new global::G.JsonConverters.SecretDependencyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TelephonyProviderJsonConverter(),
                    new global::G.JsonConverters.TelephonyProviderNullableJsonConverter(),
                    new global::G.JsonConverters.ConvAIWorkspaceStoredSecretConfigTypeJsonConverter(),
                    new global::G.JsonConverters.ConvAIWorkspaceStoredSecretConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EvaluationSuccessResultJsonConverter(),
                    new global::G.JsonConverters.EvaluationSuccessResultNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTwilioPhoneCallModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelRoleJsonConverter(),
                    new global::G.JsonConverters.ConversationHistoryTranscriptCommonModelRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.ConversationSummaryResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationTokenPurposeJsonConverter(),
                    new global::G.JsonConverters.ConversationTokenPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierTypeJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter(),
                    new global::G.JsonConverters.DependentAvailableAgentIdentifierAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.DependentUnknownAgentIdentifierTypeJsonConverter(),
                    new global::G.JsonConverters.DependentUnknownAgentIdentifierTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCurrencyJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCurrencyNullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelBillingPeriodJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelBillingPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCharacterRefreshPeriodJsonConverter(),
                    new global::G.JsonConverters.ExtendedSubscriptionResponseModelCharacterRefreshPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuningResponseModelState2JsonConverter(),
                    new global::G.JsonConverters.FineTuningResponseModelState2NullableJsonConverter(),
                    new global::G.JsonConverters.GetConversationResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.GetConversationResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseFileResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseFileResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryURLResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseSummaryFileResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseListResponseModelDocumentDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseURLResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.GetKnowledgeBaseURLResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter(),
                    new global::G.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelSourceJsonConverter(),
                    new global::G.JsonConverters.SpeechHistoryItemResponseModelSourceNullableJsonConverter(),
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
                    new global::G.JsonConverters.VoiceResponseModelSafetyControlJsonConverter(),
                    new global::G.JsonConverters.VoiceResponseModelSafetyControlNullableJsonConverter(),
                    new global::G.JsonConverters.ModelResponseModelConcurrencyGroupJsonConverter(),
                    new global::G.JsonConverters.ModelResponseModelConcurrencyGroupNullableJsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelSafetyStatusJsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelSafetyStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelWarningStatusJsonConverter(),
                    new global::G.JsonConverters.ModerationStatusResponseModelWarningStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PostWorkspaceSecretRequestTypeJsonConverter(),
                    new global::G.JsonConverters.PostWorkspaceSecretRequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PostWorkspaceSecretResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.PostWorkspaceSecretResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelTargetAudienceJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelTargetAudienceNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelStateJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelStateNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelAccessLevelJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelAccessLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelFictionJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelFictionNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelSourceTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelQualityPresetJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelQualityPresetNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationJsonConverter(),
                    new global::G.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter(),
                    new global::G.JsonConverters.RAGIndexStatusJsonConverter(),
                    new global::G.JsonConverters.RAGIndexStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ShareOptionResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.ShareOptionResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SafetyRuleJsonConverter(),
                    new global::G.JsonConverters.SafetyRuleNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter(),
                    new global::G.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCurrencyJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCurrencyNullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelStatusJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelBillingPeriodJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelBillingPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriodJsonConverter(),
                    new global::G.JsonConverters.SubscriptionResponseModelCharacterRefreshPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.ListGeneratedItemsV1HistoryGetSourceJsonConverter(),
                    new global::G.JsonConverters.ListGeneratedItemsV1HistoryGetSourceNullableJsonConverter(),
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
                    new global::G.JsonConverters.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.SpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatJsonConverter(),
                    new global::G.JsonConverters.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeJsonConverter(),
                    new global::G.JsonConverters.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetVoicesV1SharedVoicesGetCategoryJsonConverter(),
                    new global::G.JsonConverters.GetVoicesV1SharedVoicesGetCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionariesV1PronunciationDictionariesGetSortJsonConverter(),
                    new global::G.JsonConverters.GetPronunciationDictionariesV1PronunciationDictionariesGetSortNullableJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolsItem2JsonConverter(),
                    new global::G.JsonConverters.ToolsItem3JsonConverter(),
                    new global::G.JsonConverters.ToolsItemJsonConverter(),
                    new global::G.JsonConverters.AgentToolsItemJsonConverter(),
                    new global::G.JsonConverters.AgentsItemJsonConverter(),
                    new global::G.JsonConverters.DocumentsItemJsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItem2JsonConverter(),
                    new global::G.JsonConverters.DependentAgentsItemJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiKnowledgeBaseDocumentationIdGetResponseJsonConverter(),
                    new global::G.JsonConverters.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChapterContentBlockTtsNodeResponseModel, global::G.ChapterContentBlockExtendableNodeResponseModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ConvAISecretLocator>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastConversationMode, global::G.PodcastBulletinMode>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastConversationMode, global::G.PodcastBulletinMode>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PodcastTextSource, global::G.PodcastURLSource>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PodcastTextSource, global::G.PodcastURLSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OrbAvatar, global::G.URLAvatar, global::G.ImageAvatar>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
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
        /// Transcribe your audio files with detailed speaker annotations and precise timestamps using our cutting-edge model. Speech-to-text is currently in alpha and available to a select group of users. We plan to roll it out more broadly soon.
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
        /// Access to voices created either by you or us.
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
        /// Access, create and convert Projects programmatically, only specifically whitelisted accounts can access the Projects API. If you need access please contact our sales team.
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
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