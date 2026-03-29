//HintName: G.Models.ILogicalDocumentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ILogicalDocumentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/asset-created")]
        AgentAssetCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/asset-done")]
        AgentAssetDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/asset-error")]
        AgentAssetError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/asset-started")]
        AgentAssetStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/created")]
        AgentCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/done")]
        AgentDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/error")]
        AgentError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/insights/deleted")]
        AgentInsightsDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/ready")]
        AgentReady,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/ready-for-preprocess")]
        AgentReadyForPreprocess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/rejected")]
        AgentRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent/started")]
        AgentStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate-task/created")]
        AnimateTaskCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate/created")]
        AnimateCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate/done")]
        AnimateDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate/error")]
        AnimateError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate/post-done")]
        AnimatePostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate/post-error")]
        AnimatePostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate/started")]
        AnimateStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio/rejected")]
        AudioRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat/data-deleted")]
        ChatDataDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat/messages-added")]
        ChatMessagesAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat/progress")]
        ChatProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat/speak")]
        ChatSpeak,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chats/invoice/failed")]
        ChatsInvoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chats/invoice/paid")]
        ChatsInvoicePaid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-created")]
        ClipAvatarCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-done")]
        ClipAvatarDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-error")]
        ClipAvatarError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-error-notification")]
        ClipAvatarErrorNotification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-post-done")]
        ClipAvatarPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-progress")]
        ClipAvatarProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-ready")]
        ClipAvatarReady,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-rejected")]
        ClipAvatarRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-started")]
        ClipAvatarStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/avatar-training-artifacts-updated")]
        ClipAvatarTrainingArtifactsUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/created")]
        ClipCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/deleted")]
        ClipDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/done")]
        ClipDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/error")]
        ClipError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/post-done")]
        ClipPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/post-error")]
        ClipPostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/rejected")]
        ClipRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/started")]
        ClipStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/stream/created")]
        ClipStreamCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/stream/done")]
        ClipStreamDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/stream/error")]
        ClipStreamError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/stream/post-done")]
        ClipStreamPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/stream/post-error")]
        ClipStreamPostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/stream/rejected")]
        ClipStreamRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/stream/started")]
        ClipStreamStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip/v2-created")]
        ClipV2Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="consents/done")]
        ConsentsDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="consents/error")]
        ConsentsError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="consents/rejected")]
        ConsentsRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="consents/start-validation")]
        ConsentsStartValidation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credits/charge")]
        CreditsCharge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document/created")]
        DocumentCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document/done")]
        DocumentDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document/error")]
        DocumentError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document/processed")]
        DocumentProcessed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document/rejected")]
        DocumentRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="export/created")]
        ExportCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="export/deleted")]
        ExportDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="export/done")]
        ExportDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="export/error")]
        ExportError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="export/partial")]
        ExportPartial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="export/started")]
        ExportStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/avatar-trained")]
        ExpressiveAvatarTrained,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/created")]
        ExpressiveCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/done")]
        ExpressiveDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/error")]
        ExpressiveError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/post-done")]
        ExpressivePostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/post-error")]
        ExpressivePostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/rejected")]
        ExpressiveRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/started")]
        ExpressiveStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive/stream/done")]
        ExpressiveStreamDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/rejected")]
        ImageRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invoice/failed")]
        InvoiceFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invoice/paid")]
        InvoicePaid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge/done")]
        KnowledgeDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge/error")]
        KnowledgeError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge/processing")]
        KnowledgeProcessing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization/created")]
        OrganizationCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization/deleted")]
        OrganizationDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization/member-added")]
        OrganizationMemberAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project/deleted")]
        ProjectDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project/done")]
        ProjectDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project/error")]
        ProjectError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project/post-done")]
        ProjectPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project/ready")]
        ProjectReady,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project/rejected")]
        ProjectRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project/started")]
        ProjectStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="render/created")]
        RenderCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="render/done")]
        RenderDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="render/error")]
        RenderError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="render/started")]
        RenderStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-created")]
        SceneAvatarCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-done")]
        SceneAvatarDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-error")]
        SceneAvatarError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-item-created")]
        SceneAvatarItemCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-post-done")]
        SceneAvatarPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-post-error")]
        SceneAvatarPostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-started")]
        SceneAvatarStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-training-started")]
        SceneAvatarTrainingStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-validations-done")]
        SceneAvatarValidationsDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/avatar-validations-error")]
        SceneAvatarValidationsError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/created")]
        SceneCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/done")]
        SceneDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/error")]
        SceneError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/post-done")]
        ScenePostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/post-error")]
        ScenePostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene/started")]
        SceneStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scenes/avatars-file-uploaded")]
        ScenesAvatarsFileUploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-video/done")]
        StreamVideoDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-video/error")]
        StreamVideoError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-video/rejected")]
        StreamVideoRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream-video/started")]
        StreamVideoStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream/done")]
        StreamDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/created")]
        TalkCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/deleted")]
        TalkDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/done")]
        TalkDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/error")]
        TalkError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/post-done")]
        TalkPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/post-error")]
        TalkPostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/rejected")]
        TalkRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/started")]
        TalkStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/stream/created")]
        TalkStreamCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/stream/done")]
        TalkStreamDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/stream/error")]
        TalkStreamError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/stream/post-done")]
        TalkStreamPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/stream/post-error")]
        TalkStreamPostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/stream/rejected")]
        TalkStreamRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk/stream/started")]
        TalkStreamStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/audio-data-updated")]
        TranslationAudioDataUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/celeb-detection-done")]
        TranslationCelebDetectionDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/celeb-detection-error")]
        TranslationCelebDetectionError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/deleted")]
        TranslationDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/done")]
        TranslationDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/error")]
        TranslationError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/file-uploaded")]
        TranslationFileUploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/group-done")]
        TranslationGroupDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/group-error")]
        TranslationGroupError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/group-partial-done")]
        TranslationGroupPartialDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/group-partial-error")]
        TranslationGroupPartialError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/group-post-done")]
        TranslationGroupPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/group-post-error")]
        TranslationGroupPostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/group-started")]
        TranslationGroupStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/item-created")]
        TranslationItemCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/post-done")]
        TranslationPostDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/post-error")]
        TranslationPostError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/ready")]
        TranslationReady,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/speech-done")]
        TranslationSpeechDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/speech-error")]
        TranslationSpeechError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/started")]
        TranslationStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation/subtitles-done")]
        TranslationSubtitlesDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trigger/tool/result")]
        TriggerToolResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trigger/webhook/done")]
        TriggerWebhookDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trigger/webhook/error")]
        TriggerWebhookError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/account-merged")]
        UserAccountMerged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/account-merged-manually")]
        UserAccountMergedManually,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/api-key-created")]
        UserApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/deleted")]
        UserDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/first-visit")]
        UserFirstVisit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/registered")]
        UserRegistered,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/subscription-created")]
        UserSubscriptionCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/subscription-deleted")]
        UserSubscriptionDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/subscription-renewed")]
        UserSubscriptionRenewed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/subscription-transferred")]
        UserSubscriptionTransferred,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/subscription-updated")]
        UserSubscriptionUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/subscription-will-end")]
        UserSubscriptionWillEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user/updated")]
        UserUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice/done")]
        VoiceDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice/error")]
        VoiceError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice/rejected")]
        VoiceRejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ILogicalDocumentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ILogicalDocumentStatus value)
        {
            return value switch
            {
                ILogicalDocumentStatus.AgentAssetCreated => "agent/asset-created",
                ILogicalDocumentStatus.AgentAssetDone => "agent/asset-done",
                ILogicalDocumentStatus.AgentAssetError => "agent/asset-error",
                ILogicalDocumentStatus.AgentAssetStarted => "agent/asset-started",
                ILogicalDocumentStatus.AgentCreated => "agent/created",
                ILogicalDocumentStatus.AgentDone => "agent/done",
                ILogicalDocumentStatus.AgentError => "agent/error",
                ILogicalDocumentStatus.AgentInsightsDeleted => "agent/insights/deleted",
                ILogicalDocumentStatus.AgentReady => "agent/ready",
                ILogicalDocumentStatus.AgentReadyForPreprocess => "agent/ready-for-preprocess",
                ILogicalDocumentStatus.AgentRejected => "agent/rejected",
                ILogicalDocumentStatus.AgentStarted => "agent/started",
                ILogicalDocumentStatus.AnimateTaskCreated => "animate-task/created",
                ILogicalDocumentStatus.AnimateCreated => "animate/created",
                ILogicalDocumentStatus.AnimateDone => "animate/done",
                ILogicalDocumentStatus.AnimateError => "animate/error",
                ILogicalDocumentStatus.AnimatePostDone => "animate/post-done",
                ILogicalDocumentStatus.AnimatePostError => "animate/post-error",
                ILogicalDocumentStatus.AnimateStarted => "animate/started",
                ILogicalDocumentStatus.AudioRejected => "audio/rejected",
                ILogicalDocumentStatus.ChatDataDeleted => "chat/data-deleted",
                ILogicalDocumentStatus.ChatMessagesAdded => "chat/messages-added",
                ILogicalDocumentStatus.ChatProgress => "chat/progress",
                ILogicalDocumentStatus.ChatSpeak => "chat/speak",
                ILogicalDocumentStatus.ChatsInvoiceFailed => "chats/invoice/failed",
                ILogicalDocumentStatus.ChatsInvoicePaid => "chats/invoice/paid",
                ILogicalDocumentStatus.ClipAvatarCreated => "clip/avatar-created",
                ILogicalDocumentStatus.ClipAvatarDone => "clip/avatar-done",
                ILogicalDocumentStatus.ClipAvatarError => "clip/avatar-error",
                ILogicalDocumentStatus.ClipAvatarErrorNotification => "clip/avatar-error-notification",
                ILogicalDocumentStatus.ClipAvatarPostDone => "clip/avatar-post-done",
                ILogicalDocumentStatus.ClipAvatarProgress => "clip/avatar-progress",
                ILogicalDocumentStatus.ClipAvatarReady => "clip/avatar-ready",
                ILogicalDocumentStatus.ClipAvatarRejected => "clip/avatar-rejected",
                ILogicalDocumentStatus.ClipAvatarStarted => "clip/avatar-started",
                ILogicalDocumentStatus.ClipAvatarTrainingArtifactsUpdated => "clip/avatar-training-artifacts-updated",
                ILogicalDocumentStatus.ClipCreated => "clip/created",
                ILogicalDocumentStatus.ClipDeleted => "clip/deleted",
                ILogicalDocumentStatus.ClipDone => "clip/done",
                ILogicalDocumentStatus.ClipError => "clip/error",
                ILogicalDocumentStatus.ClipPostDone => "clip/post-done",
                ILogicalDocumentStatus.ClipPostError => "clip/post-error",
                ILogicalDocumentStatus.ClipRejected => "clip/rejected",
                ILogicalDocumentStatus.ClipStarted => "clip/started",
                ILogicalDocumentStatus.ClipStreamCreated => "clip/stream/created",
                ILogicalDocumentStatus.ClipStreamDone => "clip/stream/done",
                ILogicalDocumentStatus.ClipStreamError => "clip/stream/error",
                ILogicalDocumentStatus.ClipStreamPostDone => "clip/stream/post-done",
                ILogicalDocumentStatus.ClipStreamPostError => "clip/stream/post-error",
                ILogicalDocumentStatus.ClipStreamRejected => "clip/stream/rejected",
                ILogicalDocumentStatus.ClipStreamStarted => "clip/stream/started",
                ILogicalDocumentStatus.ClipV2Created => "clip/v2-created",
                ILogicalDocumentStatus.ConsentsDone => "consents/done",
                ILogicalDocumentStatus.ConsentsError => "consents/error",
                ILogicalDocumentStatus.ConsentsRejected => "consents/rejected",
                ILogicalDocumentStatus.ConsentsStartValidation => "consents/start-validation",
                ILogicalDocumentStatus.CreditsCharge => "credits/charge",
                ILogicalDocumentStatus.DocumentCreated => "document/created",
                ILogicalDocumentStatus.DocumentDone => "document/done",
                ILogicalDocumentStatus.DocumentError => "document/error",
                ILogicalDocumentStatus.DocumentProcessed => "document/processed",
                ILogicalDocumentStatus.DocumentRejected => "document/rejected",
                ILogicalDocumentStatus.ExportCreated => "export/created",
                ILogicalDocumentStatus.ExportDeleted => "export/deleted",
                ILogicalDocumentStatus.ExportDone => "export/done",
                ILogicalDocumentStatus.ExportError => "export/error",
                ILogicalDocumentStatus.ExportPartial => "export/partial",
                ILogicalDocumentStatus.ExportStarted => "export/started",
                ILogicalDocumentStatus.ExpressiveAvatarTrained => "expressive/avatar-trained",
                ILogicalDocumentStatus.ExpressiveCreated => "expressive/created",
                ILogicalDocumentStatus.ExpressiveDone => "expressive/done",
                ILogicalDocumentStatus.ExpressiveError => "expressive/error",
                ILogicalDocumentStatus.ExpressivePostDone => "expressive/post-done",
                ILogicalDocumentStatus.ExpressivePostError => "expressive/post-error",
                ILogicalDocumentStatus.ExpressiveRejected => "expressive/rejected",
                ILogicalDocumentStatus.ExpressiveStarted => "expressive/started",
                ILogicalDocumentStatus.ExpressiveStreamDone => "expressive/stream/done",
                ILogicalDocumentStatus.ImageRejected => "image/rejected",
                ILogicalDocumentStatus.InvoiceFailed => "invoice/failed",
                ILogicalDocumentStatus.InvoicePaid => "invoice/paid",
                ILogicalDocumentStatus.KnowledgeDone => "knowledge/done",
                ILogicalDocumentStatus.KnowledgeError => "knowledge/error",
                ILogicalDocumentStatus.KnowledgeProcessing => "knowledge/processing",
                ILogicalDocumentStatus.OrganizationCreated => "organization/created",
                ILogicalDocumentStatus.OrganizationDeleted => "organization/deleted",
                ILogicalDocumentStatus.OrganizationMemberAdded => "organization/member-added",
                ILogicalDocumentStatus.ProjectDeleted => "project/deleted",
                ILogicalDocumentStatus.ProjectDone => "project/done",
                ILogicalDocumentStatus.ProjectError => "project/error",
                ILogicalDocumentStatus.ProjectPostDone => "project/post-done",
                ILogicalDocumentStatus.ProjectReady => "project/ready",
                ILogicalDocumentStatus.ProjectRejected => "project/rejected",
                ILogicalDocumentStatus.ProjectStarted => "project/started",
                ILogicalDocumentStatus.RenderCreated => "render/created",
                ILogicalDocumentStatus.RenderDone => "render/done",
                ILogicalDocumentStatus.RenderError => "render/error",
                ILogicalDocumentStatus.RenderStarted => "render/started",
                ILogicalDocumentStatus.SceneAvatarCreated => "scene/avatar-created",
                ILogicalDocumentStatus.SceneAvatarDone => "scene/avatar-done",
                ILogicalDocumentStatus.SceneAvatarError => "scene/avatar-error",
                ILogicalDocumentStatus.SceneAvatarItemCreated => "scene/avatar-item-created",
                ILogicalDocumentStatus.SceneAvatarPostDone => "scene/avatar-post-done",
                ILogicalDocumentStatus.SceneAvatarPostError => "scene/avatar-post-error",
                ILogicalDocumentStatus.SceneAvatarStarted => "scene/avatar-started",
                ILogicalDocumentStatus.SceneAvatarTrainingStarted => "scene/avatar-training-started",
                ILogicalDocumentStatus.SceneAvatarValidationsDone => "scene/avatar-validations-done",
                ILogicalDocumentStatus.SceneAvatarValidationsError => "scene/avatar-validations-error",
                ILogicalDocumentStatus.SceneCreated => "scene/created",
                ILogicalDocumentStatus.SceneDone => "scene/done",
                ILogicalDocumentStatus.SceneError => "scene/error",
                ILogicalDocumentStatus.ScenePostDone => "scene/post-done",
                ILogicalDocumentStatus.ScenePostError => "scene/post-error",
                ILogicalDocumentStatus.SceneStarted => "scene/started",
                ILogicalDocumentStatus.ScenesAvatarsFileUploaded => "scenes/avatars-file-uploaded",
                ILogicalDocumentStatus.StreamVideoDone => "stream-video/done",
                ILogicalDocumentStatus.StreamVideoError => "stream-video/error",
                ILogicalDocumentStatus.StreamVideoRejected => "stream-video/rejected",
                ILogicalDocumentStatus.StreamVideoStarted => "stream-video/started",
                ILogicalDocumentStatus.StreamDone => "stream/done",
                ILogicalDocumentStatus.TalkCreated => "talk/created",
                ILogicalDocumentStatus.TalkDeleted => "talk/deleted",
                ILogicalDocumentStatus.TalkDone => "talk/done",
                ILogicalDocumentStatus.TalkError => "talk/error",
                ILogicalDocumentStatus.TalkPostDone => "talk/post-done",
                ILogicalDocumentStatus.TalkPostError => "talk/post-error",
                ILogicalDocumentStatus.TalkRejected => "talk/rejected",
                ILogicalDocumentStatus.TalkStarted => "talk/started",
                ILogicalDocumentStatus.TalkStreamCreated => "talk/stream/created",
                ILogicalDocumentStatus.TalkStreamDone => "talk/stream/done",
                ILogicalDocumentStatus.TalkStreamError => "talk/stream/error",
                ILogicalDocumentStatus.TalkStreamPostDone => "talk/stream/post-done",
                ILogicalDocumentStatus.TalkStreamPostError => "talk/stream/post-error",
                ILogicalDocumentStatus.TalkStreamRejected => "talk/stream/rejected",
                ILogicalDocumentStatus.TalkStreamStarted => "talk/stream/started",
                ILogicalDocumentStatus.TranslationAudioDataUpdated => "translation/audio-data-updated",
                ILogicalDocumentStatus.TranslationCelebDetectionDone => "translation/celeb-detection-done",
                ILogicalDocumentStatus.TranslationCelebDetectionError => "translation/celeb-detection-error",
                ILogicalDocumentStatus.TranslationDeleted => "translation/deleted",
                ILogicalDocumentStatus.TranslationDone => "translation/done",
                ILogicalDocumentStatus.TranslationError => "translation/error",
                ILogicalDocumentStatus.TranslationFileUploaded => "translation/file-uploaded",
                ILogicalDocumentStatus.TranslationGroupDone => "translation/group-done",
                ILogicalDocumentStatus.TranslationGroupError => "translation/group-error",
                ILogicalDocumentStatus.TranslationGroupPartialDone => "translation/group-partial-done",
                ILogicalDocumentStatus.TranslationGroupPartialError => "translation/group-partial-error",
                ILogicalDocumentStatus.TranslationGroupPostDone => "translation/group-post-done",
                ILogicalDocumentStatus.TranslationGroupPostError => "translation/group-post-error",
                ILogicalDocumentStatus.TranslationGroupStarted => "translation/group-started",
                ILogicalDocumentStatus.TranslationItemCreated => "translation/item-created",
                ILogicalDocumentStatus.TranslationPostDone => "translation/post-done",
                ILogicalDocumentStatus.TranslationPostError => "translation/post-error",
                ILogicalDocumentStatus.TranslationReady => "translation/ready",
                ILogicalDocumentStatus.TranslationSpeechDone => "translation/speech-done",
                ILogicalDocumentStatus.TranslationSpeechError => "translation/speech-error",
                ILogicalDocumentStatus.TranslationStarted => "translation/started",
                ILogicalDocumentStatus.TranslationSubtitlesDone => "translation/subtitles-done",
                ILogicalDocumentStatus.TriggerToolResult => "trigger/tool/result",
                ILogicalDocumentStatus.TriggerWebhookDone => "trigger/webhook/done",
                ILogicalDocumentStatus.TriggerWebhookError => "trigger/webhook/error",
                ILogicalDocumentStatus.UserAccountMerged => "user/account-merged",
                ILogicalDocumentStatus.UserAccountMergedManually => "user/account-merged-manually",
                ILogicalDocumentStatus.UserApiKeyCreated => "user/api-key-created",
                ILogicalDocumentStatus.UserDeleted => "user/deleted",
                ILogicalDocumentStatus.UserFirstVisit => "user/first-visit",
                ILogicalDocumentStatus.UserRegistered => "user/registered",
                ILogicalDocumentStatus.UserSubscriptionCreated => "user/subscription-created",
                ILogicalDocumentStatus.UserSubscriptionDeleted => "user/subscription-deleted",
                ILogicalDocumentStatus.UserSubscriptionRenewed => "user/subscription-renewed",
                ILogicalDocumentStatus.UserSubscriptionTransferred => "user/subscription-transferred",
                ILogicalDocumentStatus.UserSubscriptionUpdated => "user/subscription-updated",
                ILogicalDocumentStatus.UserSubscriptionWillEnd => "user/subscription-will-end",
                ILogicalDocumentStatus.UserUpdated => "user/updated",
                ILogicalDocumentStatus.VoiceDone => "voice/done",
                ILogicalDocumentStatus.VoiceError => "voice/error",
                ILogicalDocumentStatus.VoiceRejected => "voice/rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ILogicalDocumentStatus? ToEnum(string value)
        {
            return value switch
            {
                "agent/asset-created" => ILogicalDocumentStatus.AgentAssetCreated,
                "agent/asset-done" => ILogicalDocumentStatus.AgentAssetDone,
                "agent/asset-error" => ILogicalDocumentStatus.AgentAssetError,
                "agent/asset-started" => ILogicalDocumentStatus.AgentAssetStarted,
                "agent/created" => ILogicalDocumentStatus.AgentCreated,
                "agent/done" => ILogicalDocumentStatus.AgentDone,
                "agent/error" => ILogicalDocumentStatus.AgentError,
                "agent/insights/deleted" => ILogicalDocumentStatus.AgentInsightsDeleted,
                "agent/ready" => ILogicalDocumentStatus.AgentReady,
                "agent/ready-for-preprocess" => ILogicalDocumentStatus.AgentReadyForPreprocess,
                "agent/rejected" => ILogicalDocumentStatus.AgentRejected,
                "agent/started" => ILogicalDocumentStatus.AgentStarted,
                "animate-task/created" => ILogicalDocumentStatus.AnimateTaskCreated,
                "animate/created" => ILogicalDocumentStatus.AnimateCreated,
                "animate/done" => ILogicalDocumentStatus.AnimateDone,
                "animate/error" => ILogicalDocumentStatus.AnimateError,
                "animate/post-done" => ILogicalDocumentStatus.AnimatePostDone,
                "animate/post-error" => ILogicalDocumentStatus.AnimatePostError,
                "animate/started" => ILogicalDocumentStatus.AnimateStarted,
                "audio/rejected" => ILogicalDocumentStatus.AudioRejected,
                "chat/data-deleted" => ILogicalDocumentStatus.ChatDataDeleted,
                "chat/messages-added" => ILogicalDocumentStatus.ChatMessagesAdded,
                "chat/progress" => ILogicalDocumentStatus.ChatProgress,
                "chat/speak" => ILogicalDocumentStatus.ChatSpeak,
                "chats/invoice/failed" => ILogicalDocumentStatus.ChatsInvoiceFailed,
                "chats/invoice/paid" => ILogicalDocumentStatus.ChatsInvoicePaid,
                "clip/avatar-created" => ILogicalDocumentStatus.ClipAvatarCreated,
                "clip/avatar-done" => ILogicalDocumentStatus.ClipAvatarDone,
                "clip/avatar-error" => ILogicalDocumentStatus.ClipAvatarError,
                "clip/avatar-error-notification" => ILogicalDocumentStatus.ClipAvatarErrorNotification,
                "clip/avatar-post-done" => ILogicalDocumentStatus.ClipAvatarPostDone,
                "clip/avatar-progress" => ILogicalDocumentStatus.ClipAvatarProgress,
                "clip/avatar-ready" => ILogicalDocumentStatus.ClipAvatarReady,
                "clip/avatar-rejected" => ILogicalDocumentStatus.ClipAvatarRejected,
                "clip/avatar-started" => ILogicalDocumentStatus.ClipAvatarStarted,
                "clip/avatar-training-artifacts-updated" => ILogicalDocumentStatus.ClipAvatarTrainingArtifactsUpdated,
                "clip/created" => ILogicalDocumentStatus.ClipCreated,
                "clip/deleted" => ILogicalDocumentStatus.ClipDeleted,
                "clip/done" => ILogicalDocumentStatus.ClipDone,
                "clip/error" => ILogicalDocumentStatus.ClipError,
                "clip/post-done" => ILogicalDocumentStatus.ClipPostDone,
                "clip/post-error" => ILogicalDocumentStatus.ClipPostError,
                "clip/rejected" => ILogicalDocumentStatus.ClipRejected,
                "clip/started" => ILogicalDocumentStatus.ClipStarted,
                "clip/stream/created" => ILogicalDocumentStatus.ClipStreamCreated,
                "clip/stream/done" => ILogicalDocumentStatus.ClipStreamDone,
                "clip/stream/error" => ILogicalDocumentStatus.ClipStreamError,
                "clip/stream/post-done" => ILogicalDocumentStatus.ClipStreamPostDone,
                "clip/stream/post-error" => ILogicalDocumentStatus.ClipStreamPostError,
                "clip/stream/rejected" => ILogicalDocumentStatus.ClipStreamRejected,
                "clip/stream/started" => ILogicalDocumentStatus.ClipStreamStarted,
                "clip/v2-created" => ILogicalDocumentStatus.ClipV2Created,
                "consents/done" => ILogicalDocumentStatus.ConsentsDone,
                "consents/error" => ILogicalDocumentStatus.ConsentsError,
                "consents/rejected" => ILogicalDocumentStatus.ConsentsRejected,
                "consents/start-validation" => ILogicalDocumentStatus.ConsentsStartValidation,
                "credits/charge" => ILogicalDocumentStatus.CreditsCharge,
                "document/created" => ILogicalDocumentStatus.DocumentCreated,
                "document/done" => ILogicalDocumentStatus.DocumentDone,
                "document/error" => ILogicalDocumentStatus.DocumentError,
                "document/processed" => ILogicalDocumentStatus.DocumentProcessed,
                "document/rejected" => ILogicalDocumentStatus.DocumentRejected,
                "export/created" => ILogicalDocumentStatus.ExportCreated,
                "export/deleted" => ILogicalDocumentStatus.ExportDeleted,
                "export/done" => ILogicalDocumentStatus.ExportDone,
                "export/error" => ILogicalDocumentStatus.ExportError,
                "export/partial" => ILogicalDocumentStatus.ExportPartial,
                "export/started" => ILogicalDocumentStatus.ExportStarted,
                "expressive/avatar-trained" => ILogicalDocumentStatus.ExpressiveAvatarTrained,
                "expressive/created" => ILogicalDocumentStatus.ExpressiveCreated,
                "expressive/done" => ILogicalDocumentStatus.ExpressiveDone,
                "expressive/error" => ILogicalDocumentStatus.ExpressiveError,
                "expressive/post-done" => ILogicalDocumentStatus.ExpressivePostDone,
                "expressive/post-error" => ILogicalDocumentStatus.ExpressivePostError,
                "expressive/rejected" => ILogicalDocumentStatus.ExpressiveRejected,
                "expressive/started" => ILogicalDocumentStatus.ExpressiveStarted,
                "expressive/stream/done" => ILogicalDocumentStatus.ExpressiveStreamDone,
                "image/rejected" => ILogicalDocumentStatus.ImageRejected,
                "invoice/failed" => ILogicalDocumentStatus.InvoiceFailed,
                "invoice/paid" => ILogicalDocumentStatus.InvoicePaid,
                "knowledge/done" => ILogicalDocumentStatus.KnowledgeDone,
                "knowledge/error" => ILogicalDocumentStatus.KnowledgeError,
                "knowledge/processing" => ILogicalDocumentStatus.KnowledgeProcessing,
                "organization/created" => ILogicalDocumentStatus.OrganizationCreated,
                "organization/deleted" => ILogicalDocumentStatus.OrganizationDeleted,
                "organization/member-added" => ILogicalDocumentStatus.OrganizationMemberAdded,
                "project/deleted" => ILogicalDocumentStatus.ProjectDeleted,
                "project/done" => ILogicalDocumentStatus.ProjectDone,
                "project/error" => ILogicalDocumentStatus.ProjectError,
                "project/post-done" => ILogicalDocumentStatus.ProjectPostDone,
                "project/ready" => ILogicalDocumentStatus.ProjectReady,
                "project/rejected" => ILogicalDocumentStatus.ProjectRejected,
                "project/started" => ILogicalDocumentStatus.ProjectStarted,
                "render/created" => ILogicalDocumentStatus.RenderCreated,
                "render/done" => ILogicalDocumentStatus.RenderDone,
                "render/error" => ILogicalDocumentStatus.RenderError,
                "render/started" => ILogicalDocumentStatus.RenderStarted,
                "scene/avatar-created" => ILogicalDocumentStatus.SceneAvatarCreated,
                "scene/avatar-done" => ILogicalDocumentStatus.SceneAvatarDone,
                "scene/avatar-error" => ILogicalDocumentStatus.SceneAvatarError,
                "scene/avatar-item-created" => ILogicalDocumentStatus.SceneAvatarItemCreated,
                "scene/avatar-post-done" => ILogicalDocumentStatus.SceneAvatarPostDone,
                "scene/avatar-post-error" => ILogicalDocumentStatus.SceneAvatarPostError,
                "scene/avatar-started" => ILogicalDocumentStatus.SceneAvatarStarted,
                "scene/avatar-training-started" => ILogicalDocumentStatus.SceneAvatarTrainingStarted,
                "scene/avatar-validations-done" => ILogicalDocumentStatus.SceneAvatarValidationsDone,
                "scene/avatar-validations-error" => ILogicalDocumentStatus.SceneAvatarValidationsError,
                "scene/created" => ILogicalDocumentStatus.SceneCreated,
                "scene/done" => ILogicalDocumentStatus.SceneDone,
                "scene/error" => ILogicalDocumentStatus.SceneError,
                "scene/post-done" => ILogicalDocumentStatus.ScenePostDone,
                "scene/post-error" => ILogicalDocumentStatus.ScenePostError,
                "scene/started" => ILogicalDocumentStatus.SceneStarted,
                "scenes/avatars-file-uploaded" => ILogicalDocumentStatus.ScenesAvatarsFileUploaded,
                "stream-video/done" => ILogicalDocumentStatus.StreamVideoDone,
                "stream-video/error" => ILogicalDocumentStatus.StreamVideoError,
                "stream-video/rejected" => ILogicalDocumentStatus.StreamVideoRejected,
                "stream-video/started" => ILogicalDocumentStatus.StreamVideoStarted,
                "stream/done" => ILogicalDocumentStatus.StreamDone,
                "talk/created" => ILogicalDocumentStatus.TalkCreated,
                "talk/deleted" => ILogicalDocumentStatus.TalkDeleted,
                "talk/done" => ILogicalDocumentStatus.TalkDone,
                "talk/error" => ILogicalDocumentStatus.TalkError,
                "talk/post-done" => ILogicalDocumentStatus.TalkPostDone,
                "talk/post-error" => ILogicalDocumentStatus.TalkPostError,
                "talk/rejected" => ILogicalDocumentStatus.TalkRejected,
                "talk/started" => ILogicalDocumentStatus.TalkStarted,
                "talk/stream/created" => ILogicalDocumentStatus.TalkStreamCreated,
                "talk/stream/done" => ILogicalDocumentStatus.TalkStreamDone,
                "talk/stream/error" => ILogicalDocumentStatus.TalkStreamError,
                "talk/stream/post-done" => ILogicalDocumentStatus.TalkStreamPostDone,
                "talk/stream/post-error" => ILogicalDocumentStatus.TalkStreamPostError,
                "talk/stream/rejected" => ILogicalDocumentStatus.TalkStreamRejected,
                "talk/stream/started" => ILogicalDocumentStatus.TalkStreamStarted,
                "translation/audio-data-updated" => ILogicalDocumentStatus.TranslationAudioDataUpdated,
                "translation/celeb-detection-done" => ILogicalDocumentStatus.TranslationCelebDetectionDone,
                "translation/celeb-detection-error" => ILogicalDocumentStatus.TranslationCelebDetectionError,
                "translation/deleted" => ILogicalDocumentStatus.TranslationDeleted,
                "translation/done" => ILogicalDocumentStatus.TranslationDone,
                "translation/error" => ILogicalDocumentStatus.TranslationError,
                "translation/file-uploaded" => ILogicalDocumentStatus.TranslationFileUploaded,
                "translation/group-done" => ILogicalDocumentStatus.TranslationGroupDone,
                "translation/group-error" => ILogicalDocumentStatus.TranslationGroupError,
                "translation/group-partial-done" => ILogicalDocumentStatus.TranslationGroupPartialDone,
                "translation/group-partial-error" => ILogicalDocumentStatus.TranslationGroupPartialError,
                "translation/group-post-done" => ILogicalDocumentStatus.TranslationGroupPostDone,
                "translation/group-post-error" => ILogicalDocumentStatus.TranslationGroupPostError,
                "translation/group-started" => ILogicalDocumentStatus.TranslationGroupStarted,
                "translation/item-created" => ILogicalDocumentStatus.TranslationItemCreated,
                "translation/post-done" => ILogicalDocumentStatus.TranslationPostDone,
                "translation/post-error" => ILogicalDocumentStatus.TranslationPostError,
                "translation/ready" => ILogicalDocumentStatus.TranslationReady,
                "translation/speech-done" => ILogicalDocumentStatus.TranslationSpeechDone,
                "translation/speech-error" => ILogicalDocumentStatus.TranslationSpeechError,
                "translation/started" => ILogicalDocumentStatus.TranslationStarted,
                "translation/subtitles-done" => ILogicalDocumentStatus.TranslationSubtitlesDone,
                "trigger/tool/result" => ILogicalDocumentStatus.TriggerToolResult,
                "trigger/webhook/done" => ILogicalDocumentStatus.TriggerWebhookDone,
                "trigger/webhook/error" => ILogicalDocumentStatus.TriggerWebhookError,
                "user/account-merged" => ILogicalDocumentStatus.UserAccountMerged,
                "user/account-merged-manually" => ILogicalDocumentStatus.UserAccountMergedManually,
                "user/api-key-created" => ILogicalDocumentStatus.UserApiKeyCreated,
                "user/deleted" => ILogicalDocumentStatus.UserDeleted,
                "user/first-visit" => ILogicalDocumentStatus.UserFirstVisit,
                "user/registered" => ILogicalDocumentStatus.UserRegistered,
                "user/subscription-created" => ILogicalDocumentStatus.UserSubscriptionCreated,
                "user/subscription-deleted" => ILogicalDocumentStatus.UserSubscriptionDeleted,
                "user/subscription-renewed" => ILogicalDocumentStatus.UserSubscriptionRenewed,
                "user/subscription-transferred" => ILogicalDocumentStatus.UserSubscriptionTransferred,
                "user/subscription-updated" => ILogicalDocumentStatus.UserSubscriptionUpdated,
                "user/subscription-will-end" => ILogicalDocumentStatus.UserSubscriptionWillEnd,
                "user/updated" => ILogicalDocumentStatus.UserUpdated,
                "voice/done" => ILogicalDocumentStatus.VoiceDone,
                "voice/error" => ILogicalDocumentStatus.VoiceError,
                "voice/rejected" => ILogicalDocumentStatus.VoiceRejected,
                _ => null,
            };
        }
    }
}